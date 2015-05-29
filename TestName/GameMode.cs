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
        private Tower_Controller towerController;
        
        // Main minionController
        private MinionController minionController;

        // Main canvas object. This is currently the game's only main View.
        private Canvas canvas;

        // Current state of the game
        private GameState state;

        // Aspect ratio (height / width)
        private float aspectRatio;

        Vector2 squarePosition = Vector2.Zero;

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
            state = GameState.Intro;
            WindowState = WindowState.Fullscreen;
            WindowBorder = WindowBorder.Hidden;
            gameplayController = new GameplayController();
            minionController = new MinionController();
            towerController = new Tower_Controller();
            environment = new Environment();
            canvas = new Canvas(Width, Height);
        }

        private void OnResize(object e, EventArgs sender)
        {
            GL.Viewport(0, 0, Width, Height);
            canvas.Resize(Width, Height);
            aspectRatio = (float) Height / Width;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            if (aspectRatio > 1) GL.Ortho(-1, 1, -aspectRatio, aspectRatio, 0, 4);
            else GL.Ortho(-1 / aspectRatio, 1 / aspectRatio, -1, 1, 0, 4);
        }

        private void OnUpdateFrame(object e, EventArgs sender)
        {
            if (Keyboard[Key.Escape])
            {
                Exit();
            }

            if (Keyboard[Key.Left])
            {
                squarePosition.X -= 0.01f;
            }
            if (Keyboard[Key.Right])
            {
                squarePosition.X += 0.01f;
            }
            if (Keyboard[Key.Down])
            {
                squarePosition.Y -= 0.01f;
            }
            if (Keyboard[Key.Up])
            {
                squarePosition.Y += 0.01f;
            }

            // TODO: All game logic goes here
            switch (state)
            {
                case GameState.Intro:
                    // TODO: initialization code here
                    break;
                case GameState.Play:
                    towerController.update();
                    // minionController.update();
                    gameplayController.Update();
                    break;
                case GameState.GameOver:
                    break;
            }
        }

        private void OnRenderFrame(object e, EventArgs sender)
        {
            // TODO: All drawing code goes here
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            switch (state)
            {
                case GameState.Intro:
                    GL.ClearColor(Color.Black);
                    state = GameState.Play;
                    break;
                case GameState.Play:
                    environment.Draw(canvas);
                    towerController.draw();
                    minionController.draw();
                    break;
                case GameState.GameOver:
                    break;
            }
            SwapBuffers();
        }

        public enum GameState
        {
            Intro,
            Play,
            GameOver
        }
    }
}
