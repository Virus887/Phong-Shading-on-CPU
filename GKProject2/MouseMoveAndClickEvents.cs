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
        private (int idx1, int idx2) CurrentPaintedObject = (-1, -1);//FOR ORANGE POINTS
        private (int idx1, int idx2) CurrentMovingObject = (-1, -1);

        private void DrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            if (HandleAnimatingObject(e)) return; //move selected object

            bool found = false;
            int startrow = (int)(e.X / dx - 1);
            int startcol = (int)(e.Y / dy - 1);
            if (startrow < 1) startrow = 0;
            if (startcol < 1) startcol = 0;

            for (int i = startrow; i < startrow + 3; i++)
            {
                if (i > N) break;
                for (int j = startcol; j < startcol + 3; j++)
                {
                    if (j > M) break;
                    if (IsMouseNearPoint(e.Location, Verticles[i, j]))
                    {
                        CurrentPaintedObject = (i, j);
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                for (int i = 0; i < NonRegularPoints.Count; i++)
                {
                    if (IsMouseNearPoint(e.Location, Verticles[NonRegularPoints[i].idx1, NonRegularPoints[i].idx2]))
                    {
                        CurrentPaintedObject = (NonRegularPoints[i].idx1, NonRegularPoints[i].idx2);
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                bool flag = false;
                if (CurrentPaintedObject != (-1, -1)) flag = true;
                CurrentPaintedObject = (-1, -1);
                if (flag) RedrawBitmap();
            }

            RedrawBitmap();

        }
        private void DrawingArea_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button != MouseButtons.Left) return;
            if (!MeshVisibleCheckBox.Checked) return;

            bool found = false;
            int startrow = (int)(e.X / dx - 1);
            int startcol = (int)(e.Y / dy - 1);
            if (startrow < 1) startrow = 0;
            if (startcol < 1) startcol = 0;
            for (int i = startrow; i < startrow + 3; i++)
            {
                if (i > N) break;
                for (int j = startcol; j < startcol + 3; j++)
                {
                    if (j > M) break;
                    if (IsMouseNearPoint(e.Location, Verticles[i, j]))
                    {
                        found = true;
                        CurrentMovingObject = (i, j);
                        if (!NonRegularPoints.Contains((i, j))) NonRegularPoints.Add((i, j));
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                for (int i = 0; i < NonRegularPoints.Count; i++)
                {
                    if (IsMouseNearPoint(e.Location, Verticles[NonRegularPoints[i].idx1, NonRegularPoints[i].idx2]))
                    {
                        found = true;
                        CurrentMovingObject = (NonRegularPoints[i].idx1, NonRegularPoints[i].idx2);
                        if (!NonRegularPoints.Contains((NonRegularPoints[i].idx1, NonRegularPoints[i].idx2)))
                            NonRegularPoints.Add((NonRegularPoints[i].idx1, NonRegularPoints[i].idx2));
                        break;
                    }
                }
            }
        }
        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            CurrentMovingObject = (-1, -1);
        }
        private bool HandleAnimatingObject(MouseEventArgs e)
        {
            if (CurrentMovingObject == (-1, -1)) return false;
            if (e.X > 0 && e.Y > 0 && e.X < DrawingArea.Width && e.Y < DrawingArea.Height)
                Verticles[CurrentMovingObject.idx1, CurrentMovingObject.idx2] = e.Location;
            RedrawBitmap();
            return true;
        }
        private bool IsMouseNearPoint(PointF p1, PointF p2)
        {
            if (Math.Abs(p2.X - p1.X) <= DISTANCE && Math.Abs(p2.Y - p1.Y) <= DISTANCE) return true;
            return false;
        }
        private void DrawingArea_MouseLeave(object sender, EventArgs e)
        {
            CurrentMovingObject = (-1, -1);
            CurrentPaintedObject = (-1, -1);
            RedrawBitmap();
        }
    }
}
