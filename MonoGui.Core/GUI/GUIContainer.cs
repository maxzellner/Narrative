using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGui.Core.GUI
{
    public class GUIContainer
    {
        
        public Stack<GUIElement> Children { get; private set; }

        public GUIContainer() 
        {
            Children = new Stack<GUIElement>();
        }

        public GUIContainer(params GUIElement[] guiElements)
        {
            foreach (GUIElement guiElement in guiElements)
            {
                Children.Push(guiElement);
            }
        }

        public void Add(GUIElement guiElement) 
        {
            Children.Push(guiElement);
        }


        public void Update(GameTime gameTime) 
        {
            foreach (GUIElement guiElement in Children)
            {
                guiElement.Update(gameTime);
            }
        }
        public void Draw(GameTime gameTime) 
        {
            foreach (GUIElement guiElement in Children)
            {
                guiElement.Draw(gameTime);
            }
        }
    }
}