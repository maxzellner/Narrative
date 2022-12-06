using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Narrative.Core.Managers;
using Narrative.Core.GUI;
using Narrative.Core.GUI.Elements;

namespace Narrative.Core.Screens
{
    public class SettingsScreen : Screen
    {
        public SettingsScreen(SpriteBatch spriteBatch) : base(spriteBatch)
        {
        }

        public override void Update(GameTime gameTime)
        {
            if (InputManager.JustReleased(Keys.Tab))
            {
                ScreenManager.Pop();
            }

            base.Update(gameTime);
        }
        
        public override void Draw()
        {
            gui.Add(new GUILabel(0,0,500,500,"SETTINGS",Alignment.MiddleCenter,1.0f,Color.AliceBlue));

            base.Draw();
        }
    }
}