using SadConsole;
using SadRogue.Primitives;

namespace SpaceShooter
{
    public class Enemy : ScreenSurface, IMoveable
    {
        private int _ticks;
        private float _speed;
        public Point Position { get; set; }


        public Enemy(int speed) : base(1, 1)
        {
            _speed = speed;

            Surface[0, 0].Glyph = 'V';


            Surface[0, 0].Glyph = speed switch
            {
                1 => 'A',
                2 => 'B',
                3 => 'C',
                4 => 'D',
                _ => 'E'
            };
        }

        public Enemy() : base(1, 1)
        {
            Surface[0, 0].Glyph = 'V';
            Position = new Point(0, 0);  
            Surface[0, 0].Foreground = Color.Gray; 
        }


        public void Move()
        {
            _ticks++;
            if (_ticks % _speed == 0)
            {
                Position += new Point(0, 1);  
            }
        }
    }
}

