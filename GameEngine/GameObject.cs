using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class GameObject
  {
    public Rectangle rectangle;

    public static List<GameObject> gameObjects = new List<GameObject>();

    public virtual void Update()
    {

    }

    public static void UpdateAll()
    {
      foreach (GameObject g in gameObjects)
      {
        g.Update();
      }
    }

    public virtual void Draw()
    {
      Raylib.DrawRectangleRec(rectangle, Color.BLACK);
    }

    public static void DrawAll()
    {
      foreach (GameObject g in gameObjects)
      {
        g.Draw();
      }
    }

  }
}
