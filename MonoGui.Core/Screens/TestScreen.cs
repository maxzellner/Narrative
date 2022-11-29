using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGui.Core.GUI;
using MonoGui.Core.GUI.Elements;

namespace MonoGui.Core.Screens
{
    public class TestScreen : Screen
    {
        public TestScreen()
        {
            _guiContainer.Add(new GUIRectangle(10, 10, 20, 20, Color.Red));
        }
        
        public override void Update(GameTime gameTime)
        {
            
        }
        
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

    }
}