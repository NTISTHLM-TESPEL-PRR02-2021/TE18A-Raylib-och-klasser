using System;
using System.Numerics;
using Raylib_cs;

namespace GameEngine
{
  public class Ball
  {
    public Rectangle rectangle;
    public Vector2 speed = new Vector2(2,2);

    public Ball()
    {
      rectangle = new Rectangle(800 / 2 - 10, 600 / 2 - 10, 20, 20);
    }

    public void Update()
    {
      rectangle.x += speed.X;
      rectangle.y += speed.Y;

      if (rectangle.x > 800 - 20 || rectangle.x < 0)
      {
        speed.X = -speed.X;
      }
      if (rectangle.y > 600 - 20 || rectangle.y < 0)
      {
        speed.Y = -speed.Y;
      }

      foreach (Paddle p in Paddle.paddles)
      {
        if (Raylib.CheckCollisionRecs(rectangle, p.rectangle))
        {
          speed.X = -speed.X;
        }
      }
    

    }

    public void Draw()
    {
      Raylib.DrawRectangleRec(rectangle, Color.BLACK);
    }
  }
}
