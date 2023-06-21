using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frmAsignarPermisosRol : DevExpress.XtraEditors.XtraForm
    {
        public frmAsignarPermisosRol()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
        }

        private void frmAsignarPermisosRol_Load(object sender, EventArgs e)
        {
            List<TipoUsuario> roles = new TipoUsuario().GetAll();
            cbRoles.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Rol" });
            foreach (TipoUsuario row in roles.Where(x => x.Activo == true))
            {
                cbRoles.Items.Add(new ComboBoxItem() { Value = row.IdTipoUsuario, Text = row.Descripcion });
            }
            cbRoles.DisplayMember = "Text";
            cbRoles.ValueMember = "Value";
            cbRoles.SelectedIndex = 0;

            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.MultiSelect = false;
            dgvPermisos.ReadOnly = true;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPermisos.AllowUserToAddRows = false;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Activar";
            checkColumn.HeaderText = "Activar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 30;
            dgvPermisos.Columns.Add(checkColumn);

            dgvPermisos.Columns.Add("permisosID", "permisosID");
            dgvPermisos.Columns.Add("Menu", "Menu");
            dgvPermisos.Columns.Add("Sub Menu", "Sub Menu");
            dgvPermisos.Columns.Add("Activo", "Activo");

            dgvPermisos.Columns["Menu"].FillWeight = 60;
            dgvPermisos.Columns["permisosID"].Visible = false;
            dgvPermisos.Columns["Activo"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.Parse(((ComboBoxItem)cbRoles.SelectedItem).Value.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar un rol", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CargarDatos(int.Parse(((ComboBoxItem)cbRoles.SelectedItem).Value.ToString()));
        }

        private void CargarDatos(int IdTipoUsuario)
        {
            dgvPermisos.Rows.Clear();
            List<Permisos> permisos = Permisos.GetAll(IdTipoUsuario);
            if (permisos.Count > 0)
            {
                foreach (Permisos r in permisos)
                {
                    int rowID = dgvPermisos.Rows.Add();
                    DataGridViewRow row = dgvPermisos.Rows[rowID];
                    row.Cells["IdPermisos"].Value = r.IdPermisos;
                    row.Cells["Menu"].Value = r.Menu;
                    row.Cells["Sub Menu"].Value = r.SubMenu;
                    row.Cells["Activar"].Value = r.Activo;
                    row.Cells["Activo"].Value = r.Activo;
                }
                dgvPermisos.Columns["IdPermisos"].Visible = false;
                dgvPermisos.Columns["Activo"].Visible = false;
            }
        }

        
    }
}