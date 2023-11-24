using Raylib_cs;
using System.Numerics;

public class Player
{


    Rectangle player = new Rectangle(1000, 1000, 50, 50);

    
    public void Draw()
    {
        Raylib.DrawRectangleRec(player, Color.BLACK);
    }

    public void Movement()
    {
        
    }



}