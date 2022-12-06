using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Narrative.Core.Managers;

namespace Narrative.Core.GUI.Elements
{
    public class GUIRectangle : GUIElement
    {
        public int X;
        public int Y;
        public int W;
        public int H;
        public Color Color;

        public GUIRectangle(int x, int y, int w, int h, Color color)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.Color = color;
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TextureManager.Pixel, new Rectangle(X, Y, W, H), Color);
        }
    }
}