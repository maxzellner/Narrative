using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Narrative.Core.Managers
{
    public static class WindowManager
    {
        private static MainGame mainGame = MainGame.Instance;

        public static void Init()
        {
            mainGame.Window.IsBorderless = true;
        }
    }
}