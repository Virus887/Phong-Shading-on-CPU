using GKProject2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKProject2
{
    public partial class Form1 : Form
    {
        public Color currentColor = Color.Brown;
        public Color currentLightColor = Color.White;
        public DirectBitmap currentTexture;
        public DirectBitmap currentNormalMap;

        private void ResetFillingAndLightAndNVector()
        {
            //Color fill
            FillColorPictureBox.BackColor = currentColor;

            //Texture fill
            FillTexturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            currentTexture = new DirectBitmap(Resources.Texture);
            FillTexturePictureBox.Image = currentTexture.Bitmap;


            //Light color
            LightColorPictureBox.BackColor = currentLightColor;

            //N Vector
            NVectorNormalMapPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            currentNormalMap = new DirectBitmap(Resources.NormalMap);
            NVectorNormalMapPictureBox.Image = currentNormalMap.Bitmap;
        }

        private void FillColorPictureBox_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = FillColorPictureBox.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = MyDialog.Color;
                FillColorPictureBox.BackColor = MyDialog.Color;
                if(FillColorRadioButton.Checked) RedrawBitmap();
            }
        }

        private void FillTexturePictureBox_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = path.Substring(6);
            dlg.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|All Files (*.*)|*.*";
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFileName = dlg.FileName;
                FillTexturePictureBox.Image = new Bitmap(dlg.FileName);
                currentTexture = new DirectBitmap(FillTexturePictureBox.Image);
                if(FillTextureRadioButton.Checked)RedrawBitmap();
            }
        }

        private void NVectorNormalMapPictureBox_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = path.Substring(6);
            dlg.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFileName = dlg.FileName;
                NVectorNormalMapPictureBox.Image = new Bitmap(dlg.FileName);
                currentNormalMap = new DirectBitmap(NVectorNormalMapPictureBox.Image);
                if (NVectorNormalMapRadioButton.Checked) RedrawBitmap();
            }
        }
        private void LightColorPictureBox_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = FillColorPictureBox.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                currentLightColor = MyDialog.Color;
                LightColorPictureBox.BackColor = MyDialog.Color;
                IL = new MyVector(currentLightColor);
                if (LightColorCustomRadioButton.Checked) RedrawBitmap();
            }
        }

        private Color GetPixelFromTexture(int x, int y, DirectBitmap currentTexture)
        {
            int X = (int)(x / (float)WIDTH * currentTexture.Width) % currentTexture.Width;
            int Y = (int)(y / (float)HEIGHT * currentTexture.Height) % currentTexture.Height;
            return currentTexture.GetPixel(X, Y);
        }


        private MyVector GetNVectorFromMap(int x, int y, DirectBitmap currentNormalMap)
        {
            int X = (int)(x / (float)WIDTH * currentNormalMap.Width) % currentNormalMap.Width;
            int Y = (int)(y / (float)HEIGHT * currentNormalMap.Height) % currentNormalMap.Height;
            return new MyVector
                (currentNormalMap.GetPixel(X, Y).R/127.5f - 1.0f,
                 currentNormalMap.GetPixel(X, Y).G/127.5f - 1.0f,
                 currentNormalMap.GetPixel(X, Y).B/255f);
        }

    }
}
