using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Windows.Forms;

namespace TECNIPRINT
{
    public partial class frmNMCategoria : DevExpress.XtraEditors.XtraForm
    {
        private Categorias categoria;
        public frmNMCategoria()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMCategoria(int IdCategoria)
        {
            InitializeComponent();
            categoria = new Categorias()
            {
                IdCategoria = IdCategoria
            }.GetById();
            txtID.Text = categoria.IdCategoria.ToString();
            txtDescripcion.Text = categoria.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (categoria == null)
                {
                    if (new Categorias
                    {
                        Descripcion = txtDescripcion.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Categoria insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    categoria.Descripcion = txtDescripcion.Text;

                    if (categoria.Update() > 0)
                    {
                        XtraMessageBox.Show("Rol modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingrese la descripcion de la categoria";
                txtDescripcion.Focus();
                ban = true;
            }
            return !ban;
        }
    }
}