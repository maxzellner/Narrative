using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.Entities
{
    public class EntityContainer : Entity
    {
        public Queue<Entity> Children { get; private set; }

        public EntityContainer() 
        {
            Children = new Queue<Entity>();
        }

        public void Add(Entity entity) 
        {
            Children.Enqueue(entity);
        }


        public override void Update(GameTime gameTime) 
        {
            foreach (Entity entity in Children)
            {
                entity.Update(gameTime);
            }
        }
        public override void Draw(GameTime gameTime) 
        {
            foreach (Entity entity in Children)
            {
                entity.Draw(gameTime);
            }
        }
    }
}