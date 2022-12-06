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
    public class Map
    {
        //private List<Chunk> chunks;
        // private EntityContainer entities;

        private Tile[,] tiles;
        private SpriteBatch spriteBatch;


        public int X, Y;
        public Vector2 Center 
        { 
            get 
            {
                return new Vector2(
                    X * Tile.TileSize / 2, 
                    Y * Tile.TileSize / 2);
            }
        }

        public Map(SpriteBatch rootSpriteBatch)
        {
            spriteBatch = rootSpriteBatch;
        }

        public Tile this[int x, int y] 
        {
            get 
            {
                return tiles[x,y];
            }
        }
        
        public void GenerateMap(int x, int y)
        {
            this.X = x;
            this.Y = y;

            tiles = Generator.GenerateTiles(x, y);
        }

        public void Update(GameTime gameTime)
        {
            foreach (var tile in tiles)
            {
                tile.Update(gameTime);
            }
        }

        public void Draw()
        {
            foreach (var tile in tiles)
            {
                tile.Draw(spriteBatch);
            }
        }
    }
}