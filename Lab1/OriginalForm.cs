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
    public partial class OriginalForm : Form
    {
        public OriginalForm()
        {
            InitializeComponent();
        }

        public void ReloadImage()
        {
            Bitmap image = OptionsForm.PicOriginal;
            ResizeWindow(image.Width, image.Height);
            this.picOriginal.Image = image;
        }

        private void OriginalForm_Load(object sender, EventArgs e)
        { 
            ReloadImage();
        }

        private void ResizeWindow(int width, int height) {
            this.Width = width + 10;
            this.Height = height + 10;
            this.picOriginal.Width = width;
            this.picOriginal.Height = height;
        }
    }
}
