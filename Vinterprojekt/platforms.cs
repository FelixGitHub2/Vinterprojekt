using Raylib_cs;
using System.Numerics;

public class Platforms
{
    List<Rectangle> walls = new List<Rectangle>();


    public void wall()
    {
        walls.Add(new Rectangle(300, -20, 2000, 50));
        walls.Add(new Rectangle(0, 1050, 1700, 50));


        foreach (Rectangle wall in walls)
        {
            Raylib.DrawRectangleRec(wall, Color.BLACK);
        }
    }
}