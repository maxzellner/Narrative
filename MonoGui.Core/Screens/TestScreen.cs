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
            _guiContainer.Add(new GUIRectangle(10, 10, 400, 200, Color.Red));
            _guiContainer.Add(new GUILabel(0,0,100,100,"foobar", 0.5f, Color.Azure));
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