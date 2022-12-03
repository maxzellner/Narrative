using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MonoGui.Core.Entities
{
    public abstract class Entity
    {
        
        public Vector2 Position;

        public bool Visible { get; set; }

        //public event EventHandler<EventArgs> DrawOrderChanged;
        //public event EventHandler<EventArgs> VisibleChanged;
        public virtual void Move(Vector2 newPosition)
        {
            this.Position = newPosition;
        }


        public virtual void Update(GameTime gameTime)
        {
            
        }
        public virtual void Draw(GameTime gameTime)
        {
            
        }
    }
}