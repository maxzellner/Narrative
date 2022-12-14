using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Narrative.Core.Entities;
using Narrative.Core.GUI;
using Narrative.Core.GUI.Elements;
using Narrative.Core.Managers;
using Narrative.Core.Universe;

namespace Narrative.Core.Screens
{
    public class TestScreen : Screen
    {
        private Map map;
        private EntityContainer entities;

        public TestScreen(SpriteBatch spriteBatch) : base(spriteBatch)
        {
            map = new Map(spriteBatch);
            map.GenerateMap(128,128);

            entities = new EntityContainer(spriteBatch);
            entities.Add(new Player(map.Center));
            
            Camera.MoveCamera(map.Center);
        }

        public override void Update(GameTime gameTime)
        {
            if (InputManager.JustReleased(Keys.Tab))
            {
                ScreenManager.Push(new SettingsScreen(MainGame.SpriteBatchUI));
            }

            map.Update(gameTime);

            entities.Update(gameTime);
        }
        
        public override void Draw()
        {
            map.Draw();
            entities.Draw();

            base.Draw();
        }
    }
}