namespace TP
{
    partial class FormBuscarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            clienteBindingSource = new System.Windows.Forms.BindingSource(components);
            gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            colTelefonoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            colCP = new DevExpress.XtraGrid.Columns.GridColumn();
            colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            colCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            colNumeroInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            colNumeoExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvClientes).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = clienteBindingSource;
            gridControl1.Location = new System.Drawing.Point(12, 12);
            gridControl1.MainView = gvClientes;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(613, 268);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvClientes });
            gridControl1.DoubleClick += gridView_DoubleClick;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(FarmsRamirezBML.Cliente);
            // 
            // gvClientes
            // 
            gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colIdCliente, colNombres, colApellidoPaterno, colApellidoMaterno, colCelular, colTelefonoFijo, colCorreo, colCP, colEstado, colCiudad, colMunicipio, colColonia, colCalle, colNumeroInterior, colNumeoExterior, colActivo, colFechaRegistro });
            gvClientes.GridControl = gridControl1;
            gvClientes.Name = "gvClientes";
            gvClientes.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdCliente
            // 
            colIdCliente.Caption = "ID";
            colIdCliente.FieldName = "IdCliente";
            colIdCliente.Name = "colIdCliente";
            colIdCliente.OptionsColumn.AllowEdit = false;
            colIdCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colIdCliente.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colIdCliente.OptionsColumn.AllowMove = false;
            colIdCliente.OptionsColumn.AllowSize = false;
            colIdCliente.OptionsColumn.FixedWidth = true;
            colIdCliente.Visible = true;
            colIdCliente.VisibleIndex = 0;
            // 
            // colNombres
            // 
            colNombres.FieldName = "Nombres";
            colNombres.Name = "colNombres";
            colNombres.OptionsColumn.AllowEdit = false;
            colNombres.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colNombres.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colNombres.OptionsColumn.AllowMove = false;
            colNombres.OptionsColumn.AllowSize = false;
            colNombres.OptionsColumn.FixedWidth = true;
            colNombres.Visible = true;
            colNombres.VisibleIndex = 1;
            // 
            // colApellidoPaterno
            // 
            colApellidoPaterno.Caption = "ApellidoPaterno";
            colApellidoPaterno.FieldName = "ApellidoPaterno";
            colApellidoPaterno.Name = "colApellidoPaterno";
            colApellidoPaterno.OptionsColumn.AllowEdit = false;
            colApellidoPaterno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colApellidoPaterno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colApellidoPaterno.OptionsColumn.AllowMove = false;
            colApellidoPaterno.OptionsColumn.AllowSize = false;
            colApellidoPaterno.OptionsColumn.FixedWidth = true;
            colApellidoPaterno.Visible = true;
            colApellidoPaterno.VisibleIndex = 2;
            // 
            // colApellidoMaterno
            // 
            colApellidoMaterno.Caption = "ApellidoMaterno";
            colApellidoMaterno.FieldName = "ApellidoMaterno";
            colApellidoMaterno.Name = "colApellidoMaterno";
            colApellidoMaterno.OptionsColumn.AllowEdit = false;
            colApellidoMaterno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colApellidoMaterno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colApellidoMaterno.OptionsColumn.AllowMove = false;
            colApellidoMaterno.OptionsColumn.AllowSize = false;
            colApellidoMaterno.OptionsColumn.FixedWidth = true;
            colApellidoMaterno.Visible = true;
            colApellidoMaterno.VisibleIndex = 3;
            // 
            // colCelular
            // 
            colCelular.FieldName = "Celular";
            colCelular.Name = "colCelular";
            // 
            // colTelefonoFijo
            // 
            colTelefonoFijo.FieldName = "TelefonoFijo";
            colTelefonoFijo.Name = "colTelefonoFijo";
            // 
            // colCorreo
            // 
            colCorreo.FieldName = "Correo";
            colCorreo.Name = "colCorreo";
            // 
            // colCP
            // 
            colCP.FieldName = "CP";
            colCP.Name = "colCP";
            // 
            // colEstado
            // 
            colEstado.FieldName = "Estado";
            colEstado.Name = "colEstado";
            // 
            // colCiudad
            // 
            colCiudad.FieldName = "Ciudad";
            colCiudad.Name = "colCiudad";
            // 
            // colMunicipio
            // 
            colMunicipio.FieldName = "Municipio";
            colMunicipio.Name = "colMunicipio";
            // 
            // colColonia
            // 
            colColonia.FieldName = "Colonia";
            colColonia.Name = "colColonia";
            // 
            // colCalle
            // 
            colCalle.FieldName = "Calle";
            colCalle.Name = "colCalle";
            // 
            // colNumeroInterior
            // 
            colNumeroInterior.FieldName = "NumeroInterior";
            colNumeroInterior.Name = "colNumeroInterior";
            // 
            // colNumeoExterior
            // 
            colNumeoExterior.FieldName = "NumeoExterior";
            colNumeoExterior.Name = "colNumeoExterior";
            // 
            // colActivo
            // 
            colActivo.FieldName = "Activo";
            colActivo.Name = "colActivo";
            // 
            // colFechaRegistro
            // 
            colFechaRegistro.FieldName = "FechaRegistro";
            colFechaRegistro.Name = "colFechaRegistro";
            // 
            // FormBuscarClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(635, 293);
            Controls.Add(gridControl1);
            Name = "FormBuscarClientes";
            Text = "Buscar Clientes";
            Load += FormBuscarClientes_Load;
            DoubleClick += FormBuscarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colCP;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeoExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
    }
}