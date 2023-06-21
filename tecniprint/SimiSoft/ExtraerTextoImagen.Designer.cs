namespace TP
{
    partial class ExtraerTextoImagen
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
            btnExtraerTexto = new DevExpress.XtraEditors.SimpleButton();
            txtExtraerTexto = new DevExpress.XtraEditors.TextEdit();
            txtImagePath = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtExtraerTexto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtImagePath.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnExtraerTexto
            // 
            btnExtraerTexto.Location = new System.Drawing.Point(116, 138);
            btnExtraerTexto.Name = "btnExtraerTexto";
            btnExtraerTexto.Size = new System.Drawing.Size(75, 23);
            btnExtraerTexto.TabIndex = 0;
            btnExtraerTexto.Text = "Extraer Texto";
            btnExtraerTexto.Click += btnExtraerTexto_Click;
            // 
            // txtExtraerTexto
            // 
            txtExtraerTexto.Location = new System.Drawing.Point(12, 90);
            txtExtraerTexto.Name = "txtExtraerTexto";
            txtExtraerTexto.Size = new System.Drawing.Size(274, 20);
            txtExtraerTexto.TabIndex = 1;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new System.Drawing.Point(12, 52);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new System.Drawing.Size(274, 20);
            txtImagePath.TabIndex = 2;
            // 
            // ExtraerTextoImagen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(298, 268);
            Controls.Add(txtImagePath);
            Controls.Add(txtExtraerTexto);
            Controls.Add(btnExtraerTexto);
            Name = "ExtraerTextoImagen";
            Text = "ExtraerTextoImagen";
            ((System.ComponentModel.ISupportInitialize)txtExtraerTexto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtImagePath.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExtraerTexto;
        private DevExpress.XtraEditors.TextEdit txtExtraerTexto;
        private DevExpress.XtraEditors.TextEdit txtImagePath;
    }
}