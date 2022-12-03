using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGui.Core.Entities;
using MonoGui.Core.GUI;
using MonoGui.Core.GUI.Elements;
using MonoGui.Core.Managers;
using MonoGui.Core.Realm;

namespace MonoGui.Core.Screens
{
    public class TestScreen : Screen
    {
        private Map map;
        private EntityContainer entities = new EntityContainer(); 
        
        public TestScreen()
        {
            map = new Map(32,32);
            entities.Add(new Player());
        }
        
        public override void Update(GameTime gameTime)
        {
            entities.Update(gameTime);
        }
        
        public override void Draw(GameTime gameTime)
        {
            map.Draw(gameTime);
            entities.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}