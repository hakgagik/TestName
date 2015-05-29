using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace TestName
{
    class GameMode : GameWindow
    {
        // Main gameplayController
        private GameplayController gameplayController;

        // Main environment
        private Environment environment;

        // Main towerController
        
        // Main minionController

        // Main canvas object. This is currently the game's only main View.
        private Canvas canvas;

        public GameMode() : base()
        {
            Load += OnLoad;
            Resize += OnResize;
            UpdateFrame += OnUpdateFrame;
            RenderFrame += OnRenderFrame;
        }

        public GameMode(int length, int width) : base(length, width)
        {
            Load += OnLoad;
            Resize += OnResize;
            UpdateFrame += OnUpdateFrame;
            RenderFrame += OnRenderFrame;
        }

        private void OnLoad(object e, EventArgs sender)
        {
            VSync = VSyncMode.On;
            // TODO: Loading code here
            gameplayController = new GameplayController();
        }

        private void OnResize(object e, EventArgs sender)
        {
            GL.Viewport(0, 0, Width, Height);
            canvas.Resize(Width, Height);
        }

        private void OnUpdateFrame(object e, EventArgs sender)
        {
            if (Keyboard[Key.Escape])
            {
                Exit();
            }

            // TODO: All game logic goes here
            gameplayController.Update();
        }

        private void OnRenderFrame(object e, EventArgs sender)
        {
            // TODO: All drawing code goes here

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            environment.Draw(canvas);



            SwapBuffers();
        }
    }
}
