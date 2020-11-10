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

      Paddle leftPaddle = new Paddle(10, 275, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
      Paddle rightPaddle = new Paddle(770, 275, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);

      while (!Raylib.WindowShouldClose())
      {
        Paddle.UpdateAll();

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.GOLD);

        Paddle.DrawAll();

        Raylib.EndDrawing();
      }
    }
  }
}
