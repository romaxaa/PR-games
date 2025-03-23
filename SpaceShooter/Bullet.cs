using SadConsole;
using SadRogue.Primitives;

namespace SpaceShooter;

public class Bullet : ScreenSurface, IMoveable
{
    public Bullet() : base(1, 1)
    {
        Surface[0, 0].Glyph = '|'; // Символ пули
        Surface[0, 0].Foreground = Color.Yellow;
    }

    public void Move()
    {
        Position += new Point(0, -1);
    }
}