using Raylib_cs;
using System.Numerics;

Raylib.SetConfigFlags(ConfigFlags.FLAG_VSYNC_HINT);

Raylib.SetTargetFPS(60);

Raylib.InitWindow(1920, 1080, "Vinterprojekt");

float speed = 5f;

string currentScene = "game";

Player playa = new Player();

Platforms plat = new Platforms();

Enemy enemy = new Enemy();


while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();


    Raylib.ClearBackground(Color.LIGHTGRAY);

    playa.Draw();

    playa.Movement();

    plat.wall();

    enemy.DrawEn();

    Raylib.EndDrawing();
}