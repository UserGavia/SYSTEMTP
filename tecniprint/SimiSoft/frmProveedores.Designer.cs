namespace SimiSoft
{
    partial class frmProveedores
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
            this.gcProveedores = new DevExpress.XtraGrid.GridControl();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvProveedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumeroInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumeroExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPaginaWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).BeginInit();
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
            // gcProveedores
            // 
            this.gcProveedores.DataSource = this.proveedorBindingSource1;
            this.gcProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedores.Location = new System.Drawing.Point(0, 20);
            this.gcProveedores.MainView = this.gvProveedores;
            this.gcProveedores.MenuManager = this.barManager3;
            this.gcProveedores.Name = "gcProveedores";
            this.gcProveedores.Size = new System.Drawing.Size(1236, 548);
            this.gcProveedores.TabIndex = 8;
            this.gcProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedores});
            this.gcProveedores.Click += new System.EventHandler(this.gcProveedores_Click);
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataSource = typeof(FarmsRamirezBML.Proveedor);
            // 
            // gvProveedores
            // 
            this.gvProveedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdProveedor,
            this.ColNombreEmpresa,
            this.ColCP,
            this.ColEstado,
            this.ColCiudad,
            this.ColMunicipio,
            this.ColColonia,
            this.ColCalle,
            this.ColNumeroInterior,
            this.ColNumeroExterior,
            this.ColCelular,
            this.colTelefonoFijo,
            this.ColCorreo,
            this.ColPaginaWeb,
            this.ColActivo,
            this.ColFechaRegistro});
            this.gvProveedores.GridControl = this.gcProveedores;
            this.gvProveedores.Name = "gvProveedores";
            this.gvProveedores.OptionsBehavior.Editable = false;
            this.gvProveedores.OptionsView.ColumnAutoWidth = false;
            this.gvProveedores.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProveedores.OptionsView.ShowAutoFilterRow = true;
            this.gvProveedores.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdProveedor
            // 
            this.ColIdProveedor.Caption = "IdProveedor";
            this.ColIdProveedor.FieldName = "IdProveedor";
            this.ColIdProveedor.Name = "ColIdProveedor";
            this.ColIdProveedor.Visible = true;
            this.ColIdProveedor.VisibleIndex = 0;
            // 
            // ColNombreEmpresa
            // 
            this.ColNombreEmpresa.Caption = "NombreEmpresa";
            this.ColNombreEmpresa.FieldName = "NombreEmpresa";
            this.ColNombreEmpresa.Name = "ColNombreEmpresa";
            this.ColNombreEmpresa.Visible = true;
            this.ColNombreEmpresa.VisibleIndex = 1;
            // 
            // ColCP
            // 
            this.ColCP.Caption = "CP";
            this.ColCP.FieldName = "CP";
            this.ColCP.Name = "ColCP";
            this.ColCP.Visible = true;
            this.ColCP.VisibleIndex = 2;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 3;
            // 
            // ColCiudad
            // 
            this.ColCiudad.Caption = "Ciudad";
            this.ColCiudad.FieldName = "Ciudad";
            this.ColCiudad.Name = "ColCiudad";
            this.ColCiudad.Visible = true;
            this.ColCiudad.VisibleIndex = 4;
            // 
            // ColMunicipio
            // 
            this.ColMunicipio.Caption = "Municipio";
            this.ColMunicipio.FieldName = "Municipio";
            this.ColMunicipio.Name = "ColMunicipio";
            this.ColMunicipio.Visible = true;
            this.ColMunicipio.VisibleIndex = 5;
            // 
            // ColColonia
            // 
            this.ColColonia.Caption = "Colonia";
            this.ColColonia.FieldName = "Colonia";
            this.ColColonia.Name = "ColColonia";
            this.ColColonia.Visible = true;
            this.ColColonia.VisibleIndex = 6;
            // 
            // ColCalle
            // 
            this.ColCalle.Caption = "Calle";
            this.ColCalle.FieldName = "Calle";
            this.ColCalle.Name = "ColCalle";
            this.ColCalle.Visible = true;
            this.ColCalle.VisibleIndex = 7;
            // 
            // ColNumeroInterior
            // 
            this.ColNumeroInterior.Caption = "NumeroInterior";
            this.ColNumeroInterior.FieldName = "NumeroInterior";
            this.ColNumeroInterior.Name = "ColNumeroInterior";
            this.ColNumeroInterior.Visible = true;
            this.ColNumeroInterior.VisibleIndex = 8;
            // 
            // ColNumeroExterior
            // 
            this.ColNumeroExterior.Caption = "NumeroExterior";
            this.ColNumeroExterior.FieldName = "NumeroExterior";
            this.ColNumeroExterior.Name = "ColNumeroExterior";
            this.ColNumeroExterior.Visible = true;
            this.ColNumeroExterior.VisibleIndex = 9;
            // 
            // ColCelular
            // 
            this.ColCelular.Caption = "Celular";
            this.ColCelular.FieldName = "Celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.Visible = true;
            this.ColCelular.VisibleIndex = 10;
            // 
            // colTelefonoFijo
            // 
            this.colTelefonoFijo.Caption = "TelefonoFijo";
            this.colTelefonoFijo.FieldName = "TelefonoFijo";
            this.colTelefonoFijo.Name = "colTelefonoFijo";
            this.colTelefonoFijo.Visible = true;
            this.colTelefonoFijo.VisibleIndex = 11;
            // 
            // ColCorreo
            // 
            this.ColCorreo.Caption = "Correo";
            this.ColCorreo.FieldName = "Correo";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.Visible = true;
            this.ColCorreo.VisibleIndex = 12;
            // 
            // ColPaginaWeb
            // 
            this.ColPaginaWeb.Caption = "PaginaWeb";
            this.ColPaginaWeb.FieldName = "PaginaWeb";
            this.ColPaginaWeb.Name = "ColPaginaWeb";
            this.ColPaginaWeb.Visible = true;
            this.ColPaginaWeb.VisibleIndex = 13;
            // 
            // ColActivo
            // 
            this.ColActivo.Caption = "Activo";
            this.ColActivo.FieldName = "Activo";
            this.ColActivo.Name = "ColActivo";
            // 
            // ColFechaRegistro
            // 
            this.ColFechaRegistro.Caption = "FechaRegistro";
            this.ColFechaRegistro.FieldName = "FechaRegistro";
            this.ColFechaRegistro.Name = "ColFechaRegistro";
            this.ColFechaRegistro.Visible = true;
            this.ColFechaRegistro.VisibleIndex = 14;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 568);
            this.Controls.Add(this.gcProveedores);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).EndInit();
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
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.GridControl gcProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedores;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn ColCP;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private DevExpress.XtraGrid.Columns.GridColumn ColCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn ColMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn ColColonia;
        private DevExpress.XtraGrid.Columns.GridColumn ColCalle;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumeroInterior;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumeroExterior;
        private DevExpress.XtraGrid.Columns.GridColumn ColCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn ColCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn ColPaginaWeb;
        private DevExpress.XtraGrid.Columns.GridColumn ColActivo;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaRegistro;
    }
}