using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Windows.Forms;

namespace TECNIPRINT
{
    public partial class frmNMUsuario : DevExpress.XtraEditors.XtraForm
    {
        private Usuario usuario;
        public frmNMUsuario()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMUsuario(int IdUsuarios)
        {
            InitializeComponent();
            usuario = new Usuario()
            {
                IdUsuarios = IdUsuarios
            }.GetById();
            txtID.Text = usuario.IdUsuarios.ToString();
            txtNombres.Text = usuario.Nombres;
            txtApellidos.Text = usuario.Apellidos;
            txtUsuario.Text = usuario.Username;
            txtPassword.Text = usuario.Password;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (usuario == null)
                {
                    if (new Usuario()
                    {
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Username = txtUsuario.Text,
                        Password = txtPassword.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Usuario insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    usuario.Nombres = txtNombres.Text;
                    usuario.Apellidos = txtApellidos.Text;
                    usuario.Username = txtUsuario.Text;
                    usuario.Password = txtPassword.Text;

                    if (usuario.Update() > 0)
                    {
                        XtraMessageBox.Show("Usuario modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.ErrorText = "Ingrese la contraseña del usuario";
                txtPassword.Focus();
                ban = true;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.ErrorText = "Ingrese su apodo";
                txtUsuario.Focus();
                ban = true;
            }

            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                txtApellidos.ErrorText = "Ingrese el apellido del usuario";
                txtApellidos.Focus();
                ban = true;
            }

            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                txtNombres.ErrorText = "Ingrese el nombre del usuario";
                txtNombres.Focus();
                ban = true;
            }
            return !ban;
        }
    }
}