using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.GUI;
using MonoGui.Core.GUI.Elements;

namespace MonoGui.Core.Screens
{
    public abstract class Screen
    {
        private protected GUIContainer _guiContainer = new GUIContainer();

        public abstract void Update(GameTime gameTime);

        public virtual void Draw(GameTime gameTime)
        {
            _guiContainer.Draw(gameTime);
        }
    }
}