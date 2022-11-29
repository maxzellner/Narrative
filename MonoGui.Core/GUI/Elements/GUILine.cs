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
    public class GUILine : GUIElement
    {
        public Vector2 Origin { get; set; }
        public Vector2 Destination { get; set; }
        public float Thickness { get; set; }
        public Color Color { get; set; }

        public float Distance { get; private set; }
        public float Angle { get; private set; }

        public GUILine(Vector2 origin, Vector2 destination, Color color, float thickness = 1.0f)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.Thickness = thickness;
            this.Color = color;

            Distance = Vector2.Distance(origin, destination);
            Angle = (float)Math.Atan2(destination.Y - origin.Y, destination.X - origin.X);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            MainGame.SpriteBatch.Draw(TextureManager.Pixel, Origin, null, Color, Angle, new Vector2(0f, 0.5f), new Vector2(Distance, Thickness), SpriteEffects.None, 0);
            base.Draw(gameTime);
        }
    }
}