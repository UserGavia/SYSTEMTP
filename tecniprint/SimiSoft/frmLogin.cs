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

namespace SimiSoft
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (new Usuario
                {
                    Username = txtUsuario.Text,
                    Password = txtContrasena.Text
                }.Login() != null)
                {
                    XtraMessageBox.Show("Acceso correcto");
                    DialogResult = DialogResult.OK;
                    Misc.actualiza = true;
                }
                else
                {
                    XtraMessageBox.Show("Error en las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.EditValue = null;
                    txtContrasena.EditValue = null;
                    txtUsuario.Focus();
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.ErrorText = "Ingrese el usuario";
                txtUsuario.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.ErrorText = "Ingrese la contraseña";
                if (!ban)
                {
                    txtContrasena.Focus();
                    ban = true;
                }
            }
            return !ban;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Deseas cerrar esta pantalla?", Application.ProductName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }
    }
}