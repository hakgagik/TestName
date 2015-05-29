using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace TestName
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            GameMode game = new GameMode();
            game.Run();
        }
    }
}