using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DisGameFoReal
{
    class Player : PhysObject 
    {
        private float jumpHeight;
        private bool grounded;
        private float acceleration;


        public Player(Texture2D texture, float jumpHeight = 3, float acceleration = 0.3f)
        {
            this.jumpHeight = jumpHeight;
            this.acceleration = acceleration;
            this.texture = texture;
            rectangle = texture.Bounds;
        }

        public void movement(KeyboardState keystate, KeyboardState keystateOld)
        {
            if(keystate.IsKeyDown(Keys.A))
            {
                addMotion(X:-acceleration);
            }

            if (keystate.IsKeyDown(Keys.D))
            {
                addMotion(X:acceleration);
            }

            if (keystate.IsKeyDown(Keys.Space) && keystateOld.IsKeyUp(Keys.Space) && grounded)
            {
                addMotion(Y: jumpHeight);
            }
        }

        public void update()
        {
            Vector2 friction = new Vector2(Speed.X, Speed.Y);
            friction.Normalize();
            addMotion(-friction);
            addMotion(Y: Globals.gravity);
            rectangle.Offset(Speed);
        }
    }
}
