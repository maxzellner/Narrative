using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGui.Core.Entities;
using MonoGui.Core.Managers;

namespace MonoGui.Core.Realm
{
    public class Map
    {
        //private List<Chunk> chunks;

        private Tile[,] tiles;
        private EntityContainer entities;
        
        public Map(int x, int y)
        {
            tiles = new Tile[x,y];

            FastNoiseLite noise = new FastNoiseLite();
            noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2);
            noise.SetFrequency(0.08f);
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tiles[i,j] = new Tile(i, j, noise.GetNoise(i,j));
                }
            }
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime)
        {
            foreach (var tile in tiles)
            {
                tile.Draw(gameTime);
            }
        }
    }
}