using System;
using System.CodeDom;
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
    public struct MyVector
    {
        public float x;
        public float y;
        public float z;

        public MyVector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public MyVector(Color c)
        {
            this.x = c.R/255.0f;
            this.y = c.G/255.0f;
            this.z = c.B/255.0f;
        }

        public static float ScalarProduct(MyVector v1, MyVector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public Color ToColor()
        {
            return Color.FromArgb((byte)(x * 255), (byte)(y * 255), (byte)(z * 255));
        }

        public static MyVector NormalizeVector(float x, float y, float z)
        {
            float length = (float)Math.Sqrt(x *x + y * y + z *z);
            return new MyVector(x / length, y / length, z / length);
        }

        public void PrepareToDraw()
        {
            if (x > 1) x = 1;
            if (x < 0) x = 0;
            if (y > 1) y = 1;
            if (y < 0) y = 0;
            if (z > 1) z = 1;
            if (z < 0) z = 0;
        }

        public static MyVector operator +(MyVector v1, MyVector v2) => new MyVector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        public static MyVector operator -(MyVector v1, MyVector v2) => new MyVector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        public static MyVector operator *(MyVector v1, MyVector v2) => new MyVector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        public static MyVector operator *(MyVector v1, float x) => new MyVector(v1.x * x, v1.y * x, v1.z * x);
        public static MyVector operator *(float x, MyVector v1) => new MyVector(v1.x * x, v1.y * x, v1.z * x);
        public static MyVector operator *(MyVector v1, int x) => new MyVector(v1.x * x, v1.y * x, v1.z * x);
        public static MyVector operator /(MyVector v1, int x) => new MyVector(v1.x / x, v1.y / x, v1.z / x);
        public static MyVector operator *(int x, MyVector v1) => new MyVector(v1.x * x, v1.y * x, v1.z * x);
    }
}
