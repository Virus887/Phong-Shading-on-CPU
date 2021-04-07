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
        public MyVector IL = new MyVector(1, 1, 1);
        public MyVector V = new MyVector(0, 0, 1);
        public MyVector LightLocation;


        //CZĘŚĆ LABOWA
        public int BUBBLE_RADIUS = 100;
        public MyVector[,] MyBubbleMesh;

        private void GenerateMyBubbleMesh()
        {
            MyBubbleMesh = new MyVector[BUBBLE_RADIUS * 2, BUBBLE_RADIUS * 2];
            float dx, dy, z;
            for (int x=0; x<BUBBLE_RADIUS*2; x++)
            {
                for(int y=0; y<BUBBLE_RADIUS*2; y++)
                {
                    dx = BUBBLE_RADIUS - x;
                    dy = BUBBLE_RADIUS - y;
                    z = (float)Math.Sqrt(BUBBLE_RADIUS * BUBBLE_RADIUS - dx * dx - dy * dy);
                    MyBubbleMesh[x,y] = MyVector.NormalizeVector(dx, dy, z);
                }
            }
        }
        private void ChangeBubbleSizeButton_Click(object sender, EventArgs e)
        {
            BUBBLE_RADIUS = (int)BubbleSizeNumeric.Value;
            GenerateMyBubbleMesh();
        }
        private Color GetRealColorOfPoint(int x, int y)
        {
            MyVector I;

            //kolor obiektu
            //
            MyVector IO;
            if (FillColorRadioButton.Checked) IO = new MyVector(currentColor);
            else IO = new MyVector(GetPixelFromTexture(x, y, currentTexture));
            //
            //kolor światła
            //
            MyVector tmpIL;
            if (LightColorCustomRadioButton.Checked) tmpIL = IL;
            else tmpIL = new MyVector(1, 1, 1);
            //
            //wektor do światła
            //
            MyVector L;
            if (LightLocationDefaultRadioButton.Checked) // Default
            {
                L = new MyVector(0, 0, 1);
            }
            else if (LightLocationCenterRadioButtton.Checked) //Center
            {
                L = MyVector.NormalizeVector(x - WIDTH / 2, y - HEIGHT / 2, 300);
            }
            else // Animation
            {
                L = MyVector.NormalizeVector(x - LightLocation.x, y - LightLocation.y, LightLocation.z);
            }
            //
            //wektor normalny
            //
            MyVector N;
            if (!BubbleCheckbox.Checked)
            {
                if (NVectorConstantRadioButton.Checked) N = new MyVector(0, 0, 1);
                else N = GetNVectorFromMap(x, y, currentNormalMap);
            }
            else
            {
                if (Distance(currentPoint, new PointF(x,y)) < BUBBLE_RADIUS) //generujemy wektor normalny dla bąbelka
                {
                    N = MyBubbleMesh[(int)(x - currentPoint.X + BUBBLE_RADIUS), (int)(y - currentPoint.Y + BUBBLE_RADIUS)];
                }
                else 
                {
                    if (NVectorConstantRadioButton.Checked) N = new MyVector(0, 0, 1);
                    else N = GetNVectorFromMap(x, y, currentNormalMap);
                }
            }
            //

            MyVector R = 2 * MyVector.ScalarProduct(N, L) * N - L;

            I = kd * tmpIL * IO * MyVector.ScalarProduct(N, L) + ks * tmpIL * IO * (float)Math.Pow(MyVector.ScalarProduct(V, R), m);

            I.PrepareToDraw();

            return Color.FromArgb((byte)(I.x * 255), (byte)(I.y * 255), (byte)(I.z * 255));
        }


        //KONIEC CZĘŚCI LABOWEJ

        private void DrawColorLine(PointF p1, PointF p2)
        {
            int scanLine = (int)(p1.Y);
            for (int j = (int)p1.X; j <= p2.X; j++)
            {
                myDirectBitmap.SetPixel(j, scanLine, GetRealColorOfPoint(j, scanLine));
            }
        }
        private void DrawInterpolatedColorLine(PointF p1, PointF p2, PointF[] points, MyVector[] colors, float polygonArea)
        {
            int scanLine = (int)(p1.Y);
            for (int j = (int)p1.X; j <= p2.X; j++)
            {
                MyVector v = new MyVector();
                for (int i = 0; i < points.Length; i++)
                {
                    v += colors[i] * (PolygonArea(points[(i + 1) % points.Length], points[(i + 2) % points.Length], new PointF(j, scanLine)) / polygonArea);
                }
                myDirectBitmap.SetPixel(j, scanLine, v.ToColor());
            }
        }
        private float PolygonArea(params PointF[] points)
        {
            double area = 0.0;
            int n = points.Length;
            int j = n - 1;
            for (int i = 0; i < n; i++)
            {
                area += (points[j].X + points[i].X) * (points[j].Y - points[i].Y);
                j = i;
            }
            return (float)Math.Abs(area / 2.0);
        }
        private float Distance(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}
