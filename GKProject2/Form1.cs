using GKProject2.Properties;
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
using System.Timers;
using System.Windows.Forms;

namespace GKProject2
{
    public partial class Form1 : Form
    {
        // DrawingArea.Width > N, DrawingArea.Height > M;
        public int WIDTH = 1000, HEIGHT = 500;
        public int N = 5, M = 5 ;
        public float dx, dy;
        const int DISTANCE = 4;
        public PointF[,] Verticles;
        public List<(int idx1, int idx2)> NonRegularPoints;
        public DirectBitmap myDirectBitmap;
        public MyVector[] trace;
        public int iterator = 0;

        public PointF currentPoint = new PointF(-100, -100);

        public Form1()
        {
            InitializeComponent();
            GenerateMyBubbleMesh();
        }
        private void ResetApp()
        {
            myDirectBitmap = new DirectBitmap(DrawingArea.Width, DrawingArea.Height);
            ResetFillingAndLightAndNVector();
            ConstructPoints();
            RedrawBitmap();
            trace=ConstructTrace();
        }

        public MyVector[] ConstructTrace()
        {
            iterator = 0;
            float r = 100;
            MyVector[] ret = new MyVector[200];
            for (int i=0; i<ret.Length; i++)
            {
                ret[i] = new MyVector(r * (float)Math.Cos(r/10) + WIDTH/2 , r * (float)Math.Sin(r/10)+HEIGHT/2 , r );
                r+=2;
            }
            return ret;
        }

        private void RedrawBitmap()
        {
            ClearBitmap();     
            FillAllTriangles();
            DrawingArea.Image = new Bitmap(myDirectBitmap.Bitmap);
            DrawMesh();
        }

        private void ClearBitmap()
        {
            myDirectBitmap.Dispose();
            myDirectBitmap = new DirectBitmap(DrawingArea.Width, DrawingArea.Height);
        }

        private void ConstructPoints()
        {
            dx = (WIDTH - 2) / (float)N;
            dy = (HEIGHT - 2) / (float)M;
            NonRegularPoints = new List<(int idx1, int idx2)>();

            Verticles = new PointF[N + 1, M + 1];
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    Verticles[i, j] = new PointF(dx * i + 1, dy * j + 1);
                }
            }
        }
        private void DrawMesh()
        {
            if (!MeshVisibleCheckBox.Checked) return;
            Graphics g = Graphics.FromImage(DrawingArea.Image);
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    DrawPoint(Verticles[i, j],g);
                    if (i > 0 && j < M) DrawLine(Verticles[i, j], Verticles[i - 1, j + 1],g);
                    if (j < M) DrawLine(Verticles[i, j], Verticles[i, j + 1],g);
                    if (i < N) DrawLine(Verticles[i, j], Verticles[i + 1, j],g);
                }
            }
            if (CurrentPaintedObject.idx1 >= 0 && CurrentPaintedObject.idx2 >= 0)
                DrawHoveredPoint(Verticles[CurrentPaintedObject.idx1, CurrentPaintedObject.idx2],g);
        }
        private void FillAllTriangles()
        {
            ///////////////////////////////////////
            ////WERSJA 1
            //Parallel.For(0,2 * N * M, i =>
            //{
            //    int ii = i / N;
            //    int jj = i % M;
            //    if (i<N*M)
            //    FillPolygonWithVerticlesSorting(Verticles[ii, jj], Verticles[ii + 1, jj], Verticles[ii, jj + 1]);
            //    else
            //    FillPolygonWithVerticlesSorting(Verticles[ii + 1 - N, jj], Verticles[ii - N, jj + 1], Verticles[ii + 1 - N, jj + 1]);
            //});
            ////////////////////////////////////////////
            /////WERSJA 2
            Parallel.For(0, N * 2, i =>
              {
                  for (int j = 0; j < M; j++)
                  {
                      if (i < N)
                          FillPolygonWithVerticlesSorting(Verticles[i, j], Verticles[i + 1, j], Verticles[i, j + 1]);
                      else
                          FillPolygonWithVerticlesSorting(Verticles[i + 1 - N, j], Verticles[i - N, j + 1], Verticles[i + 1 - N, j + 1]);
                  }
              });
        }
        private void MeshNewButton_Click(object sender, EventArgs e)
        {
            N = (int)MeshN.Value;
            M = (int)MeshM.Value;          
            ConstructPoints();
            RedrawBitmap();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LightLocationAnimatedRadioButtton.Checked)
            {
                LightLocation = trace[iterator++ % 100];
                RedrawBitmap();
            }
        }
        private void restartApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetApp();
        }
        private void RedrawBitmapHandler(object sender, EventArgs e)
        {
            RedrawBitmap();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetApp();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }




        //COLORING
        Color meshColor = Color.White;
        public void DrawPoint(PointF p, Graphics g)
        {
            PointF newPoint = new PointF(p.X - 1, p.Y - 1);
            Pen pen = new Pen(meshColor, 5);
            g.DrawEllipse(pen, new RectangleF(newPoint, new Size(2, 2)));
        }

        public void DrawHoveredPoint(PointF p, Graphics g)
        {
            PointF newPoint = new PointF(p.X - 8, p.Y - 8);
            Pen pen = new Pen(Color.Orange, 5);
            g.DrawEllipse(pen, new RectangleF(newPoint, new Size(16, 16)));
        }

        public void DrawLine(PointF p1, PointF p2, Color c, Graphics g)
        {
            Pen pen = new Pen(c, 1);
            g.DrawLine(pen, p1, p2);
        }

        public void DrawLine(PointF p1, PointF p2, Graphics g)
        {
            Pen pen = new Pen(meshColor, 1);
            g.DrawLine(pen, p1, p2);
        }
    }
}
