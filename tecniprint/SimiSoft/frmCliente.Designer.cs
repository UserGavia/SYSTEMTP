namespace SimiSoft
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.gcCliente = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTelefonoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumeroInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumeroExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager3.DockControls.Add(this.barDockControl5);
            this.barManager3.DockControls.Add(this.barDockControl6);
            this.barManager3.DockControls.Add(this.barDockControl7);
            this.barManager3.DockControls.Add(this.barDockControl8);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizarProducto,
            this.btnNuevoProducto,
            this.btnModificarProducto,
            this.btnEliminarProducto,
            this.skinBarSubItem1,
            this.skinBarSubItem2});
            this.barManager3.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizarProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminarProducto),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem2)});
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Caption = "Actualizar";
            this.btnActualizarProducto.Id = 0;
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizarProducto_ItemClick);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Caption = "Nuevo";
            this.btnNuevoProducto.Id = 1;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoProducto_ItemClick);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Caption = "Modificar";
            this.btnModificarProducto.Id = 2;
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarProducto_ItemClick);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Caption = "Eliminar";
            this.btnEliminarProducto.Id = 3;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarProducto_ItemClick);
            // 
            // skinBarSubItem2
            // 
            this.skinBarSubItem2.Caption = "Apariencia";
            this.skinBarSubItem2.Id = 5;
            this.skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager3;
            this.barDockControl5.Size = new System.Drawing.Size(1236, 20);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 568);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 20);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1236, 20);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 548);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Apariencia";
            this.skinBarSubItem1.Id = 4;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // gcCliente
            // 
            this.gcCliente.DataSource = this.clienteBindingSource1;
            this.gcCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCliente.Location = new System.Drawing.Point(0, 20);
            this.gcCliente.MainView = this.gvClientes;
            this.gcCliente.MenuManager = this.barManager3;
            this.gcCliente.Name = "gcCliente";
            this.gcCliente.Size = new System.Drawing.Size(1236, 548);
            this.gcCliente.TabIndex = 8;
            this.gcCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(FarmsRamirezBML.Cliente);
            // 
            // gvClientes
            // 
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdCliente,
            this.ColNombres,
            this.ColApellidoPaterno,
            this.ColApellidoMaterno,
            this.ColCelular,
            this.ColTelefonoFijo,
            this.ColCorreo,
            this.ColCP,
            this.ColEstado,
            this.ColCiudad,
            this.ColMunicipio,
            this.ColColonia,
            this.ColCalle,
            this.ColNumeroInterior,
            this.ColNumeroExterior,
            this.ColActivo,
            this.ColFechaRegistro});
            this.gvClientes.GridControl = this.gcCliente;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsView.ColumnAutoWidth = false;
            this.gvClientes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdCliente
            // 
            this.ColIdCliente.Caption = "IdCliente";
            this.ColIdCliente.FieldName = "IdCliente";
            this.ColIdCliente.Name = "ColIdCliente";
            this.ColIdCliente.OptionsColumn.AllowEdit = false;
            this.ColIdCliente.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdCliente.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdCliente.OptionsColumn.AllowMove = false;
            this.ColIdCliente.OptionsColumn.AllowSize = false;
            this.ColIdCliente.OptionsColumn.FixedWidth = true;
            this.ColIdCliente.Visible = true;
            this.ColIdCliente.VisibleIndex = 0;
            // 
            // ColNombres
            // 
            this.ColNombres.Caption = "Nombres";
            this.ColNombres.FieldName = "Nombres";
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.OptionsColumn.AllowEdit = false;
            this.ColNombres.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColNombres.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColNombres.OptionsColumn.AllowMove = false;
            this.ColNombres.OptionsColumn.AllowSize = false;
            this.ColNombres.OptionsColumn.FixedWidth = true;
            this.ColNombres.Visible = true;
            this.ColNombres.VisibleIndex = 1;
            // 
            // ColApellidoPaterno
            // 
            this.ColApellidoPaterno.Caption = "ApellidoPaterno";
            this.ColApellidoPaterno.FieldName = "ApellidoPaterno";
            this.ColApellidoPaterno.Name = "ColApellidoPaterno";
            this.ColApellidoPaterno.OptionsColumn.AllowEdit = false;
            this.ColApellidoPaterno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColApellidoPaterno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColApellidoPaterno.OptionsColumn.AllowMove = false;
            this.ColApellidoPaterno.OptionsColumn.AllowSize = false;
            this.ColApellidoPaterno.OptionsColumn.FixedWidth = true;
            this.ColApellidoPaterno.Visible = true;
            this.ColApellidoPaterno.VisibleIndex = 2;
            // 
            // ColApellidoMaterno
            // 
            this.ColApellidoMaterno.Caption = "ApellidoMaterno";
            this.ColApellidoMaterno.FieldName = "ApellidoMaterno";
            this.ColApellidoMaterno.Name = "ColApellidoMaterno";
            this.ColApellidoMaterno.OptionsColumn.AllowEdit = false;
            this.ColApellidoMaterno.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColApellidoMaterno.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColApellidoMaterno.OptionsColumn.AllowMove = false;
            this.ColApellidoMaterno.OptionsColumn.AllowSize = false;
            this.ColApellidoMaterno.OptionsColumn.FixedWidth = true;
            this.ColApellidoMaterno.Visible = true;
            this.ColApellidoMaterno.VisibleIndex = 3;
            // 
            // ColCelular
            // 
            this.ColCelular.Caption = "Celular";
            this.ColCelular.FieldName = "Celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.OptionsColumn.AllowEdit = false;
            this.ColCelular.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCelular.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCelular.OptionsColumn.AllowMove = false;
            this.ColCelular.OptionsColumn.AllowSize = false;
            this.ColCelular.OptionsColumn.FixedWidth = true;
            this.ColCelular.Visible = true;
            this.ColCelular.VisibleIndex = 4;
            // 
            // ColTelefonoFijo
            // 
            this.ColTelefonoFijo.Caption = "TelefonoFijo";
            this.ColTelefonoFijo.FieldName = "TelefonoFijo";
            this.ColTelefonoFijo.Name = "ColTelefonoFijo";
            this.ColTelefonoFijo.OptionsColumn.AllowEdit = false;
            this.ColTelefonoFijo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColTelefonoFijo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColTelefonoFijo.OptionsColumn.AllowMove = false;
            this.ColTelefonoFijo.OptionsColumn.AllowSize = false;
            this.ColTelefonoFijo.OptionsColumn.FixedWidth = true;
            this.ColTelefonoFijo.Visible = true;
            this.ColTelefonoFijo.VisibleIndex = 5;
            // 
            // ColCorreo
            // 
            this.ColCorreo.Caption = "Correo";
            this.ColCorreo.FieldName = "Correo";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.OptionsColumn.AllowEdit = false;
            this.ColCorreo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCorreo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCorreo.OptionsColumn.AllowMove = false;
            this.ColCorreo.OptionsColumn.AllowSize = false;
            this.ColCorreo.OptionsColumn.FixedWidth = true;
            this.ColCorreo.Visible = true;
            this.ColCorreo.VisibleIndex = 6;
            // 
            // ColCP
            // 
            this.ColCP.Caption = "CP";
            this.ColCP.FieldName = "CP";
            this.ColCP.Name = "ColCP";
            this.ColCP.OptionsColumn.AllowEdit = false;
            this.ColCP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCP.OptionsColumn.AllowMove = false;
            this.ColCP.OptionsColumn.AllowSize = false;
            this.ColCP.OptionsColumn.FixedWidth = true;
            this.ColCP.Visible = true;
            this.ColCP.VisibleIndex = 7;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.OptionsColumn.AllowEdit = false;
            this.ColEstado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColEstado.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColEstado.OptionsColumn.AllowMove = false;
            this.ColEstado.OptionsColumn.AllowSize = false;
            this.ColEstado.OptionsColumn.FixedWidth = true;
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 8;
            // 
            // ColCiudad
            // 
            this.ColCiudad.Caption = "Ciudad";
            this.ColCiudad.FieldName = "Ciudad";
            this.ColCiudad.Name = "ColCiudad";
            this.ColCiudad.OptionsColumn.AllowEdit = false;
            this.ColCiudad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCiudad.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCiudad.OptionsColumn.AllowMove = false;
            this.ColCiudad.OptionsColumn.AllowSize = false;
            this.ColCiudad.OptionsColumn.FixedWidth = true;
            this.ColCiudad.Visible = true;
            this.ColCiudad.VisibleIndex = 9;
            // 
            // ColMunicipio
            // 
            this.ColMunicipio.Caption = "Municipio";
            this.ColMunicipio.FieldName = "Municipio";
            this.ColMunicipio.Name = "ColMunicipio";
            this.ColMunicipio.OptionsColumn.AllowEdit = false;
            this.ColMunicipio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColMunicipio.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColMunicipio.OptionsColumn.AllowMove = false;
            this.ColMunicipio.OptionsColumn.AllowSize = false;
            this.ColMunicipio.OptionsColumn.FixedWidth = true;
            this.ColMunicipio.Visible = true;
            this.ColMunicipio.VisibleIndex = 10;
            // 
            // ColColonia
            // 
            this.ColColonia.Caption = "Colonia";
            this.ColColonia.FieldName = "Colonia";
            this.ColColonia.Name = "ColColonia";
            this.ColColonia.OptionsColumn.AllowEdit = false;
            this.ColColonia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColColonia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColColonia.OptionsColumn.AllowMove = false;
            this.ColColonia.OptionsColumn.AllowSize = false;
            this.ColColonia.OptionsColumn.FixedWidth = true;
            this.ColColonia.Visible = true;
            this.ColColonia.VisibleIndex = 11;
            // 
            // ColCalle
            // 
            this.ColCalle.Caption = "Calle";
            this.ColCalle.FieldName = "Calle";
            this.ColCalle.Name = "ColCalle";
            this.ColCalle.OptionsColumn.AllowEdit = false;
            this.ColCalle.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColCalle.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColCalle.OptionsColumn.AllowMove = false;
            this.ColCalle.OptionsColumn.AllowSize = false;
            this.ColCalle.OptionsColumn.FixedWidth = true;
            this.ColCalle.Visible = true;
            this.ColCalle.VisibleIndex = 12;
            // 
            // ColNumeroInterior
            // 
            this.ColNumeroInterior.Caption = "NumeroInterior";
            this.ColNumeroInterior.FieldName = "NumeroInterior";
            this.ColNumeroInterior.Name = "ColNumeroInterior";
            this.ColNumeroInterior.OptionsColumn.AllowEdit = false;
            this.ColNumeroInterior.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColNumeroInterior.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColNumeroInterior.OptionsColumn.AllowMove = false;
            this.ColNumeroInterior.OptionsColumn.AllowSize = false;
            this.ColNumeroInterior.OptionsColumn.FixedWidth = true;
            this.ColNumeroInterior.Visible = true;
            this.ColNumeroInterior.VisibleIndex = 13;
            // 
            // ColNumeroExterior
            // 
            this.ColNumeroExterior.Caption = "NumeroExterior";
            this.ColNumeroExterior.FieldName = "NumeoExterior";
            this.ColNumeroExterior.Name = "ColNumeroExterior";
            this.ColNumeroExterior.OptionsColumn.AllowEdit = false;
            this.ColNumeroExterior.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColNumeroExterior.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColNumeroExterior.OptionsColumn.AllowMove = false;
            this.ColNumeroExterior.OptionsColumn.AllowSize = false;
            this.ColNumeroExterior.OptionsColumn.FixedWidth = true;
            this.ColNumeroExterior.Visible = true;
            this.ColNumeroExterior.VisibleIndex = 14;
            // 
            // ColActivo
            // 
            this.ColActivo.Caption = "Activo";
            this.ColActivo.FieldName = "Activo";
            this.ColActivo.Name = "ColActivo";
            this.ColActivo.OptionsColumn.AllowEdit = false;
            this.ColActivo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColActivo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColActivo.OptionsColumn.AllowMove = false;
            this.ColActivo.OptionsColumn.AllowSize = false;
            this.ColActivo.OptionsColumn.FixedWidth = true;
            // 
            // ColFechaRegistro
            // 
            this.ColFechaRegistro.Caption = "FechaRegistro";
            this.ColFechaRegistro.FieldName = "FechaRegistro";
            this.ColFechaRegistro.Name = "ColFechaRegistro";
            this.ColFechaRegistro.Visible = true;
            this.ColFechaRegistro.VisibleIndex = 15;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gcCliente);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProducto;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProducto;
        private DevExpress.XtraBars.BarButtonItem btnModificarProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProducto;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraGrid.GridControl gcCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn ColCelular;
        private DevExpress.XtraGrid.Columns.GridColumn ColTelefonoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn ColCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn ColCP;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private DevExpress.XtraGrid.Columns.GridColumn ColCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn ColMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn ColColonia;
        private DevExpress.XtraGrid.Columns.GridColumn ColCalle;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumeroInterior;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumeroExterior;
        private DevExpress.XtraGrid.Columns.GridColumn ColActivo;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaRegistro;
    }
}