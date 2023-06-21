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
    public partial class FormBuscarCategorias : DevExpress.XtraEditors.XtraForm
    {
        public Categorias CategoriaSeleccionado { get; private set; }
        public FormBuscarCategorias()
        {
            InitializeComponent();
            gvCategorias.DoubleClick += gridView_DoubleClick;
        }

        private void FormBuscarCategorias_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = new Categorias().GetAll();
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
                    Categorias categoriaSeleccionado = view.GetRow(focusedRowHandle) as Categorias;

                    // Transfiere los datos al formulario original.
                    frmCotizacionesUV formularioOriginal = Application.OpenForms.OfType<frmCotizacionesUV>().FirstOrDefault();
                    if (formularioOriginal != null)
                    {
                        formularioOriginal.MostrarDatosCategoria(categoriaSeleccionado);
                    }
                }
            }

            // Cierra el formulario actual.
            Close();
        }
    }
}