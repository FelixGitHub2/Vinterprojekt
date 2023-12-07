using Raylib_cs;
using System.Numerics;

public class Enemy
{

    float enemyspeed = 3f;
    Rectangle enemy = new Rectangle(1000, 500, 50, 50);
    public void DrawEn()
    {
        Raylib.DrawRectangleRec(enemy, Color.RED);
    }

    public void EnMove()
    {
        Vector2 enemyPos = new Vector2(enemy.X, enemy.Y);
    }
}