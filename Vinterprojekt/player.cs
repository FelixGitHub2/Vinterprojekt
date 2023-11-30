using Raylib_cs;
using System.Numerics;


public class Player
{
    float speed = 5f;
    Rectangle player = new Rectangle(1000, 1000, 50, 50);

    
    public void Draw()
    {
        Raylib.DrawRectangleRec(player, Color.BLACK);
    }

    public void Movement()
    {
        Vector2 playerPos = new Vector2(player.X, player.Y);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            player.Y += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            player.Y -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            player.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            player.X -= speed;
    }



}