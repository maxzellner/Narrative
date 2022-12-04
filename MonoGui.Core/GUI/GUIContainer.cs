using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.Screens;

namespace MonoGui.Core.GUI
{
    public class GUIContainer // : GUIElement
    {
        public Queue<GUIElement> Children { get; private set; }

        public GUIContainer() //: base(spriteBatch)
        {
            Children = new Queue<GUIElement>();
        }

        // public GUIContainer(params GUIElement[] guiElements)
        // {
        //     foreach (GUIElement guiElement in guiElements)
        //     {
        //         Children.Enqueue(guiElement);
        //     }
        // }

        public void Add(GUIElement guiElement)
        {
            Children.Enqueue(guiElement);
        }


        public void Update(GameTime gameTime)
        {
            foreach (GUIElement guiElement in Children)
            {
                guiElement.Update(gameTime);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (GUIElement guiElement in Children)
            {
                guiElement.Draw(spriteBatch);
            }
        }
    }
}