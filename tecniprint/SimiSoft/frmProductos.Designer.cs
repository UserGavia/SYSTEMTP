
namespace SimiSoft
{
    partial class frmProductos
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
            bar6 = new DevExpress.XtraBars.Bar();
            bar5 = new DevExpress.XtraBars.Bar();
            bar4 = new DevExpress.XtraBars.Bar();
            gcProductos = new DevExpress.XtraGrid.GridControl();
            productoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            ColIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            ColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ColCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            ColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ColMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            ColUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            ColPrecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            ColMargenGanancia = new DevExpress.XtraGrid.Columns.GridColumn();
            ColPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            ColStock = new DevExpress.XtraGrid.Columns.GridColumn();
            ColStockMin = new DevExpress.XtraGrid.Columns.GridColumn();
            ColStockMax = new DevExpress.XtraGrid.Columns.GridColumn();
            ColActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ColIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategoriaDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ColFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ColImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            barManager3 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            btnActualizarProducto = new DevExpress.XtraBars.BarButtonItem();
            btnNuevoProducto = new DevExpress.XtraBars.BarButtonItem();
            btnModificarProducto = new DevExpress.XtraBars.BarButtonItem();
            btnEliminarProducto = new DevExpress.XtraBars.BarButtonItem();
            skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            bar8 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)gcProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager3).BeginInit();
            SuspendLayout();
            // 
            // bar6
            // 
            bar6.BarName = "Barra de estado";
            bar6.DockCol = 0;
            bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar6.Text = "Barra de estado";
            // 
            // bar5
            // 
            bar5.BarName = "Menú principal";
            bar5.DockCol = 0;
            bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar5.Text = "Menú principal";
            // 
            // bar4
            // 
            bar4.BarName = "Herramientas";
            bar4.DockCol = 0;
            bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar4.Text = "Herramientas";
            // 
            // gcProductos
            // 
            gcProductos.DataSource = productoBindingSource;
            gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            gcProductos.Location = new System.Drawing.Point(0, 20);
            gcProductos.MainView = gvProductos;
            gcProductos.Name = "gcProductos";
            gcProductos.Size = new System.Drawing.Size(1236, 548);
            gcProductos.TabIndex = 8;
            gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvProductos });
            gcProductos.Click += gridControl1_Click;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(FarmsRamirezBML.Producto);
            // 
            // gvProductos
            // 
            gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ColIdProducto, ColCodigo, ColCodigoBarras, ColNombre, ColDescripcion, ColMarca, ColUnidadMedida, ColPrecioCompra, ColMargenGanancia, ColPrecioVenta, ColStock, ColStockMin, ColStockMax, ColActivo, ColIdCategoria, colCategoriaDescripcion, ColFechaRegistro, ColImagen });
            gvProductos.GridControl = gcProductos;
            gvProductos.Name = "gvProductos";
            gvProductos.OptionsBehavior.Editable = false;
            gvProductos.OptionsView.ColumnAutoWidth = false;
            gvProductos.OptionsView.EnableAppearanceEvenRow = true;
            gvProductos.OptionsView.ShowAutoFilterRow = true;
            gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdProducto
            // 
            ColIdProducto.Caption = "IdProducto";
            ColIdProducto.FieldName = "IdProducto";
            ColIdProducto.Name = "ColIdProducto";
            ColIdProducto.OptionsColumn.AllowEdit = false;
            ColIdProducto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColIdProducto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColIdProducto.OptionsColumn.AllowMove = false;
            ColIdProducto.OptionsColumn.AllowSize = false;
            ColIdProducto.OptionsColumn.FixedWidth = true;
            ColIdProducto.Visible = true;
            ColIdProducto.VisibleIndex = 0;
            // 
            // ColCodigo
            // 
            ColCodigo.Caption = "Codigo";
            ColCodigo.FieldName = "Codigo";
            ColCodigo.Name = "ColCodigo";
            ColCodigo.OptionsColumn.AllowEdit = false;
            ColCodigo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColCodigo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColCodigo.OptionsColumn.AllowMove = false;
            ColCodigo.OptionsColumn.AllowSize = false;
            ColCodigo.OptionsColumn.FixedWidth = true;
            ColCodigo.Visible = true;
            ColCodigo.VisibleIndex = 1;
            // 
            // ColCodigoBarras
            // 
            ColCodigoBarras.Caption = "CodigoBarras";
            ColCodigoBarras.FieldName = "CodigoBarras";
            ColCodigoBarras.ImageOptions.SvgImageSize = new System.Drawing.Size(0, 50);
            ColCodigoBarras.Name = "ColCodigoBarras";
            ColCodigoBarras.OptionsColumn.AllowEdit = false;
            ColCodigoBarras.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColCodigoBarras.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColCodigoBarras.OptionsColumn.AllowMove = false;
            ColCodigoBarras.OptionsColumn.AllowSize = false;
            ColCodigoBarras.OptionsColumn.FixedWidth = true;
            ColCodigoBarras.OptionsColumn.ReadOnly = true;
            ColCodigoBarras.Visible = true;
            ColCodigoBarras.VisibleIndex = 2;
            // 
            // ColNombre
            // 
            ColNombre.Caption = "Nombre";
            ColNombre.FieldName = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.OptionsColumn.AllowEdit = false;
            ColNombre.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColNombre.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColNombre.OptionsColumn.AllowMove = false;
            ColNombre.OptionsColumn.AllowSize = false;
            ColNombre.OptionsColumn.FixedWidth = true;
            ColNombre.Visible = true;
            ColNombre.VisibleIndex = 3;
            // 
            // ColDescripcion
            // 
            ColDescripcion.Caption = "Descripcion";
            ColDescripcion.FieldName = "Descripcion";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.OptionsColumn.AllowEdit = false;
            ColDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColDescripcion.OptionsColumn.AllowMove = false;
            ColDescripcion.OptionsColumn.AllowSize = false;
            ColDescripcion.OptionsColumn.FixedWidth = true;
            ColDescripcion.Visible = true;
            ColDescripcion.VisibleIndex = 4;
            // 
            // ColMarca
            // 
            ColMarca.Caption = "Marca";
            ColMarca.FieldName = "Marca";
            ColMarca.Name = "ColMarca";
            ColMarca.OptionsColumn.AllowEdit = false;
            ColMarca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColMarca.OptionsColumn.AllowMove = false;
            ColMarca.OptionsColumn.AllowSize = false;
            ColMarca.OptionsColumn.FixedWidth = true;
            ColMarca.Visible = true;
            ColMarca.VisibleIndex = 5;
            // 
            // ColUnidadMedida
            // 
            ColUnidadMedida.Caption = "UnidadMedida";
            ColUnidadMedida.FieldName = "UnidadMedida";
            ColUnidadMedida.Name = "ColUnidadMedida";
            ColUnidadMedida.OptionsColumn.AllowEdit = false;
            ColUnidadMedida.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColUnidadMedida.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColUnidadMedida.OptionsColumn.AllowMove = false;
            ColUnidadMedida.OptionsColumn.AllowSize = false;
            ColUnidadMedida.OptionsColumn.FixedWidth = true;
            ColUnidadMedida.Visible = true;
            ColUnidadMedida.VisibleIndex = 6;
            // 
            // ColPrecioCompra
            // 
            ColPrecioCompra.Caption = "PrecioCompra";
            ColPrecioCompra.FieldName = "PrecioCompra";
            ColPrecioCompra.Name = "ColPrecioCompra";
            ColPrecioCompra.OptionsColumn.AllowEdit = false;
            ColPrecioCompra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColPrecioCompra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColPrecioCompra.OptionsColumn.AllowMove = false;
            ColPrecioCompra.OptionsColumn.AllowSize = false;
            ColPrecioCompra.OptionsColumn.FixedWidth = true;
            ColPrecioCompra.Visible = true;
            ColPrecioCompra.VisibleIndex = 7;
            // 
            // ColMargenGanancia
            // 
            ColMargenGanancia.Caption = "MargenGanancia";
            ColMargenGanancia.FieldName = "MargenGanancia";
            ColMargenGanancia.Name = "ColMargenGanancia";
            ColMargenGanancia.OptionsColumn.AllowEdit = false;
            ColMargenGanancia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColMargenGanancia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColMargenGanancia.OptionsColumn.AllowMove = false;
            ColMargenGanancia.OptionsColumn.AllowSize = false;
            ColMargenGanancia.OptionsColumn.FixedWidth = true;
            ColMargenGanancia.Visible = true;
            ColMargenGanancia.VisibleIndex = 8;
            // 
            // ColPrecioVenta
            // 
            ColPrecioVenta.Caption = "PrecioVenta";
            ColPrecioVenta.FieldName = "PrecioVenta";
            ColPrecioVenta.Name = "ColPrecioVenta";
            ColPrecioVenta.OptionsColumn.AllowEdit = false;
            ColPrecioVenta.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColPrecioVenta.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColPrecioVenta.OptionsColumn.AllowMove = false;
            ColPrecioVenta.OptionsColumn.AllowSize = false;
            ColPrecioVenta.OptionsColumn.FixedWidth = true;
            ColPrecioVenta.Visible = true;
            ColPrecioVenta.VisibleIndex = 9;
            // 
            // ColStock
            // 
            ColStock.Caption = "Stock";
            ColStock.FieldName = "Stock";
            ColStock.Name = "ColStock";
            ColStock.OptionsColumn.AllowEdit = false;
            ColStock.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColStock.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColStock.OptionsColumn.AllowMove = false;
            ColStock.OptionsColumn.AllowSize = false;
            ColStock.OptionsColumn.FixedWidth = true;
            ColStock.Visible = true;
            ColStock.VisibleIndex = 10;
            // 
            // ColStockMin
            // 
            ColStockMin.Caption = "StockMin";
            ColStockMin.FieldName = "StockMin";
            ColStockMin.Name = "ColStockMin";
            ColStockMin.OptionsColumn.AllowEdit = false;
            ColStockMin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColStockMin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColStockMin.OptionsColumn.AllowMove = false;
            ColStockMin.OptionsColumn.AllowSize = false;
            ColStockMin.OptionsColumn.FixedWidth = true;
            ColStockMin.Visible = true;
            ColStockMin.VisibleIndex = 11;
            // 
            // ColStockMax
            // 
            ColStockMax.Caption = "StockMax";
            ColStockMax.FieldName = "StockMax";
            ColStockMax.Name = "ColStockMax";
            ColStockMax.OptionsColumn.AllowEdit = false;
            ColStockMax.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColStockMax.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColStockMax.OptionsColumn.AllowMove = false;
            ColStockMax.OptionsColumn.AllowSize = false;
            ColStockMax.OptionsColumn.FixedWidth = true;
            ColStockMax.Visible = true;
            ColStockMax.VisibleIndex = 12;
            // 
            // ColActivo
            // 
            ColActivo.Caption = "Activo";
            ColActivo.FieldName = "Activo";
            ColActivo.Name = "ColActivo";
            // 
            // ColIdCategoria
            // 
            ColIdCategoria.Caption = "IdCategoria";
            ColIdCategoria.FieldName = "IdCategoria";
            ColIdCategoria.Name = "ColIdCategoria";
            // 
            // colCategoriaDescripcion
            // 
            colCategoriaDescripcion.Caption = "CategoriaDescripcion";
            colCategoriaDescripcion.FieldName = "CategoriaDescripcion";
            colCategoriaDescripcion.Name = "colCategoriaDescripcion";
            colCategoriaDescripcion.OptionsColumn.AllowEdit = false;
            colCategoriaDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colCategoriaDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colCategoriaDescripcion.OptionsColumn.AllowMove = false;
            colCategoriaDescripcion.OptionsColumn.AllowSize = false;
            colCategoriaDescripcion.OptionsColumn.FixedWidth = true;
            colCategoriaDescripcion.OptionsColumn.ReadOnly = true;
            colCategoriaDescripcion.Visible = true;
            colCategoriaDescripcion.VisibleIndex = 14;
            // 
            // ColFechaRegistro
            // 
            ColFechaRegistro.Caption = "FechaRegistro";
            ColFechaRegistro.FieldName = "FechaRegistro";
            ColFechaRegistro.Name = "ColFechaRegistro";
            ColFechaRegistro.OptionsColumn.AllowEdit = false;
            ColFechaRegistro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColFechaRegistro.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColFechaRegistro.OptionsColumn.AllowMove = false;
            ColFechaRegistro.OptionsColumn.AllowSize = false;
            ColFechaRegistro.OptionsColumn.FixedWidth = true;
            ColFechaRegistro.Visible = true;
            ColFechaRegistro.VisibleIndex = 13;
            // 
            // ColImagen
            // 
            ColImagen.Caption = "Imagen";
            ColImagen.FieldName = "Imagen";
            ColImagen.Name = "ColImagen";
            ColImagen.OptionsColumn.AllowEdit = false;
            ColImagen.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            ColImagen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            ColImagen.OptionsColumn.AllowMove = false;
            ColImagen.OptionsColumn.AllowSize = false;
            ColImagen.OptionsColumn.FixedWidth = true;
            ColImagen.OptionsColumn.ReadOnly = true;
            ColImagen.Visible = true;
            ColImagen.VisibleIndex = 15;
            // 
            // barManager3
            // 
            barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            barManager3.DockControls.Add(barDockControl5);
            barManager3.DockControls.Add(barDockControl6);
            barManager3.DockControls.Add(barDockControl7);
            barManager3.DockControls.Add(barDockControl8);
            barManager3.Form = this;
            barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnActualizarProducto, btnNuevoProducto, btnModificarProducto, btnEliminarProducto, skinBarSubItem1, skinBarSubItem2 });
            barManager3.MaxItemId = 11;
            // 
            // bar1
            // 
            bar1.BarName = "Herramientas";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnActualizarProducto), new DevExpress.XtraBars.LinkPersistInfo(btnNuevoProducto), new DevExpress.XtraBars.LinkPersistInfo(btnModificarProducto), new DevExpress.XtraBars.LinkPersistInfo(btnEliminarProducto), new DevExpress.XtraBars.LinkPersistInfo(skinBarSubItem2) });
            bar1.Text = "Herramientas";
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.Caption = "Actualizar";
            btnActualizarProducto.Id = 0;
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.ItemClick += btnActualizarProducto_ItemClick;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Caption = "Nuevo";
            btnNuevoProducto.Id = 1;
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.ItemClick += btnNuevoProducto_ItemClick;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Caption = "Modificar";
            btnModificarProducto.Id = 2;
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.ItemClick += btnModificarProducto_ItemClick;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Caption = "Eliminar";
            btnEliminarProducto.Id = 3;
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.ItemClick += btnEliminarProducto_ItemClick;
            // 
            // skinBarSubItem2
            // 
            skinBarSubItem2.Caption = "Apariencia";
            skinBarSubItem2.Id = 10;
            skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // barDockControl5
            // 
            barDockControl5.CausesValidation = false;
            barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControl5.Location = new System.Drawing.Point(0, 0);
            barDockControl5.Manager = barManager3;
            barDockControl5.Size = new System.Drawing.Size(1236, 20);
            // 
            // barDockControl6
            // 
            barDockControl6.CausesValidation = false;
            barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControl6.Location = new System.Drawing.Point(0, 568);
            barDockControl6.Manager = barManager3;
            barDockControl6.Size = new System.Drawing.Size(1236, 0);
            // 
            // barDockControl7
            // 
            barDockControl7.CausesValidation = false;
            barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControl7.Location = new System.Drawing.Point(0, 20);
            barDockControl7.Manager = barManager3;
            barDockControl7.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControl8
            // 
            barDockControl8.CausesValidation = false;
            barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControl8.Location = new System.Drawing.Point(1236, 20);
            barDockControl8.Manager = barManager3;
            barDockControl8.Size = new System.Drawing.Size(0, 548);
            // 
            // skinBarSubItem1
            // 
            skinBarSubItem1.Caption = "Apariencia";
            skinBarSubItem1.Id = 4;
            skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar8
            // 
            bar8.BarName = "Barra de estado";
            bar8.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar8.DockCol = 0;
            bar8.DockRow = 0;
            bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar8.OptionsBar.AllowQuickCustomization = false;
            bar8.OptionsBar.DrawDragBorder = false;
            bar8.OptionsBar.UseWholeRow = true;
            bar8.Text = "Barra de estado";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1236, 568);
            Controls.Add(gcProductos);
            Controls.Add(barDockControl7);
            Controls.Add(barDockControl8);
            Controls.Add(barDockControl6);
            Controls.Add(barDockControl5);
            Name = "frmProductos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)gcProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn ColStock;
        private DevExpress.XtraGrid.Columns.GridColumn ColMarca;
        private DevExpress.XtraGrid.Columns.GridColumn ColActivo;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProducto;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProducto;
        private DevExpress.XtraBars.BarButtonItem btnModificarProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProducto;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColMargenGanancia;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColStockMin;
        private DevExpress.XtraGrid.Columns.GridColumn ColStockMax;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn ColImagen;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaDescripcion;
    }
}