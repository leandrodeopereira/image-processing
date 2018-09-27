using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        public static OriginalForm OriginalForm { get; set; }
        public static ResultForm ResultForm { get; set; }
        public static HistogramForm HistogramForm { get; set; }
        public static Bitmap PicOriginal { get; set; }
        public static Bitmap PicResult { get; set; }

        public static IList<HistogramInfo> HistogramInfos { get; set; }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.bmp, *.jpg)|*.bmp; *.jpg";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                PicOriginal = new Bitmap(openFile.FileName);
                if (OriginalForm == null || OriginalForm.Visible == false)
                {
                    OriginalForm = new OriginalForm();
                    OriginalForm.Show();
                }
                else
                    OriginalForm.ReloadImage();
            }

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
            {
                Bitmap copy = new Bitmap(PicOriginal);
                Processing.ConvertToGray(copy);
                PicResult = copy;
                if (ResultForm == null || ResultForm.Visible == false)
                {
                    ResultForm = new ResultForm();
                    ResultForm.Show();
                }
                else
                    OriginalForm.ReloadImage();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ResultForm != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image File (*.jpg)|*.jpg";
                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    PicResult.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void btnVerMirroring_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
            {
                Bitmap copy = new Bitmap(PicOriginal);
                Processing.VerticallMirroring(copy);
                PicResult = copy;
                if (ResultForm == null || ResultForm.Visible == false)
                {
                    ResultForm = new ResultForm();
                    ResultForm.Show();
                }
                else
                    ResultForm.ReloadImage();
            }
        }

        private void btnHorMirroring_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
            {
                Bitmap copy = new Bitmap(PicOriginal);
                Processing.HorizontalMirroring(copy);
                PicResult = copy;
                if (ResultForm == null || ResultForm.Visible == false)
                {
                    ResultForm = new ResultForm();
                    ResultForm.Show();
                }
                else
                    ResultForm.ReloadImage();
            }
        }

        private void btnQuantize_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
            {
                Bitmap copy = new Bitmap(PicOriginal);
                Processing.Quantize(copy, (int)this.numberQuantize.Value);
                PicResult = copy;
                if (ResultForm == null || ResultForm.Visible == false)
                {
                    ResultForm = new ResultForm();
                    ResultForm.Show();
                }
                else
                    ResultForm.ReloadImage();
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
            {
                if(PicResult != null)
                {
                    Bitmap copy = new Bitmap(PicResult);
                    if (!Processing.isGrayScale(copy))
                    {
                        Processing.ConvertToGray(copy);
                        PicResult = copy;
                        ResultForm.ReloadImage();
                    }
                    HistogramInfos = Processing.CreateHistogramInfo(copy);
                    if (HistogramForm == null || HistogramForm.Visible == false)
                    {
                        HistogramForm = new HistogramForm();
                        HistogramForm.Show();
                    }
                    else
                        HistogramForm.ReloadHistogram();
                }
            }
        }
    }
}
