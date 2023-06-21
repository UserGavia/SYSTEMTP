
namespace SimiSoft
{
    partial class frmNMProducto
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
            lblID = new DevExpress.XtraEditors.LabelControl();
            txtID = new DevExpress.XtraEditors.TextEdit();
            txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            txtUnidadM = new DevExpress.XtraEditors.TextEdit();
            lblUnidadM = new DevExpress.XtraEditors.LabelControl();
            txtPrecioV = new DevExpress.XtraEditors.TextEdit();
            lblPrecio = new DevExpress.XtraEditors.LabelControl();
            txtStock = new DevExpress.XtraEditors.TextEdit();
            lblStock = new DevExpress.XtraEditors.LabelControl();
            txtMarca = new DevExpress.XtraEditors.TextEdit();
            lblMarca = new DevExpress.XtraEditors.LabelControl();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            txtCodigo = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtNombre = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtPrecioC = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtMargenG = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtStockMin = new DevExpress.XtraEditors.TextEdit();
            txtStockMax = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            btnAbrirImg = new DevExpress.XtraEditors.SimpleButton();
            pbImagen = new System.Windows.Forms.PictureBox();
            pbCodigoBarra = new System.Windows.Forms.PictureBox();
            bntGenerarCodigo = new DevExpress.XtraEditors.SimpleButton();
            cboBarras = new System.Windows.Forms.ComboBox();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            lblCategoria = new DevExpress.XtraEditors.LabelControl();
            cbCategorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescripcion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnidadM.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioV.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMarca.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCodigo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNombre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMargenG.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStockMin.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStockMax.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCodigoBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.Location = new System.Drawing.Point(12, 12);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(15, 13);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(86, 9);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(100, 20);
            txtID.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(304, 9);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(100, 20);
            txtDescripcion.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new System.Drawing.Point(218, 12);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(58, 13);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtUnidadM
            // 
            txtUnidadM.Location = new System.Drawing.Point(304, 35);
            txtUnidadM.Name = "txtUnidadM";
            txtUnidadM.Size = new System.Drawing.Size(100, 20);
            txtUnidadM.TabIndex = 9;
            // 
            // lblUnidadM
            // 
            lblUnidadM.Location = new System.Drawing.Point(218, 38);
            lblUnidadM.Name = "lblUnidadM";
            lblUnidadM.Size = new System.Drawing.Size(74, 13);
            lblUnidadM.TabIndex = 4;
            lblUnidadM.Text = "Unidad Medida:";
            // 
            // txtPrecioV
            // 
            txtPrecioV.Location = new System.Drawing.Point(86, 139);
            txtPrecioV.Name = "txtPrecioV";
            txtPrecioV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtPrecioV.Properties.MaskSettings.Set("mask", "c");
            txtPrecioV.Properties.MaskSettings.Set("culture", "es-MX");
            txtPrecioV.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            txtPrecioV.Properties.MaskSettings.Set("valueType", typeof(decimal));
            txtPrecioV.Properties.UseMaskAsDisplayFormat = true;
            txtPrecioV.Size = new System.Drawing.Size(100, 20);
            txtPrecioV.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new System.Drawing.Point(12, 142);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(64, 13);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio Venta:";
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(304, 87);
            txtStock.Name = "txtStock";
            txtStock.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtStock.Properties.MaskSettings.Set("mask", "d");
            txtStock.Properties.MaskSettings.Set("culture", "es-MX");
            txtStock.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            txtStock.Properties.MaskSettings.Set("valueType", typeof(int));
            txtStock.Properties.UseMaskAsDisplayFormat = true;
            txtStock.Size = new System.Drawing.Size(100, 20);
            txtStock.TabIndex = 11;
            // 
            // lblStock
            // 
            lblStock.Location = new System.Drawing.Point(218, 90);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(30, 13);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new System.Drawing.Point(86, 87);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new System.Drawing.Size(100, 20);
            txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            lblMarca.Location = new System.Drawing.Point(12, 90);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(33, 13);
            lblMarca.TabIndex = 12;
            lblMarca.Text = "Marca:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(137, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(218, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(86, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(100, 20);
            txtCodigo.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(12, 38);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(37, 13);
            labelControl1.TabIndex = 14;
            labelControl1.Text = "Codigo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(86, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 20);
            txtNombre.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(12, 64);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(41, 13);
            labelControl2.TabIndex = 16;
            labelControl2.Text = "Nombre:";
            // 
            // txtPrecioC
            // 
            txtPrecioC.Location = new System.Drawing.Point(86, 113);
            txtPrecioC.Name = "txtPrecioC";
            txtPrecioC.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtPrecioC.Properties.MaskSettings.Set("mask", "c");
            txtPrecioC.Properties.MaskSettings.Set("valueType", typeof(decimal));
            txtPrecioC.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            txtPrecioC.Properties.MaskSettings.Set("culture", "es-MX");
            txtPrecioC.Properties.UseMaskAsDisplayFormat = true;
            txtPrecioC.Size = new System.Drawing.Size(100, 20);
            txtPrecioC.TabIndex = 4;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(12, 116);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(73, 13);
            labelControl3.TabIndex = 18;
            labelControl3.Text = "Precio Compra:";
            // 
            // txtMargenG
            // 
            txtMargenG.Location = new System.Drawing.Point(304, 61);
            txtMargenG.Name = "txtMargenG";
            txtMargenG.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtMargenG.Properties.MaskSettings.Set("mask", "P");
            txtMargenG.Properties.MaskSettings.Set("culture", "es-MX");
            txtMargenG.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            txtMargenG.Properties.MaskSettings.Set("valueType", typeof(int));
            txtMargenG.Properties.UseMaskAsDisplayFormat = true;
            txtMargenG.Size = new System.Drawing.Size(100, 20);
            txtMargenG.TabIndex = 10;
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(218, 64);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(87, 13);
            labelControl4.TabIndex = 20;
            labelControl4.Text = "Margen Ganancia:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(12, 168);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(65, 13);
            labelControl5.TabIndex = 22;
            labelControl5.Text = "Stock Minimo:";
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new System.Drawing.Point(86, 165);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtStockMin.Properties.MaskSettings.Set("mask", "d");
            txtStockMin.Properties.MaskSettings.Set("culture", "es-MX");
            txtStockMin.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            txtStockMin.Properties.MaskSettings.Set("valueType", typeof(int));
            txtStockMin.Properties.UseMaskAsDisplayFormat = true;
            txtStockMin.Size = new System.Drawing.Size(100, 20);
            txtStockMin.TabIndex = 6;
            // 
            // txtStockMax
            // 
            txtStockMax.Location = new System.Drawing.Point(304, 113);
            txtStockMax.Name = "txtStockMax";
            txtStockMax.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtStockMax.Properties.MaskSettings.Set("mask", "d");
            txtStockMax.Properties.MaskSettings.Set("culture", "es-MX");
            txtStockMax.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull);
            txtStockMax.Properties.MaskSettings.Set("valueType", typeof(int));
            txtStockMax.Properties.UseMaskAsDisplayFormat = true;
            txtStockMax.Size = new System.Drawing.Size(100, 20);
            txtStockMax.TabIndex = 12;
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(218, 116);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(69, 13);
            labelControl7.TabIndex = 26;
            labelControl7.Text = "Stock Maximo:";
            // 
            // btnAbrirImg
            // 
            btnAbrirImg.Location = new System.Drawing.Point(68, 125);
            btnAbrirImg.Name = "btnAbrirImg";
            btnAbrirImg.Size = new System.Drawing.Size(75, 23);
            btnAbrirImg.TabIndex = 13;
            btnAbrirImg.Text = "Abrir";
            btnAbrirImg.Click += btnAbrirImg_Click;
            // 
            // pbImagen
            // 
            pbImagen.Location = new System.Drawing.Point(5, 24);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new System.Drawing.Size(200, 95);
            pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 32;
            pbImagen.TabStop = false;
            // 
            // pbCodigoBarra
            // 
            pbCodigoBarra.Location = new System.Drawing.Point(24, 24);
            pbCodigoBarra.Name = "pbCodigoBarra";
            pbCodigoBarra.Size = new System.Drawing.Size(150, 74);
            pbCodigoBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbCodigoBarra.TabIndex = 33;
            pbCodigoBarra.TabStop = false;
            // 
            // bntGenerarCodigo
            // 
            bntGenerarCodigo.Location = new System.Drawing.Point(54, 125);
            bntGenerarCodigo.Name = "bntGenerarCodigo";
            bntGenerarCodigo.Size = new System.Drawing.Size(100, 23);
            bntGenerarCodigo.TabIndex = 36;
            bntGenerarCodigo.Text = "Generar Codigo";
            bntGenerarCodigo.Click += bntGenerarCodigo_Click;
            // 
            // cboBarras
            // 
            cboBarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBarras.FormattingEnabled = true;
            cboBarras.Location = new System.Drawing.Point(42, 102);
            cboBarras.Name = "cboBarras";
            cboBarras.Size = new System.Drawing.Size(121, 21);
            cboBarras.TabIndex = 37;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(pbCodigoBarra);
            groupControl1.Controls.Add(bntGenerarCodigo);
            groupControl1.Controls.Add(cboBarras);
            groupControl1.Location = new System.Drawing.Point(12, 191);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(200, 155);
            groupControl1.TabIndex = 38;
            groupControl1.Text = "Codigo de barras";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(pbImagen);
            groupControl2.Controls.Add(btnAbrirImg);
            groupControl2.Location = new System.Drawing.Point(218, 191);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(210, 155);
            groupControl2.TabIndex = 39;
            groupControl2.Text = "Imagen";
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new System.Drawing.Point(218, 146);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(51, 13);
            lblCategoria.TabIndex = 40;
            lblCategoria.Text = "Categoria:";
            // 
            // cbCategorias
            // 
            cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new System.Drawing.Point(304, 143);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new System.Drawing.Size(121, 21);
            cbCategorias.TabIndex = 41;
            // 
            // frmNMProducto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(441, 408);
            Controls.Add(cbCategorias);
            Controls.Add(lblCategoria);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Controls.Add(txtStockMax);
            Controls.Add(labelControl7);
            Controls.Add(txtStockMin);
            Controls.Add(labelControl5);
            Controls.Add(txtMargenG);
            Controls.Add(labelControl4);
            Controls.Add(txtPrecioC);
            Controls.Add(labelControl3);
            Controls.Add(txtNombre);
            Controls.Add(labelControl2);
            Controls.Add(txtCodigo);
            Controls.Add(labelControl1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecioV);
            Controls.Add(lblPrecio);
            Controls.Add(txtUnidadM);
            Controls.Add(lblUnidadM);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtID);
            Controls.Add(lblID);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNMProducto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NMProducto";
            Load += frmNMProducto_Load;
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescripcion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnidadM.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioV.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMarca.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCodigo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNombre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMargenG.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStockMin.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStockMax.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCodigoBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.TextEdit txtUnidadM;
        private DevExpress.XtraEditors.LabelControl lblUnidadM;
        private DevExpress.XtraEditors.TextEdit txtPrecioV;
        private DevExpress.XtraEditors.LabelControl lblPrecio;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.LabelControl lblMarca;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPrecioC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMargenG;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtStockMin;
        private DevExpress.XtraEditors.TextEdit txtStockMax;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnAbrirImg;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbCodigoBarra;
        private DevExpress.XtraEditors.SimpleButton bntGenerarCodigo;
        private System.Windows.Forms.ComboBox cboBarras;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblCategoria;
        private System.Windows.Forms.ComboBox cbCategorias;
    }
}