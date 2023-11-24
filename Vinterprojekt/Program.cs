using Raylib_cs;
using System.Numerics;

Raylib.SetConfigFlags(ConfigFlags.FLAG_VSYNC_HINT);

Raylib.SetTargetFPS(60);

Raylib.InitWindow(1920, 1080, "Vinterprojekt");

Player playa = new Player();

while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();


    Raylib.ClearBackground(Color.LIGHTGRAY);

    playa.Draw();


    Raylib.EndDrawing();
}