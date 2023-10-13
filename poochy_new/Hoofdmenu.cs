using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace poochy_new
{
    internal class Hoofdmenu
    {
        // Lijst van menu-items
        private List<string> menuItems;
        private int selectedItemIndex; // Index van het geselecteerde menu-item
        private SpriteFont font; // Font voor het tekenen van de menu-items

        public Hoofdmenu()
        {
            menuItems = new List<string>
            {
                "Start Game",
                "Options",
                "Exit"
            };
            selectedItemIndex = 0;
        }

        // Laad de benodigde content (zoals fonts)
        public void LoadContent(ContentManager content)
        {
            font = content.Load<SpriteFont>("naamVanJouwFont"); // Vervang "naamVanJouwFont" door de naam van jouw SpriteFont bestand in de Content map
        }

        // Update de menu logica (bijv. navigatie tussen items)
        public void Update()
        {
            // Voorbeeld: navigeer door menu-items met pijltoetsen
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                selectedItemIndex--;
                if (selectedItemIndex < 0) selectedItemIndex = menuItems.Count - 1;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                selectedItemIndex++;
                if (selectedItemIndex >= menuItems.Count) selectedItemIndex = 0;
            }
        }

        // Teken het menu op het scherm
        public void Draw(SpriteBatch spriteBatch)
        {
            // Teken de menu-items als tekst op het scherm
            for (int i = 0; i < menuItems.Count; i++)
            {
                Color color = (i == selectedItemIndex) ? Color.Yellow : Color.White; // Markeer het geselecteerde item
                spriteBatch.DrawString(font, menuItems[i], new Vector2(100, 100 + i * 40), color);
            }
        }
    }
}

