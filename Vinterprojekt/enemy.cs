using Raylib_cs;
using System.Numerics;

//Enemy Class
public class Enemy
{

    float enemyspeed = 3f;
    Rectangle enemy = new Rectangle(1000, 500, 50, 50);
    public void DrawEn()
    {
        Raylib.DrawRectangleRec(enemy, Color.RED);
    }


}