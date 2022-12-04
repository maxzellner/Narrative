using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.Entities
{
    public class EntityContainer
    {
        SpriteBatch _spriteBatch;
        public Queue<Entity> Children { get; private set; }

        public EntityContainer(SpriteBatch spriteBatch) 
        {
            _spriteBatch = spriteBatch;
            Children = new Queue<Entity>();
        }

        public void Add(Entity entity) 
        {
            Children.Enqueue(entity);
        }


        public void Update(GameTime gameTime) 
        {
            foreach (Entity entity in Children)
            {
                entity.Update(gameTime);
            }
        }
        public void Draw() 
        {
            foreach (Entity entity in Children)
            {
                entity.Draw(_spriteBatch);
            }
        }
    }
}