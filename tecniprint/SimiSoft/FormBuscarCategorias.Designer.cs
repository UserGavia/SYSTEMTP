namespace TP
{
    partial class FormBuscarCategorias
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
            categoriasBindingSource = new System.Windows.Forms.BindingSource(components);
            gvCategorias = new DevExpress.XtraGrid.Views.Grid.GridView();
            colIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCategorias).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = categoriasBindingSource;
            gridControl1.Location = new System.Drawing.Point(11, 12);
            gridControl1.MainView = gvCategorias;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(522, 257);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvCategorias });
            gridControl1.DoubleClick += gridView_DoubleClick;
            // 
            // categoriasBindingSource
            // 
            categoriasBindingSource.DataSource = typeof(FarmsRamirezBML.Categorias);
            // 
            // gvCategorias
            // 
            gvCategorias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colIdCategoria, colDescripcion, colActivo, colFechaRegistro });
            gvCategorias.GridControl = gridControl1;
            gvCategorias.Name = "gvCategorias";
            gvCategorias.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdCategoria
            // 
            colIdCategoria.Caption = "ID";
            colIdCategoria.FieldName = "IdCategoria";
            colIdCategoria.Name = "colIdCategoria";
            colIdCategoria.OptionsColumn.AllowEdit = false;
            colIdCategoria.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colIdCategoria.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colIdCategoria.OptionsColumn.AllowMove = false;
            colIdCategoria.OptionsColumn.AllowSize = false;
            colIdCategoria.OptionsColumn.FixedWidth = true;
            colIdCategoria.Visible = true;
            colIdCategoria.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            colDescripcion.Caption = "Descripcion";
            colDescripcion.FieldName = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.OptionsColumn.AllowEdit = false;
            colDescripcion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colDescripcion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colDescripcion.OptionsColumn.AllowMove = false;
            colDescripcion.OptionsColumn.AllowSize = false;
            colDescripcion.OptionsColumn.FixedWidth = true;
            colDescripcion.Visible = true;
            colDescripcion.VisibleIndex = 1;
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
            // FormBuscarCategorias
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(545, 293);
            Controls.Add(gridControl1);
            Name = "FormBuscarCategorias";
            Text = "Buscar Categoria";
            Load += FormBuscarCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategorias;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
    }
}