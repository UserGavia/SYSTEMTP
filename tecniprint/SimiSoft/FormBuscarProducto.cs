using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using FarmsRamirezBML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class FormBuscarProducto : DevExpress.XtraEditors.XtraForm
    {
        public Producto ProductoSeleccionado { get; private set; }
        public FormBuscarProducto()
        {
            InitializeComponent();
            gvProducto.DoubleClick += gridView_DoubleClick;
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
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
                    Producto productoSeleccionado = view.GetRow(focusedRowHandle) as Producto;

                    // Transfiere los datos al formulario original.
                    frmCotizacionesUV formularioOriginal = Application.OpenForms.OfType<frmCotizacionesUV>().FirstOrDefault();
                    if (formularioOriginal != null)
                    {
                        formularioOriginal.MostrarDatosProducto(productoSeleccionado);
                    }
                }
            }

            // Cierra el formulario actual.
            Close();
        }
    }
}