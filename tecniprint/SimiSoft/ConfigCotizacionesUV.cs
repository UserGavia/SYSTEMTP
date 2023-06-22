using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class ConfigCotizacionesUV : DevExpress.XtraEditors.XtraForm
    {
        public ConfigCotizacionesUV()
        {
            InitializeComponent();
            txtCostTiemImp.Text = "0";
            txtCostTiemPlot.Text = "0";
            txtCostTiemDepi.Text = "0";
            txtCostTrans.Text = "0";
            txtCostHotFix.Text = "0";
            txtCostLimNing.Text = "0";
            txtCostLimNorm.Text = "0";
            txtCostLimNormMed.Text = "0";
            txtCostLimPowFull.Text = "0";
            txtCostLimManual.Text = "0";
            txtWhite.Text = "0";
            txtYellow.Text = "0";
            txtMagenta.Text = "0";
            txtBlack.Text = "0";
            txtCyan.Text = "0";
            txtGloss.Text = "0";
        }

        private void groupControl7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}