using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  class Program
  {

    enum GameScreens {
      Start,
      Game,
      GameOver
    }

    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Game engine");
      Raylib.SetTargetFPS(60);

      GameObject leftPaddle = new Paddle(10, 275, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
      GameObject rightPaddle = new Paddle(770, 275, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);

      Ball ball = new Ball();

      GameScreens screen = GameScreens.Start;

      while (!Raylib.WindowShouldClose())
      {

        // LOGIK
        if (screen == GameScreens.Start)
        {
          if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
          {
            screen = GameScreens.Game;
          }
        }
        else if (screen == GameScreens.Game)
        {
          GameObject.UpdateAll();
        }

        
        // ball.Update();

        // GRAFIK
        Raylib.BeginDrawing();

        if (screen == GameScreens.Start)
        {
          Raylib.ClearBackground(Color.GRAY);
          Raylib.DrawText("Press ENTER to start", 10, 10, 64, Color.BLACK);
        }
        else if (screen == GameScreens.Game)
        {
          Raylib.ClearBackground(Color.GOLD);
          GameObject.DrawAll();

        }

        

        // if (Raylib.CheckCollisionRecs(ballRect, ball2Rect))
        // {
        //   Raylib.DrawText("JA", 10, 500, 64, Color.BLACK);
        // }
        // else
        // {
        //   Raylib.DrawText("NEJ", 10, 500, 64, Color.BLACK);
        // }

        

        Raylib.EndDrawing();
      }
    }
  }
}
