using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GKProject2
{
    public partial class Form1 : Form
    {
        public float ks=0.5f;
        public float kd=0.5f;
        public int m = 1;

        private void KdBar_ValueChanged(object sender, EventArgs e)
        {
            kd = KdBar.Value / 100.0f;
            KdLabel.Text = "kd = " + kd.ToString();
            KdLabel.Refresh();
            RedrawBitmap();
        }
        private void KsBar_ValueChanged(object sender, EventArgs e)
        {
            ks = KsBar.Value / 100.0f;
            KsLabel.Text = "ks = " + ks.ToString();
            KsLabel.Refresh();
            RedrawBitmap();
        }
        private void MBar_ValueChanged(object sender, EventArgs e)
        {
            m = MBar.Value;
            MLabel.Text = " m = " + m;
            MLabel.Refresh();
            RedrawBitmap();
        }
    }


}
