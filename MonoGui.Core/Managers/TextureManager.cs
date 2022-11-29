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
        public static Texture2D WhitePixel { get; set; }

        public static void Init()
        {
            WhitePixel = new Texture2D(MainGame.Graphics.GraphicsDevice, 1, 1); 
            WhitePixel.SetData(new [] { Color.White });
        }
    }
}