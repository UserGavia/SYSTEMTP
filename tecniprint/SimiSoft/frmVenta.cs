using FarmsRamirezBML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace TECNIPRINT
{
    public partial class frmVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmVenta()
        {
            InitializeComponent();
            txtCantidad.TextChanged += txtCantidad_TextChanged;
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        private List<Producto> productos; // Declarar una variable para almacenar los productos

        private void frmVenta_Load(object sender, EventArgs e)
        {
            //fecha y hora en tiempo real del sistema
            timer1.Enabled = true;

            // Obtener la lista de productos
            productos = new Producto().GetAll();

            // Agregar el primer elemento del ComboBox como "Seleccione Producto"
            cbProducto.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Producto" });

            // Agregar los productos activos al ComboBox
            foreach (Producto producto in productos.Where(x => x.Activo == true))
            {
                cbProducto.Items.Add(new ComboBoxItem() { Value = producto.IdProducto, Text = producto.Nombre });
            }

            // Configurar las propiedades del ComboBox
            cbProducto.DisplayMember = "Text";
            cbProducto.ValueMember = "Value";
            cbProducto.SelectedIndex = 0;

            // Manejar el evento de cambio de selección del ComboBox
            cbProducto.SelectedIndexChanged += CbProducto_SelectedIndexChanged;

            //enlistar los clientes
            List<Cliente> clientes = new Cliente().GetAll();
            cbCliente.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Cliente" });
            foreach (Cliente cliente in clientes.Where(x => x.Activo == true))
            {
                cbCliente.Items.Add(new ComboBoxItem() { Value = cliente.IdCliente, Text = cliente.Nombres + " " + cliente.ApellidoPaterno + " " + cliente.ApellidoMaterno });
            }
            cbCliente.DisplayMember = "Text";
            cbCliente.ValueMember = "Value";
            cbCliente.SelectedIndex = 0;
        }

        // Evento de cambio de selección del ComboBox de productos
        private void CbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado
            ComboBoxItem selectedItem = (ComboBoxItem)cbProducto.SelectedItem;
            int productoId = selectedItem.Value;

            // Buscar el producto en la lista
            Producto selectedProduct = productos.FirstOrDefault(p => p.IdProducto == productoId);

            if (selectedProduct != null)
            {
                // Mostrar el precio de venta en el Label
                lblPrecioVenta.Text = selectedProduct.PrecioVenta.ToString();
            }
            else
            {
                // No se ha seleccionado un producto válido, mostrar un valor por defecto en el Label
                lblPrecioVenta.Text = "Precio no disponible";
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto del TextBox es un número válido
            if (int.TryParse(txtCantidad.Text, out int cantidad) && decimal.TryParse(lblPrecioVenta.Text.Replace("$", ""), out decimal precioVenta))
            {
                // Realizar la multiplicación
                decimal precioCantidad = cantidad * precioVenta;

                // Mostrar el resultado en el Label
                lblPrecioCantidad.Text = "$" + precioCantidad.ToString();
            }
        }
        //Fecha y Hora en tiempo real
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }

        private void groupControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}