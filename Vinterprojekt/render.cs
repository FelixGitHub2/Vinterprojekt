using Raylib_cs;
using System.Numerics;

//Text render class
public class Render
{
    public void menu()
    {
        Raylib.DrawText("Menu", 800, 500, 100, Color.BLACK);
        Raylib.DrawText("Press Enter", 800, 700, 100, Color.BLACK);
    }



}