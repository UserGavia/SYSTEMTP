namespace SimiSoft
{
    partial class frmCategorias
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
            this.btnActualizarCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoCategoria = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificarCategoria = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarCategoria = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.gcCategorias = new DevExpress.XtraGrid.GridControl();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCategorias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategorias)).BeginInit();
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
            this.btnActualizarCategorias,
            this.btnNuevoCategoria,
            this.btnModificarCategoria,
            this.btnEliminarCategoria,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizarCategorias),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevoCategoria),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificarCategoria),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminarCategoria),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem2)});
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizarCategorias
            // 
            this.btnActualizarCategorias.Caption = "Actualizar";
            this.btnActualizarCategorias.Id = 0;
            this.btnActualizarCategorias.Name = "btnActualizarCategorias";
            this.btnActualizarCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizarCategorias_ItemClick);
            // 
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.Caption = "Nuevo";
            this.btnNuevoCategoria.Id = 1;
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoCategoria_ItemClick);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Caption = "Modificar";
            this.btnModificarCategoria.Id = 2;
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificarCategoria_ItemClick);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Caption = "Eliminar";
            this.btnEliminarCategoria.Id = 3;
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarCategoria_ItemClick);
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
            this.barDockControl5.Size = new System.Drawing.Size(1113, 20);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 614);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1113, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 20);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 594);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1113, 20);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 594);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Apariencia";
            this.skinBarSubItem1.Id = 4;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // gcCategorias
            // 
            this.gcCategorias.DataSource = this.categoriasBindingSource;
            this.gcCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategorias.Location = new System.Drawing.Point(0, 20);
            this.gcCategorias.MainView = this.gvCategorias;
            this.gcCategorias.MenuManager = this.barManager3;
            this.gcCategorias.Name = "gcCategorias";
            this.gcCategorias.Size = new System.Drawing.Size(1113, 594);
            this.gcCategorias.TabIndex = 4;
            this.gcCategorias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategorias});
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(FarmsRamirezBML.Categorias);
            // 
            // gvCategorias
            // 
            this.gvCategorias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdCategoria,
            this.ColDescripcion,
            this.ColActivo,
            this.ColFechaRegistro});
            this.gvCategorias.GridControl = this.gcCategorias;
            this.gvCategorias.Name = "gvCategorias";
            this.gvCategorias.OptionsBehavior.Editable = false;
            this.gvCategorias.OptionsView.ColumnAutoWidth = false;
            this.gvCategorias.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCategorias.OptionsView.ShowAutoFilterRow = true;
            this.gvCategorias.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdCategoria
            // 
            this.ColIdCategoria.Caption = "IdCategoria";
            this.ColIdCategoria.FieldName = "IdCategoria";
            this.ColIdCategoria.Name = "ColIdCategoria";
            this.ColIdCategoria.OptionsColumn.AllowEdit = false;
            this.ColIdCategoria.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdCategoria.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColIdCategoria.OptionsColumn.AllowMove = false;
            this.ColIdCategoria.OptionsColumn.AllowSize = false;
            this.ColIdCategoria.OptionsColumn.FixedWidth = true;
            this.ColIdCategoria.Visible = true;
            this.ColIdCategoria.VisibleIndex = 0;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Descripcion";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.OptionsColumn.AllowEdit = false;
            this.ColDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColDescripcion.OptionsColumn.AllowMove = false;
            this.ColDescripcion.OptionsColumn.AllowSize = false;
            this.ColDescripcion.OptionsColumn.FixedWidth = true;
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 1;
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
            this.ColFechaRegistro.OptionsColumn.AllowEdit = false;
            this.ColFechaRegistro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColFechaRegistro.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ColFechaRegistro.OptionsColumn.AllowMove = false;
            this.ColFechaRegistro.OptionsColumn.AllowSize = false;
            this.ColFechaRegistro.OptionsColumn.FixedWidth = true;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 614);
            this.Controls.Add(this.gcCategorias);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarCategorias;
        private DevExpress.XtraBars.BarButtonItem btnNuevoCategoria;
        private DevExpress.XtraBars.BarButtonItem btnModificarCategoria;
        private DevExpress.XtraBars.BarButtonItem btnEliminarCategoria;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.GridControl gcCategorias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategorias;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColActivo;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaRegistro;
    }
}