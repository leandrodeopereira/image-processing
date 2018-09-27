using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void ReloadImage()
        {
            Bitmap image = OptionsForm.PicResult;
            ResizeWindow(image.Width, image.Height);
            this.picResult.Image = image;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            ReloadImage();
        }

        private void ResizeWindow(int width, int height)
        {
            this.Width = width + 10;
            this.Height = height + 10;
            this.picResult.Width = width;
            this.picResult.Height = height;
        }
    }
}
