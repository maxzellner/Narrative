using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.GUI
{
    public abstract class GUIElement //: IDrawable
    {
        public int DrawOrder { get; set; }

        public bool Visible { get; set; }

        //public event EventHandler<EventArgs> DrawOrderChanged;
        //public event EventHandler<EventArgs> VisibleChanged;

        public virtual void Update(GameTime gameTime)
        {
            
        }
        public virtual void Draw(GameTime gameTime)
        {
            
        }
    }
}