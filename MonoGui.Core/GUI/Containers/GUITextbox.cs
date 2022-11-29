using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.Managers;
using MonoGui.Core.GUI.Elements;

namespace MonoGui.Core.GUI
{
    public class GUITextbox : GUIContainer
    {
        public int X;
        public int Y;
        public int W;
        public int H;
        public Color Color;

        public GUITextbox(int x, int y, int w, int h, Color color)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.Color = color;

            this.Add(new GUIRectangle(100,100,400,100, Color));
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            //MainGame.SpriteBatch.Draw(TextureManager.MetaPixel, new Rectangle(X, Y, W, H), Color);
            base.Draw(gameTime);
        }
    }
}