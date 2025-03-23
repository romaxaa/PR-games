using SadConsole;
using SadRogue.Primitives;

namespace SpaceShooter;

public class Player : ScreenSurface
{
    public Player() : base(1, 1)
    {
        Surface[0, 0].Glyph = '^'; // Символ корабля
        
        Surface[0, 0].Foreground = Color.Cyan;
    }

    public bool CheckCollision(ScreenSurface screenSurface)
    {
        for (int i = 0; i < screenSurface.Width; i++)
        {
            for (int j = 0; j < this.Width; j++)
            {
                var playerPosition = Position + new Point(i, 0);
                var otherObjectPosition = screenSurface.Position + new Point(j, 0);

                if (playerPosition == otherObjectPosition)
                {
                    return true;
                }
            }
        }

        return false;
    }
}