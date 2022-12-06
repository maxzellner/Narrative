using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Narrative.Core.Entities;
using Narrative.Core.Managers;

namespace Narrative.Core.Universe
{
    public class Tile
    {
        public static int TileSize = 32;
        
        public int X, Y;
        public float Noise;

        public Tile(int x, int y, float noise)
        {
            this.X = x;
            this.Y = y;
            this.Noise = noise;
        }

        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                TextureManager.Pixel, 
                new Vector2(X * Tile.TileSize, Y * Tile.TileSize), 
                new Rectangle(0, 0, 32, 32),
                Microsoft.Xna.Framework.Color.Lerp(Color.SkyBlue, Color.DarkGreen, Noise));
        }        
    }
}