using FarmsRamirezBML;
using System;

namespace SimiSoft
{
    public partial class frmCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clienteBindingSource1.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnActualizarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNuevoProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente
            {
                Text = "Nuevo Cliente"
            }.ShowDialog();
            clienteBindingSource1.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("IdCliente"))
            {
                Text = "Modificar Cliente (" + (int)gvClientes.GetFocusedRowCellValue("IdCliente") + ")"
            }.ShowDialog();
            clienteBindingSource1.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnEliminarProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Cliente
            {
                IdCliente = (int)gvClientes.GetFocusedRowCellValue("IdCliente")
            }.Delete();
            clienteBindingSource1.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }


    }
}