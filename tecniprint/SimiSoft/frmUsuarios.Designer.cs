namespace SimiSoft
{
    partial class frmUsuarios
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
            this.btnActualizarUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdUsuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdTipoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
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
            this.btnActualizarUsuarios,
            this.btnNuevoUsuario,
            this.btnModificarUsuario,
            this.btnEliminarUsuario,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizarUsuarios),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminarUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem2)});
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.Caption = "Actualizar";
            this.btnActualizarUsuarios.Id = 0;
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Caption = "Nuevo";
            this.btnNuevoUsuario.Id = 1;
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoUsuario_ItemClick);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Caption = "Modificar";
            this.btnModificarUsuario.Id = 2;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarUsuario_ItemClick);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Caption = "Eliminar";
            this.btnEliminarUsuario.Id = 3;
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarUsuario_ItemClick);
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
            this.barDockControl5.Size = new System.Drawing.Size(1198, 20);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 568);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1198, 0);
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
            this.barDockControl8.Location = new System.Drawing.Point(1198, 20);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 548);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Apariencia";
            this.skinBarSubItem1.Id = 4;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.DataSource = this.usuarioBindingSource;
            this.gcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsuarios.Location = new System.Drawing.Point(0, 20);
            this.gcUsuarios.MainView = this.gvUsuarios;
            this.gcUsuarios.MenuManager = this.barManager3;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(1198, 548);
            this.gcUsuarios.TabIndex = 5;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuarios});
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(FarmsRamirezBML.Usuario);
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdUsuarios,
            this.ColNombres,
            this.ColApellidos,
            this.ColUsername,
            this.ColPassword,
            this.ColIdTipoUsuario,
            this.ColActivo});
            this.gvUsuarios.GridControl = this.gcUsuarios;
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.OptionsBehavior.Editable = false;
            this.gvUsuarios.OptionsView.ColumnAutoWidth = false;
            this.gvUsuarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUsuarios.OptionsView.ShowAutoFilterRow = true;
            this.gvUsuarios.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdUsuarios
            // 
            this.ColIdUsuarios.Caption = "IdUsuarios";
            this.ColIdUsuarios.FieldName = "IdUsuarios";
            this.ColIdUsuarios.Name = "ColIdUsuarios";
            this.ColIdUsuarios.OptionsColumn.AllowEdit = false;
            this.ColIdUsuarios.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdUsuarios.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdUsuarios.OptionsColumn.AllowMove = false;
            this.ColIdUsuarios.OptionsColumn.AllowSize = false;
            this.ColIdUsuarios.OptionsColumn.FixedWidth = true;
            this.ColIdUsuarios.Visible = true;
            this.ColIdUsuarios.VisibleIndex = 0;
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
            // ColApellidos
            // 
            this.ColApellidos.Caption = "Apellidos";
            this.ColApellidos.FieldName = "Apellidos";
            this.ColApellidos.Name = "ColApellidos";
            this.ColApellidos.Visible = true;
            this.ColApellidos.VisibleIndex = 2;
            // 
            // ColUsername
            // 
            this.ColUsername.Caption = "Username";
            this.ColUsername.FieldName = "Username";
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.OptionsColumn.AllowEdit = false;
            this.ColUsername.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColUsername.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColUsername.OptionsColumn.AllowMove = false;
            this.ColUsername.OptionsColumn.AllowSize = false;
            this.ColUsername.OptionsColumn.FixedWidth = true;
            this.ColUsername.Visible = true;
            this.ColUsername.VisibleIndex = 3;
            // 
            // ColPassword
            // 
            this.ColPassword.Caption = "Password";
            this.ColPassword.FieldName = "Password";
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.OptionsColumn.AllowEdit = false;
            this.ColPassword.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColPassword.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColPassword.OptionsColumn.AllowMove = false;
            this.ColPassword.OptionsColumn.AllowSize = false;
            this.ColPassword.OptionsColumn.FixedWidth = true;
            this.ColPassword.Visible = true;
            this.ColPassword.VisibleIndex = 4;
            // 
            // ColIdTipoUsuario
            // 
            this.ColIdTipoUsuario.Caption = "IdTipoUsuario";
            this.ColIdTipoUsuario.FieldName = "IdTipoUsuario";
            this.ColIdTipoUsuario.Name = "ColIdTipoUsuario";
            // 
            // ColActivo
            // 
            this.ColActivo.Caption = "Activo";
            this.ColActivo.FieldName = "Activo";
            this.ColActivo.Name = "ColActivo";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 568);
            this.Controls.Add(this.gcUsuarios);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarUsuarios;
        private DevExpress.XtraBars.BarButtonItem btnNuevoUsuario;
        private DevExpress.XtraBars.BarButtonItem btnModificarUsuario;
        private DevExpress.XtraBars.BarButtonItem btnEliminarUsuario;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.GridControl gcUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
        private DevExpress.XtraGrid.Columns.GridColumn ColUsername;
        private DevExpress.XtraGrid.Columns.GridColumn ColPassword;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdTipoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn ColActivo;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidos;
    }
}