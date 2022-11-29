using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.Screens
{
    public static class ScreenManager
    {
        public static Stack<Screen> Screens { get; } = new Stack<Screen>();

        public static void Add(Screen screen) 
        {
            Screens.Push(screen);
        }

        public static void Update(GameTime gameTime) 
        {
            Screens.Peek().Update(gameTime);
        }
        public static void Draw(GameTime gameTime) 
        {
            Screens.Peek().Draw(gameTime);
        }
    }
}