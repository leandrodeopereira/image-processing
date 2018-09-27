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
    public partial class HistogramForm : Form
    {
        public HistogramForm()
        {
            InitializeComponent();
        }

        internal void ReloadHistogram()
        {
            IList<HistogramInfo> histogramInfos = OptionsForm.HistogramInfos;
            foreach (HistogramInfo hist in histogramInfos) {
                this.chartHistogram.Series["Bytes"].Points.AddXY(hist.Value,hist.Total);
            }
            
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            ReloadHistogram();
        }
    }
}
