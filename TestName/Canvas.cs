using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace TestName
{
    class Canvas
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        private float[] circleX;
        private float[] circleY;
        private int circleEdges = 32;

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
            circleX = new float[circleEdges + 1];
            circleY = new float[circleEdges + 1];
            for (int i = 0; i <= circleEdges; i++)
            {
                circleX[i] = (float)Math.Cos((float)i / circleEdges * 2.0f * Math.PI);
                circleY[i] = (float)Math.Sin((float)i / circleEdges * 2.0f * Math.PI);
            }
        }


        public void DrawBackground()
        {
            
        }

        public void DrawCircle(float x, float y, float r, Color color)
        {
            GL.Color3(color);
            GL.Begin(PrimitiveType.Polygon);
            for (int i = 0; i <= circleEdges; i++)
            {
                GL.Vertex2(circleX[i] * r + x, circleY[i] * r + y);
            }
            GL.End();
        }

        public void DrawSqaure(float x, float y, float s, Color color)
        {
            s /= 2.0f;
            GL.Color3(color);
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2( s + x,  s + y);
            GL.Vertex2(-s + x,  s + y);
            GL.Vertex2(-s + x, -s + y);
            GL.Vertex2( s + x, -s + y);
            GL.End();
        }

        public void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
