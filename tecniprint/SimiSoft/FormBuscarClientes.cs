using DevExpress.XtraGrid.Views.Grid;
using FarmsRamirezBML;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TP
{
    public partial class FormBuscarClientes : DevExpress.XtraEditors.XtraForm
    {
        public Cliente ClienteSeleccionado { get; private set; }
        public FormBuscarClientes()
        {
            InitializeComponent();
            gvClientes.DoubleClick += gridView_DoubleClick; // Asociar el evento al control GridView
        }

        private void FormBuscarClientes_Load(object sender, EventArgs e)
        {
            // Asigna el bindingSource al DataSource del GridControl.
            clienteBindingSource.DataSource = new Cliente().GetAll();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            // Obtiene la fila seleccionada en el GridControl.
            GridView view = sender as GridView;
            if (view != null)
            {
                int focusedRowHandle = view.FocusedRowHandle;
                if (focusedRowHandle >= 0)
                {
                    Cliente clienteSeleccionado = view.GetRow(focusedRowHandle) as Cliente;

                    // Transfiere los datos al formulario original.
                    frmCotizacionesUV formularioOriginal = Application.OpenForms.OfType<frmCotizacionesUV>().FirstOrDefault();
                    if (formularioOriginal != null)
                    {
                        formularioOriginal.MostrarDatosCliente(clienteSeleccionado);
                    }
                }
            }

            // Cierra el formulario actual.
            Close();
        }

    }
}