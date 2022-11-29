using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.Managers
{
    public static class TextureManager
    {
        public static Texture2D Pixel { get; private set; }
        public static SpriteFont MetaFont { get; private set; }

        public static void Init()
        {
            Pixel = new Texture2D(MainGame.Graphics.GraphicsDevice, 1, 1); 
            Pixel.SetData(new [] { Color.White });

            MetaFont = MainGame.Instance.Content.Load<SpriteFont>("MetaFont_24px");
        }
    }
}