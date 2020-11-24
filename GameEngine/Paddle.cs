using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class Paddle: GameObject
  {

    // public static List<Paddle> paddles = new List<Paddle>();

    // public float x;
    // public float y;
    // public Rectangle rectangle;

    public KeyboardKey upKey;
    public KeyboardKey downKey;

    public Paddle(float xStart, float yStart, KeyboardKey up, KeyboardKey down)
    {
      rectangle = new Rectangle(xStart, yStart, 20, 50);
      // x = xStart;
      // y = yStart;
      upKey = up;
      downKey = down;

      gameObjects.Add(this);
    }

    public override void Update()
    {
      if (Raylib.IsKeyDown(upKey))
      {
        rectangle.y -= 4f;
      }
      if (Raylib.IsKeyDown(downKey))
      {
        rectangle.y += 4f;
      }
    }

    // public static void UpdateAll()
    // {
    //   foreach (Paddle p in gameObjects)
    //   {
    //     p.Update();
    //   }
    // }

    // public void Draw()
    // {
    //   Raylib.DrawRectangleRec(rectangle, Color.BLACK);
    // }

    // public static void DrawAll()
    // {
    //   foreach (Paddle p in gameObjects)
    //   {
    //     p.Draw();
    //   }
    // }
  }
}
