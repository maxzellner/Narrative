using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.GUI
{
    public abstract class GUIElement
    {
        //private SpriteBatch spriteBatch;

        public int DrawOrder { get; set; }

        public bool Visible { get; set; }

        // protected GUIElement(SpriteBatch parentSpriteBatch)
        // {
        //     spriteBatch = parentSpriteBatch;
        // }

        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}