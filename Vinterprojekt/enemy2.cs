using Raylib_cs;
using System.Numerics;

//arv

public class Enemy2 : Enemy
{
    Rectangle enemy = new Rectangle(1500, 500, 50, 50);
    public void DrawEn2()
    {
        Raylib.DrawRectangleRec(enemy, Color.GREEN);
    }

    public void EnMove()
    {
        float enemyspeed = 3f;
        Vector2 enemyPos = new Vector2(enemy.X, enemy.Y);
        enemyPos.X += enemyspeed;
    }
}