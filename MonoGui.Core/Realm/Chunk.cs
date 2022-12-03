using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MonoGui.Core.Realm
{
    public class Chunk
    {
        private List<Tile> tiles;

        public bool Active;

        public Chunk()
        {
            
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime)
        {
            foreach (Tile tile in tiles)
            {
                tile.Draw(gameTime);
            }
        }
    }
}