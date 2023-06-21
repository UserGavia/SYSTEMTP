using BarcodeLib;
using DevExpress.Mvvm.POCO;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;// para los archivos en memoria
using System.Windows.Forms;


namespace SimiSoft
{
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
        private Producto producto;
        //cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();
            txtID.Enabled = false;

            // Obtener todas las categorías
            List<Categorias> categorias = new Categorias().GetAll();

            // Agregar las descripciones de categoría al ComboBox
            foreach (Categorias categoria in categorias)
            {
                cbCategorias.Items.Add(categoria.Descripcion);
            }

            cbCategorias.SelectedIndex = 0; // Establecer el primer elemento seleccionado por defecto
        }

        public class TipoCodigoBarras
        {
            public int Valor { get; set; }
            public string Texto { get; set; }
        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {
            int indice = 0;
            foreach (var nombre in Enum.GetNames(typeof(BarcodeLib.TYPE)))
            {
                cboBarras.Items.Add(new TipoCodigoBarras() { Valor = indice, Texto = nombre });

                indice++;
            }

            cboBarras.DisplayMember = "Texto";
            cboBarras.ValueMember = "Valor";
            cboBarras.SelectedIndex = 31;
        }

        private bool ExisteCodigoDeBarras(string codigo)
        {
            string filePath = "\\\\User6663-pc\\sistema\\" + codigo + ".png";
            return File.Exists(filePath);
        }

        private void bntGenerarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            if (ExisteCodigoDeBarras(codigo))
            {
                MessageBox.Show("El código de barras ya existe");
                return;
            }

            Image imagenCodigoB;

            int indice = (cboBarras.SelectedItem as TipoCodigoBarras).Valor;

            BarcodeLib.TYPE tipoCodigo = (BarcodeLib.TYPE)indice;

            Barcode codigoBarra = new Barcode();
            codigoBarra.IncludeLabel = true;
            codigoBarra.LabelPosition = LabelPositions.BOTTOMCENTER;

            imagenCodigoB = codigoBarra.Encode(tipoCodigo, codigo, Color.Black, Color.White, 150, 50);

            Bitmap imagenTitulo = convertirTextoImagen(txtNombre.Text, 150, Color.White);

            int alto_imagen_nuevo = imagenCodigoB.Height + imagenTitulo.Height;

            Bitmap imagenNueva = new Bitmap(200, alto_imagen_nuevo);
            Graphics dibujar = Graphics.FromImage(imagenNueva);

            dibujar.DrawImage(imagenTitulo, new Point(0, 0));
            dibujar.DrawImage(imagenCodigoB, new Point(0, imagenTitulo.Height));

            filePath = "\\\\User6663-pc\\sistema\\" + codigo + ".png";

            imagenNueva.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            pbCodigoBarra.BackgroundImage = imagenNueva;

            MessageBox.Show("Código de barras generado y guardado exitosamente");
        }

        string filePath = "";

        public static Bitmap convertirTextoImagen(string texto, int ancho, Color color)
        {
            //creamos el objeto imagen Bitmap
            Bitmap objBitmap = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            //formateamos la fuente (tipo de letra, tamaño)
            System.Drawing.Font objFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            //creamos un objeto Graphics a partir del Bitmap
            Graphics objGraphics = Graphics.FromImage(objBitmap);

            //establecemos el tamaño según la longitud del texto
            Width = ancho;
            Height = (int)objGraphics.MeasureString(texto, objFont).Height + 5;
            objBitmap = new Bitmap(objBitmap, new Size(Width, Height));

            objGraphics = Graphics.FromImage(objBitmap);

            objGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            objGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            StringFormat drawFormat = new StringFormat();
            objGraphics.Clear(color);

            drawFormat.Alignment = StringAlignment.Center;
            objGraphics.DrawString(texto, objFont, new SolidBrush(Color.Black), new RectangleF(0, (objBitmap.Height / 2) - (objBitmap.Height - 10), objBitmap.Width, objBitmap.Height), drawFormat);
            objGraphics.Flush();


            return objBitmap;
        }

        //cuando es modificar producto
        public frmNMProducto(int IdProducto)
        {
            InitializeComponent();
            producto = new Producto
            {
                IdProducto = IdProducto
            }.GetById();
            txtID.Text = producto.IdProducto.ToString();
            txtCodigo.Text = producto.Codigo;
            pbCodigoBarra.ImageLocation = producto.CodigoBarras.ToString();
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtMarca.Text = producto.Marca;
            txtUnidadM.Text = producto.UnidadMedida;
            txtPrecioC.Text = producto.PrecioCompra.ToString();
            txtMargenG.Text = producto.MargenGanancia.ToString();
            txtPrecioV.Text = producto.PrecioVenta.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtStockMin.Text = producto.StockMin.ToString();
            txtStockMax.Text = producto.StockMax.ToString();

            List<Categorias> productos = new Categorias().GetAll();
            foreach (Categorias prod in productos)
            {
                cbCategorias.Items.Add(prod.Descripcion);
            }

            // Obtener el IdCategoria correspondiente a la descripción seleccionada
            string categoriaSeleccionada = producto.CategoriaDescripcion;
            int idCategoriaSeleccionada = productos.Find(prod => prod.Descripcion == categoriaSeleccionada)?.IdCategoria ?? 0;
            cbCategorias.SelectedItem = categoriaSeleccionada;

            // Asignar el IdCategoria al campo correspondiente en el producto
            producto.IdCategoria = idCategoriaSeleccionada;

            pbImagen.ImageLocation = producto.Imagen.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //VARIABLE PARA ALMACENAR LA URL DEL ARCHIVO A SUBIR
        string url = "";

        //METODO PARA SUBIR ARCHIVO A CARPETA 
        private string SubirArchivo(string codigo)
        {
            var rutaSMB = "\\\\User6663-pc\\sistema\\TECNIPRINT" + codigo + ".jpg";
            if (File.Exists(rutaSMB))
                return "";
            File.Copy(url, rutaSMB);
            return rutaSMB;
        }

        //BOTON PARA ABRIR IMAGEN
        private void btnAbrirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "'c:\'";
            openFileDialog.Filter = "jpg (*.jpg)|*.jpg";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                pbImagen.ImageLocation = url;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //GUARDAR DATOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {

                string categoriaSeleccionada = cbCategorias.SelectedItem.ToString();

                List<Categorias> productos = new Categorias().GetAll();
                int idCategoriaSeleccionada = productos.Find(prod => prod.Descripcion == categoriaSeleccionada)?.IdCategoria ?? 0;

                if (producto == null)
                {

                    if (new Producto
                    {
                        Codigo = txtCodigo.Text,
                        CodigoBarras = Convert.ToString(filePath),
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        Marca = txtMarca.Text,
                        UnidadMedida = txtUnidadM.Text,
                        PrecioCompra = txtPrecioC.Text,
                        MargenGanancia = txtMargenG.Text,
                        PrecioVenta = txtPrecioV.Text,
                        Stock = Convert.ToInt32(txtStock.Text),
                        StockMin = Convert.ToInt32(txtStockMin.Text),
                        StockMax = Convert.ToInt32(txtStockMax.Text),
                        IdCategoria = idCategoriaSeleccionada,
                        Imagen = SubirArchivo(txtCodigo.EditValue.ToString())
                    }.Add())
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la insercion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    producto.Codigo = txtCodigo.Text;
                    producto.CodigoBarras = Convert.ToString(filePath);
                    producto.Nombre = txtNombre.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Marca = txtMarca.Text;
                    producto.UnidadMedida = txtUnidadM.Text;
                    producto.PrecioCompra = txtPrecioC.Text;
                    producto.MargenGanancia = txtMargenG.Text;
                    producto.PrecioVenta = txtPrecioV.Text;
                    producto.Stock = Convert.ToInt32(txtStock.Text);
                    producto.StockMin = Convert.ToInt32(txtStockMin.Text);
                    producto.StockMax = Convert.ToInt32(txtStockMax.Text);
                    producto.IdCategoria = idCategoriaSeleccionada;
                    producto.Imagen = SubirArchivo(txtCodigo.EditValue.ToString());

                    if (producto.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificacion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        //VALIDACIONES
        private bool Validar()
        {
            var ban = false;
            //stockMaximo
            if (string.IsNullOrEmpty(txtStockMax.Text))
            {
                txtStockMax.ErrorText = "Ingrese un stock maximo";
                txtStockMax.Focus();
                ban = true;
            }
            //stockMinimo
            if (string.IsNullOrEmpty(txtStockMin.Text))
            {
                txtStockMin.ErrorText = "Ingrese un stock minimo";
                txtStockMin.Focus();
                ban = true;
            }
            //stock
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingrese un stock";
                txtStock.Focus();
                ban = true;
            }
            //precioVenta
            if (string.IsNullOrEmpty(txtPrecioV.Text))
            {
                txtPrecioV.ErrorText = "Ingrese un precio";
                txtPrecioV.Focus();
                ban = true;
            }
            //margenGanancia
            if (string.IsNullOrEmpty(txtMargenG.Text))
            {
                txtMargenG.ErrorText = "Ingrese un precio";
                txtMargenG.Focus();
                ban = true;
            }
            //precioCompra
            if (string.IsNullOrEmpty(txtPrecioC.Text))
            {
                txtPrecioC.ErrorText = "Ingrese un precio";
                txtPrecioC.Focus();
                ban = true;
            }
            //unidadMedida
            if (string.IsNullOrEmpty(txtUnidadM.Text))
            {
                txtUnidadM.ErrorText = "Ingrese una unidad de medida";
                txtUnidadM.Focus();
                ban = true;
            }
            //marca
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingrese una marca";
                txtMarca.Focus();
                ban = true;
            }
            //descripcion
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingrese la descripcion";
                txtDescripcion.Focus();
                ban = true;
            }
            //nombre
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingrese un nombre";
                txtNombre.Focus();
                ban = true;
            }
            //codigo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingrese un codigo";
                txtCodigo.Focus();
                ban = true;
            }
            //valor devuelto
            return !ban;
        }

    }
}