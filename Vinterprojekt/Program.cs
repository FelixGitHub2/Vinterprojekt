using Raylib_cs;
using System.Numerics;

Raylib.SetConfigFlags(ConfigFlags.FLAG_VSYNC_HINT);

Raylib.SetTargetFPS(60);

Raylib.InitWindow(1920, 1080, "Vinterprojekt");

float speed = 5f;

//Klasser

Player playa = new Player();

Platforms plat = new Platforms();

Enemy enemy = new Enemy();

Enemy2 enemy2 = new Enemy2();

Render render = new Render();

Scenes currentScene = Scenes.menu;

//Main code
while (!Raylib.WindowShouldClose())
{


    Raylib.BeginDrawing();


    Raylib.ClearBackground(Color.LIGHTGRAY);

    if (currentScene == Scenes.menu)
    {
        render.menu();

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = Scenes.game;  
        }
    }

    // Class Metoder 

    if (currentScene == Scenes.game)
    {
        playa.Draw();

        playa.Movement();

        plat.wall();

        enemy.DrawEn();

        enemy2.DrawEn2();

        enemy2.EnMove();

    }



    Raylib.EndDrawing();



}


public enum Scenes
{
    menu, game
}