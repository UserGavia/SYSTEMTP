using DevExpress.XtraEditors;
using FarmsRamirezBML;
using System;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        private Cliente cliente;
        public frmNMCliente()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        public frmNMCliente(int IdCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                IdCliente = IdCliente
            }.GetById();
            txtID.Text = cliente.IdCliente.ToString();
            txtNombres.Text = cliente.Nombres;
            txtApellidoP.Text = cliente.ApellidoPaterno;
            txtApellidoM.Text = cliente.ApellidoMaterno;
            txtCelular.Text = cliente.Celular;
            txtTelFijo.Text = cliente.TelefonoFijo;
            txtCorreo.Text = cliente.Correo;
            txtCodigoPostal.Text = cliente.CP.ToString();
            txtEstado.Text = cliente.Estado;
            txtCiudad.Text = cliente.Ciudad;
            txtMunicipio.Text = cliente.Municipio;
            txtColonia.Text = cliente.Colonia;
            txtCalle.Text = cliente.Calle;
            txtNInterior.Text = cliente.NumeroInterior.ToString();
            txtNExterior.Text = cliente.NumeoExterior.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cliente == null)
                {
                    if (new Cliente
                    {
                        Nombres = txtNombres.Text,
                        ApellidoPaterno = txtApellidoP.Text,
                        ApellidoMaterno = txtApellidoM.Text,
                        Celular = txtCelular.Text,
                        TelefonoFijo = txtTelFijo.Text,
                        Correo = txtCorreo.Text,
                        CP = Convert.ToInt32(txtCodigoPostal.Text),
                        Estado = txtEstado.Text,
                        Ciudad = txtCiudad.Text,
                        Municipio = txtMunicipio.Text,
                        Colonia = txtColonia.Text,
                        Calle = txtCalle.Text,
                        NumeroInterior = Convert.ToInt32(txtNInterior.Text),
                        NumeoExterior = Convert.ToInt32(txtNExterior.Text)

                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la insercion de nuevo cliente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    cliente.Nombres = txtNombres.Text;
                    cliente.ApellidoPaterno = txtApellidoP.Text;
                    cliente.ApellidoMaterno = txtApellidoM.Text;
                    cliente.Celular = txtCelular.Text;
                    cliente.TelefonoFijo = txtTelFijo.Text;
                    cliente.Correo = txtCorreo.Text;
                    cliente.CP = Convert.ToInt32(txtCodigoPostal.Text);
                    cliente.Estado = txtEstado.Text;
                    cliente.Ciudad = txtCiudad.Text;
                    cliente.Municipio = txtMunicipio.Text;
                    cliente.Colonia = txtColonia.Text;
                    cliente.Calle = txtCalle.Text;
                    cliente.NumeroInterior = Convert.ToInt32(txtNInterior.Text);
                    cliente.NumeoExterior = Convert.ToInt32(txtNExterior.Text);

                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificacion ciente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            //Numero Exterior
            if (string.IsNullOrEmpty(txtNExterior.Text))
            {
                txtNExterior.ErrorText = "Ingrese el numero exterior";
                txtNExterior.Focus();
                ban = true;
            }
            //Numero Interior
            if (string.IsNullOrEmpty(txtNInterior.Text))
            {
                txtNInterior.ErrorText = "Ingrese el numero interior o escriba 0";
                txtNInterior.Focus();
                ban = true;
            }
            //Calle
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                txtCalle.ErrorText = "Ingrese una calle";
                txtCalle.Focus();
                ban = true;
            }

            //Colonia
            if (string.IsNullOrEmpty(txtColonia.Text))
            {
                txtColonia.ErrorText = "Ingrese una colonia";
                txtColonia.Focus();
                ban = true;
            }

            //Municipio
            if (string.IsNullOrEmpty(txtMunicipio.Text))
            {
                txtMunicipio.ErrorText = "Ingrese un municipio";
                txtMunicipio.Focus();
                ban = true;
            }

            //Ciudad
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                txtCiudad.ErrorText = "Ingrese una ciudad";
                txtCiudad.Focus();
                ban = true;
            }

            //Estado
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                txtEstado.ErrorText = "Ingrese un estado";
                txtEstado.Focus();
                ban = true;
            }

            //CodigoPostal
            if (string.IsNullOrEmpty(txtCodigoPostal.Text))
            {
                txtCodigoPostal.ErrorText = "Ingrese un codigo postal";
                txtCodigoPostal.Focus();
                ban = true;
            }

            //Correo
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                txtCorreo.ErrorText = "Ingrese un correo";
                txtCorreo.Focus();
                ban = true;
            }

            //Telefono Fijo
            if (string.IsNullOrEmpty(txtTelFijo.Text))
            {
                txtTelFijo.ErrorText = "Ingrese un numero de telefono fijo";
                txtTelFijo.Focus();
                ban = true;
            }

            //Celular
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                txtCelular.ErrorText = "Ingrese un numero de celular";
                txtCelular.Focus();
                ban = true;
            }

            //Apellido Materno
            if (string.IsNullOrEmpty(txtApellidoM.Text))
            {
                txtApellidoM.ErrorText = "Ingrese un apellido materno";
                txtApellidoM.Focus();
                ban = true;
            }

            //Apellido Paterno
            if (string.IsNullOrEmpty(txtApellidoP.Text))
            {
                txtApellidoP.ErrorText = "Ingrese un apellido paterno";
                txtApellidoP.Focus();
                ban = true;
            }

            //Nombres
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                txtNombres.ErrorText = "Ingrese un nombre";
                txtNombres.Focus();
                ban = true;
            }
            return !ban;
        }
    }
}