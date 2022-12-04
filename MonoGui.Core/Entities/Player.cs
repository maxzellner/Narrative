using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using MonoGui.Core.Managers;

namespace MonoGui.Core.Entities
{
    public class Player : Entity
    {
        private static float _movementSpeed = 500.0f;

        public Player(Vector2 startingLocation)
        {
            Position = startingLocation;
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                this.Position.Y -= _movementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                this.Position.Y += _movementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                this.Position.X -= _movementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                this.Position.X += _movementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                TextureManager.Pixel,
                Position,
                new Rectangle(0, 0, 32, 32),
                Color.Red);
            spriteBatch.DrawString(TextureManager.MetaFont,"@",Position,Color.Black);
        }
    }
}