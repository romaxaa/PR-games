using SadConsole;
using SadConsole.Configuration;
using SpaceShooter;

class Program
{
    static void Main()
    {
        // Настройка окна и запуск игры
        Settings.WindowTitle = "Space Shooter";
        Game.Create(40, 25, Startup);
        Game.Instance.Run();
        Game.Instance.Dispose();
    }

    private static void Startup(object sender, GameHost host)
    {
        var gameScreen = new GameScreen();
        Game.Instance.Screen = gameScreen;
        Game.Instance.Screen.IsFocused = true;
    }
}