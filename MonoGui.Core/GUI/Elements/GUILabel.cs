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
        public Color TextColor { get; set; }

        public bool FillBounds { get; set; }
        public Color FillColor { get; set; }


        public Vector2 Position { get; private set; }
        private Vector2 origin;
        

        public GUILabel(
            int x,
            int y,
            int w,
            int h,
            string text,
            Alignment alignment,
            float scale,
            Color textColor,
            bool fillBounds = false,
            Color? fillColor = null)
        {
            this.Bounds = new Rectangle(x, y, w, h);
            this.Text = text;
            this.Alignment = alignment;
            this.Scale = scale;
            this.TextColor = textColor;   
            this.FillBounds = fillBounds;
            this.FillColor = fillColor ?? Color.Magenta; 
            
            SetPosition();        
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (this.FillBounds)
            {
                spriteBatch.Draw(TextureManager.Pixel, Bounds, FillColor);
            }

            spriteBatch.DrawString(
                TextureManager.MetaFont,
                Text,
                Position,
                TextColor,
                0,
                origin,
                Scale,
                SpriteEffects.None,
                1.0f);
            // MainGame.SpriteBatch.DrawString()
        }

        private void SetPosition()
        {
            Vector2 size = TextureManager.MetaFont.MeasureString(Text);
            Position = Bounds.Center.ToVector2();
            origin = size*0.5f;

            // if ( Alignment.HasFlag( Alignment.Left ) )
            //     origin.X += Bounds.Width/2 - size.X/2;

            // if ( Alignment.HasFlag( Alignment.Right ) )
            //     origin.X -= Bounds.Width/2 - size.X/2;

            // if ( Alignment.HasFlag( Alignment.Top ) )
            //     origin.Y += Bounds.Height/2 - size.Y/2;

            // if ( Alignment.HasFlag( Alignment.Bottom ) )
            //     origin.Y -= Bounds.Height/2 - size.Y/2;

            switch (Alignment)
            {
                case Alignment.TopLeft : 
                    origin.Y += Bounds.Height/2 - size.Y/2;
                    origin.X += Bounds.Width/2 - size.X/2;
                    break;
                case Alignment.TopCenter :
                    origin.Y += Bounds.Height/2 - size.Y/2;
                    break;
                case  Alignment.TopRight : 
                    origin.Y += Bounds.Height/2 - size.Y/2;
                    origin.X -= Bounds.Width/2 - size.X/2;
                    break;
                case  Alignment.MiddleLeft :
                    origin.X += Bounds.Width/2 - size.X/2;
                    break;
                case Alignment.MiddleCenter : 
                    break;
                case Alignment.MiddleRight : 
                    origin.X -= Bounds.Width/2 - size.X/2; 
                    break;
                case Alignment.BottomLeft : 
                    origin.Y -= Bounds.Height/2 - size.Y/2;
                    origin.X += Bounds.Width/2 - size.X/2;
                    break;
                case Alignment.BottomCenter : 
                    origin.Y -= Bounds.Height/2 - size.Y/2;
                    break;
                case Alignment.BottomRight : 
                    origin.Y -= Bounds.Height/2 - size.Y/2;
                    origin.X -= Bounds.Width/2 - size.X/2;
                    break;
            }
        }
    }
}