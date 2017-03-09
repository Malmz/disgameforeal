using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace DisGameFoReal
{
    class Object
    {
        protected Rectangle rectangle;
        protected Texture2D texture;
        protected int depth;

        public Object() {}

        public Object(Rectangle rectangle, Texture2D texture, int depth = 0)
        {
            this.rectangle = rectangle;
            this.texture = texture;
            this.depth = depth;
        }

        public Rectangle Rectangle
        {
            get { return rectangle; }
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
