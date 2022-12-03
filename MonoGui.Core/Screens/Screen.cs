using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.Entities;
using MonoGui.Core.GUI;
using MonoGui.Core.GUI.Elements;

namespace MonoGui.Core.Screens
{
    public abstract class Screen
    {
        //private protected EntityContainer entities = new EntityContainer();
        private protected GUIContainer gui = new GUIContainer();

        public virtual void Update(GameTime gameTime)
        {
            gui.Update(gameTime);
        }

        public virtual void Draw(GameTime gameTime)
        {
            gui.Draw(gameTime);
        }
    }
}