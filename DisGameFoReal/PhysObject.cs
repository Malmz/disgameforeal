using Microsoft.Xna.Framework;

namespace DisGameFoReal
{
    class PhysObject : Object
    {
        private Vector2 speed;

        public Vector2 Speed
        {
            get { return speed; }
        }

        public void addMotion(float X = 0, float Y = 0)
        {
            speed.X += X;
            speed.Y += Y;
        }

        public void addMotion(Vector2 speed)
        {
            this.speed = speed;
        }

    }
}
