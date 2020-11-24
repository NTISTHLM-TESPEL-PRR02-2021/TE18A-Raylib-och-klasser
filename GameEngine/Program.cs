using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Game engine");
      Raylib.SetTargetFPS(60);

      GameObject leftPaddle = new Paddle(10, 275, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
      GameObject rightPaddle = new Paddle(770, 275, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);

      Ball ball = new Ball();

      while (!Raylib.WindowShouldClose())
      {
        GameObject.UpdateAll();
        // ball.Update();


        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.GOLD);

        // if (Raylib.CheckCollisionRecs(ballRect, ball2Rect))
        // {
        //   Raylib.DrawText("JA", 10, 500, 64, Color.BLACK);
        // }
        // else
        // {
        //   Raylib.DrawText("NEJ", 10, 500, 64, Color.BLACK);
        // }

        GameObject.DrawAll();

        Raylib.EndDrawing();
      }
    }
  }
}
