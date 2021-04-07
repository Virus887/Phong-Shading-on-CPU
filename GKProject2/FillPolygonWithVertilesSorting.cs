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
        public class AETNode
        {
            public int ymax;
            public float x;
            public float m;

            public AETNode(PointF p1, PointF p2)
            {
                float x1 = p1.X;
                float x2 = p2.X;
                float y1 = p1.Y;
                float y2 = p2.Y;

                if (y1 > y2)
                {
                    ymax = (int)y1;
                    x = x2;
                    m = (x1 - x2) / (y2-y1);

                }
                else if (y1<y2)
                {
                    ymax = (int)y2;
                    x = x1;
                    m = (x2 - x1) / (y2 - y1);
                }
                else
                {
                    ymax = (int)y1;
                    x = x1;
                    m = 0;
                }
            }

            public void UpdateNode()
            {
                x += m;
            }
            public bool ChcekNode(int y)
            {
                if (y >= ymax)  //ceil
                {
                    return false;
                }
                return true;
            }

        }

        private void FillPolygonWithVerticlesSorting(params PointF[] points)
        {
            MyVector[] colors = null;
            float polygonArea = 0;
            if(FillModeInterpolateRadioButton.Checked)
            {
                colors = new MyVector[points.Length];
                for (int i=0; i<colors.Length; i++) colors[i] = new MyVector(GetRealColorOfPoint((int)points[i].X, (int)points[i].Y));
                polygonArea = PolygonArea(points);
            }    

            List<AETNode>AET = new List<AETNode>();
            int[] indexes = GetIndexesOfSortedPoints(points);
            int ymin = (int)points[indexes[0]].Y;
            int iter = 0;

            for (int scanLine = ymin; scanLine < DrawingArea.Height; scanLine++)
            {
                //Add new nodes
                while (Math.Abs(scanLine - points[indexes[iter]].Y) < 1 )
                {
                    int idxcurr = indexes[iter];
                    int idxnext = (indexes[iter] + 1 ) % points.Length;
                    int idxprev = (indexes[iter] - 1 + points.Length) % points.Length;
     
                    if (points[idxprev].Y >= scanLine) AET.Add(new AETNode(points[idxcurr], points[idxprev]));
                    if (points[idxnext].Y >= scanLine) AET.Add(new AETNode(points[idxcurr], points[idxnext]));
                    AET.Sort((n1, n2) => n1.x.CompareTo(n2.x));
                    if (++iter == points.Length) return;
                }
                //Sort nodes
                AET.Sort((n1, n2) => n1.x.CompareTo(n2.x));

                //RemoveNodes
                for (int i = AET.Count - 1; i >= 0; i--)
                {
                    if (AET[i].ChcekNode(scanLine) == false)
                    {
                        AET.RemoveAt(i);
                    }
                }

                //Draw scanline
                DrawAET(scanLine, AET, points, colors, polygonArea);


                //Update nodes
                for (int i = AET.Count - 1; i >= 0; i--) AET[i].UpdateNode();

            }
        }

        private void DrawAET(int scanLine, List<AETNode> list,PointF[] points, MyVector[] colors, float polygonArea)
        {
            for (int i = 0; i < list.Count; i += 2)
            {
                if (i + 1 >= list.Count) return;
                PointF newp1 = new PointF((float)list[i].x, scanLine);
                PointF newp2 = new PointF((float)list[i + 1].x, scanLine);
                if (FillModeAccurateRadioButton.Checked) DrawColorLine(newp1, newp2);
                else DrawInterpolatedColorLine(newp1, newp2, points, colors, polygonArea);
            }
            return;
        }

        private int[] GetIndexesOfSortedPoints(PointF[] points)
        {
            int n = points.Length;
            int[] indexes = new int[n];
            for (int i = 0; i < n; i++) indexes[i] = i;
            Array.Sort(indexes, (i1, i2) => points[i1].Y.CompareTo(points[i2].Y));
            return indexes;
        }
    }
}

