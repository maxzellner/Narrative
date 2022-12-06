using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Narrative.Core.Screens
{
    public static class ScreenManager
    {
        private static Stack<Screen> _screens { get; } = new Stack<Screen>();

        public static void Push(Screen screen) 
        {
            _screens.Push(screen);
        }

        public static void Pop()
        {
            _screens.Pop();
        }

        public static Screen Peek()
        {
            return _screens.Peek();
        }

        public static void Update(GameTime gameTime) 
        {
            _screens.Peek().Update(gameTime);
        }
        public static void Draw() 
        {
            _screens.Peek().Draw();
        }
    }
}