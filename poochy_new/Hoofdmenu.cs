using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace poochy_new
{
    internal class Hoofdmenu
    {
        // Lijst van menu-items (voor dit voorbeeld zijn het gewoon strings, maar je kunt een aangepaste klasse maken voor menu-items)
        private List<string> menuItems;
        private int selectedItemIndex; // Index van het geselecteerde menu-item

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
            // Voor dit voorbeeld tekenen we gewoon de menu-items als tekst op het scherm
            // Je kunt hier aangepaste graphics en animaties toevoegen
            for (int i = 0; i < menuItems.Count; i++)
            {
                Color color = (i == selectedItemIndex) ? Color.Yellow : Color.White; // Markeer het geselecteerde item
                spriteBatch.DrawString(/* jouw SpriteFont */, menuItems[i], new Vector2(100, 100 + i * 40), color);
            }
        }
    }
}
