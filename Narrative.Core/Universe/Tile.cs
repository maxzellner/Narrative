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
        public float Terrain;
        public float ManaDensity;

        public Tile(int x, int y, float terrain, float manaDensity)
        {
            this.X = x;
            this.Y = y;
            this.Terrain = terrain;
            this.ManaDensity = manaDensity;
        }

        public void Update(GameTime gameTime)
        {
            this.ManaDensity = Generator.GetManaDensityNoise(X,Y,(float)gameTime.TotalGameTime.TotalSeconds * 100);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                TextureManager.Pixel, 
                new Vector2(X * Tile.TileSize, Y * Tile.TileSize), 
                new Rectangle(0, 0, 32, 32),
                Microsoft.Xna.Framework.Color.Lerp(Color.SkyBlue, Color.DarkGreen, Terrain));
            
            spriteBatch.Draw(
                TextureManager.Pixel, 
                new Vector2(X * Tile.TileSize, Y * Tile.TileSize), 
                new Rectangle(0, 0, 32, 32),
                Microsoft.Xna.Framework.Color.Lerp(Color.BlueViolet, Color.Red, ManaDensity));
        }        
    }
}