using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGui.Core.Entities;
using MonoGui.Core.Managers;

namespace MonoGui.Core.Realm
{
    public class Tile
    {
        public static int TileSize = 20;
        
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
        public void Draw(GameTime gameTime)
        {
            MainGame.SpriteBatch.Draw(
                TextureManager.Pixel, 
                new Vector2(X * Tile.TileSize, Y * Tile.TileSize), 
                new Rectangle(0, 0, 19, 19),
                new Color(0, Noise, 0));
        }        
    }
}