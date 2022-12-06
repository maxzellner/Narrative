using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Narrative.Core.Universe
{
    public static class Generator
    {
        public static Tile[,] GenerateTiles(int x, int y)
        {
            var tiles = new Tile[x,y];

            

            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tiles[i,j] = new Tile(i, j, GetTerrainNoise(i,j,0), GetManaDensityNoise(i,j,0));
                }
            }

            return tiles;
        }

        public static float GetTerrainNoise(float x, float y, float z)
        {
            FastNoiseLite noise = new FastNoiseLite();
            noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2S);
            noise.SetFrequency(0.040f);
            noise.SetFractalType(FastNoiseLite.FractalType.FBm);
            noise.SetFractalOctaves(5);
            noise.SetFractalLacunarity(2.0f);
            noise.SetFractalGain(0.5f);

            return (noise.GetNoise(x,y,z)  + 1f) / 2;
        }

        public static float GetManaDensityNoise(float x, float y, float z)
        {
            FastNoiseLite noise = new FastNoiseLite();
            noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2S);
            noise.SetFrequency(0.02f);

            return (noise.GetNoise(x,y,z)  + 1f) / 2;
        }
    }
}