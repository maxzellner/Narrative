using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.Managers
{
    public static class InputManager
    {
        private static KeyboardState _previousKeyboardState;
        public static KeyboardState KeyboardState { get; private set; }
        public static bool JustReleased(Keys key)
        {
            return _previousKeyboardState.IsKeyDown(key) && KeyboardState.IsKeyUp(key);
        }

        public static void Update()
        {
            _previousKeyboardState = InputManager.KeyboardState;
            InputManager.KeyboardState = Keyboard.GetState();
        }
    }
}