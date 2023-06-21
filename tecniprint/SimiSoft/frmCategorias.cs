using DevExpress.XtraEditors;
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
using TECNIPRINT;

namespace SimiSoft
{
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = new Categorias().GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnNuevoCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria
            {
                Text = "Nueva Categoria"
            }.ShowDialog();
            categoriasBindingSource.DataSource = new Categorias().GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnModificarCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria((int)gvCategorias.GetFocusedRowCellValue("IdCategoria"))
            {
                Text = "Modificar Categoria (" + (int)gvCategorias.GetFocusedRowCellValue("IdCategoria") + ")"
            }.ShowDialog();
            categoriasBindingSource.DataSource = new Categorias().GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnEliminarCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Categorias
            {
                IdCategoria = (int)gvCategorias.GetFocusedRowCellValue("IdCategoria")
            }.Delete();
            categoriasBindingSource.DataSource = new Categorias().GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnActualizarCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}