using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoGui.Core.Universe
{
    public static class Generator
    {
        public static Tile[,] GenerateTiles(int x, int y)
        {
            var tiles = new Tile[x,y];

            FastNoiseLite noise = new FastNoiseLite();
            noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2S);
            noise.SetFrequency(0.040f);
            noise.SetFractalType(FastNoiseLite.FractalType.FBm);
            noise.SetFractalOctaves(5);
            noise.SetFractalLacunarity(2.0f);
            noise.SetFractalGain(0.5f);

            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tiles[i,j] = new Tile(i, j, (noise.GetNoise(i,j) + 1f) / 2);
                }
            }

            return tiles;
        }
    }
}