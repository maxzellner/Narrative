using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.Managers;

namespace MonoGui.Core.GUI.Elements
{
    public class GUILabel : GUIElement
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public string Text { get; set; }
        public Alignment Alignment { get; set; }
        public float Scale { get; set; }
        public Color Color { get; set; }

        public GUILabel(int x, int y, int w, int h, string text, float scale, Color color)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.Text = text;
            this.Scale = scale;
            this.Color = color;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            MainGame.SpriteBatch.DrawString(
                TextureManager.MetaFont,
                Text,
                new Vector2(X, Y),
                Color,
                0.0f,
                Vector2.Zero,
                Scale,
                SpriteEffects.None,
                0.0f);
            base.Draw(gameTime);
        }
    }
}