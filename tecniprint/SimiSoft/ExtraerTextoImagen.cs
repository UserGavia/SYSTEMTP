using IronOcr;
using System;
using System.Windows.Forms;

namespace TP
{
    public partial class ExtraerTextoImagen : DevExpress.XtraEditors.XtraForm
    {
        public ExtraerTextoImagen()
        {
            InitializeComponent();
        }

        private void btnExtraerTexto_Click(object sender, EventArgs e)
        {
            try
            {
                var ocr = new IronTesseract();

                using (var inputImage = new OcrInput(txtImagePath.Text))
                {
                    var result = ocr.Read(inputImage);

                    if (result != null && !string.IsNullOrEmpty(result.Text))
                    {
                        txtExtraerTexto.Text = result.Text;
                    }
                    else
                    {
                        MessageBox.Show("El reconocimiento de texto ha fallado o no se encontró ningún texto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}