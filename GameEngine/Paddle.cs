using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class Paddle
  {

    static List<Paddle> paddles = new List<Paddle>();

    public float x;
    public float y;

    public KeyboardKey upKey;
    public KeyboardKey downKey;

    public Paddle(float xStart, float yStart, KeyboardKey up, KeyboardKey down)
    {
      x = xStart;
      y = yStart;
      upKey = up;
      downKey = down;

      paddles.Add(this);
    }

    public void Update()
    {
      if (Raylib.IsKeyDown(upKey))
      {
        y -= 4f;
      }
      if (Raylib.IsKeyDown(downKey))
      {
        y += 4f;
      }
    }

    public static void UpdateAll()
    {
      foreach (Paddle p in paddles)
      {
        p.Update();
      }
    }

    public void Draw()
    {
      Raylib.DrawRectangle((int)x, (int)y, 20, 50, Color.BLACK);
    }

    public static void DrawAll()
    {
      foreach (Paddle p in paddles)
      {
        p.Draw();
      }
    }
  }
}
