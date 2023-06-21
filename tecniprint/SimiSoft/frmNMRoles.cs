using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmNMRoles : DevExpress.XtraEditors.XtraForm
    {
        private TipoUsuario tipousuario;
        public frmNMRoles()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMRoles(int IdTipoUsuario)
        {
            InitializeComponent();
            tipousuario = new TipoUsuario
            {
                IdTipoUsuario = IdTipoUsuario
            }.GetById();
            txtID.Text = tipousuario.IdTipoUsuario.ToString();
            txtDescripcion.Text = tipousuario.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (tipousuario == null)
                {
                    if (new TipoUsuario
                    {
                        Descripcion = txtDescripcion.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Rol insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    tipousuario.Descripcion = txtDescripcion.Text;

                    if (tipousuario.Update() > 0)
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
            //descripcion
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingrese la descripcion del rol";
                txtDescripcion.Focus();
                ban = true;
            }
            return !ban;
        }

    }
}