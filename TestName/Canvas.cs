using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestName
{
    class Canvas
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
        }


        public void DrawBackground()
        {
            
        }

        public void DrawCircle(float x, float y, float r)
        {
            
        }

        public void DrawSqaure(float x, float y, float s)
        {
            
        }

        public void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
