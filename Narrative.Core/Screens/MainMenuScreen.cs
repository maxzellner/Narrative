using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Narrative.Core.GUI;
using Narrative.Core.GUI.Elements;

namespace Narrative.Core.Screens
{
    public class MainMenuScreen : Screen
    {
        public MainMenuScreen(SpriteBatch spriteBatch) : base(spriteBatch)
        {
            gui.Add(new GUILabel(10, 10, 300, 150, "TopLeft", Alignment.TopLeft, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
            gui.Add(new GUILabel(320, 10, 300, 150, "TopCenter", Alignment.TopCenter, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
            gui.Add(new GUILabel(630, 10, 300, 150, "TopRight", Alignment.TopRight, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));

            gui.Add(new GUILabel(10, 170, 300, 150, "MiddleLeft", Alignment.MiddleLeft, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
            gui.Add(new GUILabel(320, 170, 300, 150, "MiddleCenter", Alignment.MiddleCenter, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
            gui.Add(new GUILabel(630, 170, 300, 150, "MiddleRight", Alignment.MiddleRight, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));

            gui.Add(new GUILabel(10, 330, 300, 150, "BottomLeft", Alignment.BottomLeft, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
            gui.Add(new GUILabel(320, 330, 300, 150, "BottomCenter", Alignment.BottomCenter, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
            gui.Add(new GUILabel(630, 330, 300, 150, "BottomRight", Alignment.BottomRight, 1.0f, Color.BlueViolet, true, Color.DarkGoldenrod));
        }

        public override void Update(GameTime gameTime)
        {
            
            
            base.Update(gameTime);
        }
        
        public override void Draw()
        {
            base.Draw();
        }
    }
}