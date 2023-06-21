namespace TP
{
    partial class ConfigCotizacionesUV
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new System.Drawing.Point(12, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(252, 81);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "COSTO POR TIEMPO DE IMPRESION";
            // 
            // groupControl2
            // 
            groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl2.Location = new System.Drawing.Point(12, 99);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(252, 81);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "COSTO POR TIEMPO DE PLOTEADO";
            // 
            // groupControl3
            // 
            groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl3.Location = new System.Drawing.Point(12, 186);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new System.Drawing.Size(252, 81);
            groupControl3.TabIndex = 2;
            groupControl3.Text = "COSTO POR TIEMPO DE DEPILADO";
            // 
            // ConfigCotizacionesUV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 279);
            Controls.Add(groupControl3);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "ConfigCotizacionesUV";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ConfigCotizacionesUV";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}