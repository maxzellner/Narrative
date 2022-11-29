using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGui.Core.GUI;
using MonoGui.Core.GUI.Elements;

namespace MonoGui.Core.Screens
{
    public class MainMenuScreen : Screen
    {
        public MainMenuScreen()
        {
            root.Add(new GUILabel(100, 100, 400, 200, "Label 1", Alignment.Center,1.0f, Color.Magenta, true, Color.DarkGoldenrod));
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}