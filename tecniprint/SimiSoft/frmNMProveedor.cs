using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private Proveedor proveedor;
        public frmNMProveedor()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMProveedor(int IdProveedor)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                IdProveedor = IdProveedor
            }.GetById();
            txtID.Text = proveedor.IdProveedor.ToString();
            txtNombreEmpresa.Text = proveedor.NombreEmpresa;
            txtCodigoPostal.Text = proveedor.CP.ToString();
            txtEstado.Text = proveedor.Estado;
            txtCiudad.Text = proveedor.Ciudad;
            txtMunicipio.Text = proveedor.Municipio;
            txtColonia.Text = proveedor.Colonia;
            txtCalle.Text = proveedor.Calle;
            txtNInterior.Text = proveedor.NumeroInterior.ToString();
            txtNExterior.Text = proveedor.NumeroExterior.ToString();
            txtCelular.Text = proveedor.Celular;
            txtTelefonoFijo.Text = proveedor.TelefonoFijo;
            txtCorreo.Text = proveedor.Correo;
            txtPaginaWeb.Text = proveedor.PaginaWeb;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                {
                    if (new Proveedor
                    {
                        NombreEmpresa = txtNombreEmpresa.Text,
                        CP = Convert.ToInt32(txtCodigoPostal.Text),
                        Estado = txtEstado.Text,
                        Ciudad = txtCiudad.Text,
                        Municipio = txtMunicipio.Text,
                        Colonia = txtColonia.Text,
                        Calle = txtCalle.Text,
                        NumeroInterior = Convert.ToInt32(txtNInterior.Text),
                        NumeroExterior = Convert.ToInt32(txtNExterior.Text),
                        Celular = txtCelular.Text,
                        TelefonoFijo = txtTelefonoFijo.Text,
                        Correo = txtCorreo.Text,
                        PaginaWeb = txtPaginaWeb.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    
                    proveedor.NombreEmpresa = txtNombreEmpresa.Text;
                    proveedor.CP = Convert.ToInt32(txtCodigoPostal.Text);
                    proveedor.Estado = txtEstado.Text;
                    proveedor.Ciudad = txtCiudad.Text;
                    proveedor.Municipio = txtMunicipio.Text;
                    proveedor.Colonia = txtColonia.Text;
                    proveedor.Calle = txtCalle.Text;
                    proveedor.NumeroInterior = Convert.ToInt32(txtNInterior.Text);
                    proveedor.NumeroExterior = Convert.ToInt32(txtNExterior.Text);
                    proveedor.Celular = txtCelular.Text;
                    proveedor.TelefonoFijo = txtTelefonoFijo.Text;
                    proveedor.Correo = txtCorreo.Text;
                    proveedor.PaginaWeb = txtPaginaWeb.Text;

                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //pagina web
            if (string.IsNullOrEmpty(txtPaginaWeb.Text))
            {
                txtPaginaWeb.ErrorText = "Ingresa una pagina web";
                txtPaginaWeb.Focus();
                ban = true;
            }
            //correo
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                txtCorreo.ErrorText = "Ingresa el correo";
                txtCorreo.Focus();
                ban = true;
            }
            //telefono fijo
            if (string.IsNullOrEmpty(txtTelefonoFijo.Text))
            {
                txtTelefonoFijo.ErrorText = "Ingresa el numero de telefono fijo";
                txtTelefonoFijo.Focus();
                ban = true;
            }
            //celular
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                txtCelular.ErrorText = "Ingresa el numero de celular";
                txtCelular.Focus();
                ban = true;
            }
            //numero exterior
            if (string.IsNullOrEmpty(txtNExterior.Text))
            {
                txtNExterior.ErrorText = "Ingresa el numero exterior";
                txtNExterior.Focus();
                ban = true;
            }
            //numero interior
            if (string.IsNullOrEmpty(txtNInterior.Text))
            {
                txtNInterior.ErrorText = "Ingrege el numero interioro o indique 0";
                txtNInterior.Focus();
                ban = true;
            }
            //calle
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                txtCalle.ErrorText = "Ingrese una calle";
                txtCalle.Focus();
                ban = true;
            }
            //colonia
            if (string.IsNullOrEmpty(txtColonia.Text))
            {
                txtColonia.ErrorText = "Ingrese una colonia";
                txtColonia.Focus();
                ban = true;
            }
            //municipio
            if (string.IsNullOrEmpty(txtMunicipio.Text))
            {
                txtMunicipio.ErrorText = "Ingrese un municipio";
                txtMunicipio.Focus();
                ban = true;
            }
            //ciudad
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                txtCiudad.ErrorText = "Ingrese una ciudad";
                txtCiudad.Focus();
                ban = true;
            }
            //estado
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                txtEstado.ErrorText = "Ingrese un estado";
                txtEstado.Focus();
                ban = true;
            }
            //codigo postal
            if (string.IsNullOrEmpty(txtCodigoPostal.Text))
            {
                txtCodigoPostal.ErrorText = "Ingrese un codigo postal";
                txtCodigoPostal.Focus();
                ban = true;
            }
            //nombre empresa
            if (string.IsNullOrEmpty(txtNombreEmpresa.Text))
            {
                txtNombreEmpresa.ErrorText = "Ingrese el nombre de la empresa";
                txtNombreEmpresa.Focus();
                ban = true;
            }
            return !ban;
        }
    }
}