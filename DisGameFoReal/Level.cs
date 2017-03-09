using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace DisGameFoReal
{
    class Level
    {
        private List<Object> objects; 

        public void addObject(Rectangle rectangle, Texture2D texture, int depth)
        {
            objects.Add(new Object(rectangle, texture, depth));
        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (Object item in objects)
            {
                item.draw(spriteBatch);
            }
        }

    }
}
