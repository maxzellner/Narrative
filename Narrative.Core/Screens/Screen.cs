using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Narrative.Core.Entities;
using Narrative.Core.GUI;
using Narrative.Core.GUI.Elements;

namespace Narrative.Core.Screens
{
    public abstract class Screen
    {
        //private protected EntityContainer entities = new EntityContainer();
        private protected GUIContainer gui;
        
        private protected SpriteBatch spriteBatch;

        public bool Active 
        {
            get 
            {
                return ScreenManager.Peek().GetType() == this.GetType();
            }
        }

        protected Screen(SpriteBatch screenSpriteBatch)
        {
            spriteBatch = screenSpriteBatch;
            gui = new GUIContainer();
        }

        public virtual void Update(GameTime gameTime)
        {
            gui.Update(gameTime);
        }

        public virtual void Draw()
        {
            gui.Draw(spriteBatch);
        }
    }
}