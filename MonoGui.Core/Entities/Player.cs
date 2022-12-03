using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.Managers;

namespace MonoGui.Core.Entities
{
    public class Player : Entity
    {
        public Player()
        {
            Position = new Vector2(20f,20f);
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                this.Position.Y -= 1f;
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                this.Position.Y += 1f;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                this.Position.X -= 1f;
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                this.Position.X += 1f;

        }
        public override void Draw(GameTime gameTime)
        {
            MainGame.SpriteBatch.Draw(
                TextureManager.Pixel,
                Position,
                new Rectangle(0, 0, 10, 10),
                Color.Red);
        }
    }
}