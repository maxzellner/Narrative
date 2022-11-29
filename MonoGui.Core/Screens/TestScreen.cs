using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGui.Core.GUI;
using MonoGui.Core.GUI.Elements;
using MonoGui.Core.Managers;

namespace MonoGui.Core.Screens
{
    public class TestScreen : Screen
    {
        public TestScreen()
        {
            root.Add(new GUIRectangle(100, 100, 400, 400, Color.Red));
            root.Add(new GUILabel(100, 100, 400, 400,"foobar", Alignment.Center, 1f, Color.Azure));
            
            root.Add(new GUILine(new Vector2(100,100),new Vector2(200,300), Color.BlueViolet, 5.0f));
        }
        
        public override void Update(GameTime gameTime)
        {
            
        }
        
        public override void Draw(GameTime gameTime)
        {
            //MainGame.SpriteBatch.Draw(TextureManager.MetaPixel,)
            base.Draw(gameTime);
        }
    }
}