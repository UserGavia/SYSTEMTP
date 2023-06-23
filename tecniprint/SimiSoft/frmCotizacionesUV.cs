using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using FarmsRamirezBML;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SimiSoft;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TP
{
    public partial class frmCotizacionesUV : DevExpress.XtraEditors.XtraForm
    {
        public frmCotizacionesUV()
        {
            InitializeComponent();
            txtWhite.Text = "0";
            txtYellow.Text = "0";
            txtMagenta.Text = "0";
            txtBlack.Text = "0";
            txtCyan.Text = "0";
            txtGloss.Text = "0";
            txtLargo.Text = "0";
            txtAncho.Text = "0";
            txtTotalPares.Text = "0";
            txtMinutoImpresion.Text = "0";
            txtMinutoPloteado.Text = "0";
            txtMinutoDepilado.Text = "0";
            txtSegundoImpresion.Text = "0";
            txtSegundoPloteado.Text = "0";
            txtSegundoDepilado.Text = "0";
            txtDescuento.Text = "0";
        }

        //Fecha y Hora en tiempo real
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvImpresionUV.Rows.Add();
            DataGridViewRow row = dgvImpresionUV.Rows[indice_fila];

            int cantidadPares = int.Parse(txtTotalPares.Text);
            int cantidadImpares = cantidadPares * 2;

            row.Cells["Cantidad Pares"].Value = cantidadPares.ToString();
            row.Cells["Cantidad Impares"].Value = cantidadImpares.ToString(); ;
            row.Cells["Descr"].Value = txtEstilo.Text;
            row.Cells["Largo"].Value = txtLargo.Text;
            row.Cells["Ancho"].Value = txtAncho.Text;
            row.Cells["Dto"].Value = txtDescuento.Text;
            row.Cells["Precio Unitario"].Value = lblPrecioUnitario.Text;
            row.Cells["Precio Total"].Value = lblPrecioVenta.Text;
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            // Obtener las filas seleccionadas
            DataGridViewSelectedRowCollection filasSeleccionadas = dgvImpresionUV.SelectedRows;

            // Iterar sobre las filas seleccionadas y eliminarlas
            foreach (DataGridViewRow fila in filasSeleccionadas)
            {
                dgvImpresionUV.Rows.Remove(fila);
            }
        }

        private void frmCotizacionesUV_Load(object sender, EventArgs e)
        {
            //fecha y hora en tiempo real del sistema
            timer1.Enabled = true;

            txtCodigo.Text = string.Format("{0}", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            dgvImpresionUV.Columns.Add("Cantidad Pares", "Cantidad Pares");
            dgvImpresionUV.Columns.Add("Cantidad Impares", "Cantidad Impares");
            dgvImpresionUV.Columns.Add("Descr", "Descr");
            dgvImpresionUV.Columns.Add("Largo", "Largo");
            dgvImpresionUV.Columns.Add("Ancho", "Ancho");
            dgvImpresionUV.Columns.Add("Dto", "Dto");
            dgvImpresionUV.Columns.Add("Precio Unitario", "Precio Unitario");
            dgvImpresionUV.Columns.Add("Precio Total", "Precio Total");
        }

        // Crea una clase personalizada que extienda PdfPageEventHelper
        public class HeaderFooterEvent : PdfPageEventHelper
        {
            private iTextSharp.text.Image logo;

            public HeaderFooterEvent(iTextSharp.text.Image logo)
            {
                this.logo = logo;
            }

            public override void OnStartPage(PdfWriter writer, Document document)
            {
                // Agrega la imagen al encabezado
                PdfPTable headerTable = new PdfPTable(1);
                headerTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                headerTable.AddCell(new PdfPCell(logo) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });
                document.Add(headerTable);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            // Verifica si hay datos en el DataGridView
            if (dgvImpresionUV.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el PDF de cotización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si los campos de TextEdit están completos
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(lblFechaActual.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el PDF de cotización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea un objeto Document
            Document doc = new Document();

            try
            {
                // Define la ubicación y el nombre del archivo PDF de salida
                string outputPath = "C://Users/USER/Pictures/Nueva carpeta/" + txtCodigo.Text + ".pdf";

                // Crea un objeto PdfWriter para escribir en el archivo PDF
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                // Carga la imagen deseada
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("C://Users/USER/Pictures/TECNIPRINT1.jpg");

                // Ajusta el tamaño y la posición de la imagen
                logo.ScaleToFit(100f, 100f);
                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

                // Crea una instancia de la clase personalizada HeaderFooterEvent
                HeaderFooterEvent eventHelper = new HeaderFooterEvent(logo);

                // Establece el evento personalizado en el escritor
                writer.PageEvent = eventHelper;

                // Abre el documento para escribir contenido
                doc.Open();

                // Salto Linea
                doc.Add(new Paragraph("\n"));

                // Agrega el contenido al documento
                // Puedes utilizar métodos como doc.Add() para agregar texto, imágenes, tablas, etc.

                // Agrega información del cliente y la empresa
                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 100;


                PdfPCell clienteCell = new PdfPCell(new Phrase("Cliente: " + txtCliente.Text));
                clienteCell.Border = PdfPCell.NO_BORDER;
                infoTable.AddCell(clienteCell);

                PdfPCell codigoCell = new PdfPCell(new Phrase("Codigo: " + txtCodigo.Text));
                codigoCell.Border = PdfPCell.NO_BORDER;
                infoTable.AddCell(codigoCell);

                PdfPCell fechaCell = new PdfPCell(new Phrase("Fecha: " + lblFechaActual.Text));
                fechaCell.Border = PdfPCell.NO_BORDER;
                infoTable.AddCell(fechaCell);

                PdfPCell empresaCell = new PdfPCell(new Phrase("Nombre de la empresa: " + "TECNIPRINT"));
                empresaCell.Border = PdfPCell.NO_BORDER;
                infoTable.AddCell(empresaCell);

                doc.Add(infoTable);

                // Salto Linea
                doc.Add(new Paragraph("\n"));

                // Agrega el DataGridView como una tabla
                PdfPTable table = new PdfPTable(dgvImpresionUV.Columns.Count);
                table.WidthPercentage = 100;

                // Agrega los encabezados de columna
                for (int i = 0; i < dgvImpresionUV.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgvImpresionUV.Columns[i].HeaderText));
                }

                // Agrega los datos de las filas
                for (int i = 0; i < dgvImpresionUV.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvImpresionUV.Columns.Count; j++)
                    {
                        if (dgvImpresionUV.Rows[i].Cells[j].Value != null)
                        {
                            table.AddCell(new Phrase(dgvImpresionUV.Rows[i].Cells[j].Value.ToString()));
                        }
                        else
                        {
                            table.AddCell(new Phrase(""));
                        }
                    }
                }

                // Ajusta automáticamente el ancho de las columnas al contenido
                table.SetWidths(GetColumnWidths(dgvImpresionUV));

                // Agrega la tabla al documento
                doc.Add(table);

                // Salto linea
                doc.Add(new Paragraph("\n"));

                // Cierra el documento
                doc.Close();

                // Muestra un mensaje de éxito
                MessageBox.Show("El PDF de cotización se generó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Ocurrió un error al generar el PDF de cotización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener los anchos de columna basados en el contenido del DataGridView
        private float[] GetColumnWidths(DataGridView dataGridView)
        {
            float[] widths = new float[dataGridView.Columns.Count];
            float totalWidth = 0f;

            // Calcula el ancho total de las columnas
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                totalWidth += dataGridView.Columns[i].Width;
            }

            // Calcula el ancho proporcional de cada columna
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                float widthPercentage = (dataGridView.Columns[i].Width / totalWidth) * 100f;
                widths[i] = widthPercentage;
            }

            return widths;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCamposExluyendo(this);
            txtWhite.Text = "0";
            txtYellow.Text = "0";
            txtMagenta.Text = "0";
            txtBlack.Text = "0";
            txtCyan.Text = "0";
            txtGloss.Text = "0";
            txtLargo.Text = "0";
            txtAncho.Text = "0";
            txtTotalPares.Text = "0";
            txtMinutoImpresion.Text = "0";
            txtMinutoPloteado.Text = "0";
            txtMinutoDepilado.Text = "0";
            txtSegundoImpresion.Text = "0";
            txtSegundoPloteado.Text = "0";
            txtSegundoDepilado.Text = "0";
        }

        public void BorrarCamposExluyendo(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextEdit && childControl.Name != "txtCodigo")
                {
                    ((TextEdit)childControl).Clear();
                }

                if (childControl.HasChildren)
                {
                    BorrarCamposExluyendo(childControl);
                }
            }
        }

        public void BorrarCampos(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextEdit)
                {
                    ((TextEdit)childControl).Clear();
                }

                if (childControl.HasChildren)
                {
                    BorrarCampos(childControl);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvImpresionUV.Rows.Clear();

            BorrarCampos(this);

            txtCodigo.Text = string.Format("{0}", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            txtWhite.Text = "0";
            txtYellow.Text = "0";
            txtMagenta.Text = "0";
            txtBlack.Text = "0";
            txtCyan.Text = "0";
            txtGloss.Text = "0";
            txtLargo.Text = "0";
            txtAncho.Text = "0";
            txtTotalPares.Text = "0";
            txtMinutoImpresion.Text = "0";
            txtMinutoPloteado.Text = "0";
            txtMinutoDepilado.Text = "0";
            txtSegundoImpresion.Text = "0";
            txtSegundoPloteado.Text = "0";
            txtSegundoDepilado.Text = "0";
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormBuscarClientes buscarClientes = new FormBuscarClientes();

            buscarClientes.ShowDialog();

            // Verifica si se seleccionó un cliente en el formulario secundario
            if (buscarClientes.ClienteSeleccionado != null)
            {
                // Obtiene el cliente seleccionado desde el formulario secundario
                Cliente clienteSeleccionado = buscarClientes.ClienteSeleccionado;

                // Actualiza los controles del formulario original con los datos del cliente seleccionado
                MostrarDatosCliente(clienteSeleccionado);
            }

            // Libera los recursos del formulario secundario
            buscarClientes.Dispose();
        }

        public void MostrarDatosCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                // Actualiza los controles de tu formulario con los datos del cliente.
                txtCliente.Text = cliente.Nombres + " " + cliente.ApellidoPaterno + " " + cliente.ApellidoMaterno;
                // Ajusta el resto de los controles según las propiedades del objeto Cliente.
            }
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            FormBuscarCategorias buscarCategorias = new FormBuscarCategorias();

            buscarCategorias.ShowDialog();

            // Verifica si se seleccionó un cliente en el formulario secundario
            if (buscarCategorias.CategoriaSeleccionado != null)
            {
                // Obtiene el cliente seleccionado desde el formulario secundario
                Categorias categoriaSeleccionado = buscarCategorias.CategoriaSeleccionado;

                // Actualiza los controles del formulario original con los datos del cliente seleccionado
                MostrarDatosCategoria(categoriaSeleccionado);
            }

            // Libera los recursos del formulario secundario
            buscarCategorias.Dispose();
        }

        public void MostrarDatosCategoria(Categorias categoria)
        {
            if (categoria != null)
            {
                // Actualiza los controles de tu formulario con los datos del cliente.
                txtCategoria.Text = categoria.Descripcion;
                // Ajusta el resto de los controles según las propiedades del objeto Cliente.
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            FormBuscarProducto buscarProductos = new FormBuscarProducto();

            buscarProductos.ShowDialog();

            // Verifica si se seleccionó un cliente en el formulario secundario
            if (buscarProductos.ProductoSeleccionado != null)
            {
                // Obtiene el cliente seleccionado desde el formulario secundario
                Producto productoSeleccionado = buscarProductos.ProductoSeleccionado;

                // Actualiza los controles del formulario original con los datos del cliente seleccionado
                MostrarDatosProducto(productoSeleccionado);
            }

            // Libera los recursos del formulario secundario
            buscarProductos.Dispose();
        }

        public void MostrarDatosProducto(Producto producto)
        {
            if (producto != null)
            {
                // Actualiza los controles de tu formulario con los datos del cliente.
                txtProducto.Text = producto.Nombre;
                // Ajusta el resto de los controles según las propiedades del objeto Cliente.
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new ConfigCotizacionesUV
            {
                Text = "Configuracion"
            }.ShowDialog();
        }
    }
}