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
        public Rectangle Bounds { get; set; }
        public string Text { get; set; }
        public Alignment Alignment { get; set; }
        public float Scale { get; set; }
        public Color Color { get; set; }

        public Vector2 Position { get; private set; }
        private Vector2 origin;
        public GUILabel(int x, int y, int w, int h, string text, Alignment alignment, float scale, Color color)
        {
            this.Bounds = new Rectangle(x, y, w, h);
            this.Text = text;
            this.Alignment = alignment;
            this.Scale = scale;
            this.Color = color;    
            
            SetPosition();        
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
                Position,
                Color,
                0,
                origin,
                Scale,
                SpriteEffects.None,
                0.0f);

            base.Draw(gameTime);
        }

        private void SetPosition()
        {
            Vector2 size = TextureManager.MetaFont.MeasureString(Text);
            Position = Bounds.Center.ToVector2();
            origin = size*0.5f;

            if ( Alignment.HasFlag( Alignment.Left ) )
                origin.X += Bounds.Width/2 - size.X/2;

            if ( Alignment.HasFlag( Alignment.Right ) )
                origin.X -= Bounds.Width/2 - size.X/2;

            if ( Alignment.HasFlag( Alignment.Top ) )
                origin.Y += Bounds.Height/2 - size.Y/2;

            if ( Alignment.HasFlag( Alignment.Bottom ) )
                origin.Y -= Bounds.Height/2 - size.Y/2;
        }
    }
}