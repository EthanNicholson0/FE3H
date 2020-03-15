using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FE3H.Items.Accessories
{
    // This file is showcasing inheritance to implement an accessory "type" that you can only have one of equipped
    // It also shows how you can interact with inherited methods
    // Additionally, it takes advantage of ValueTuple to make code more compact

    // First, we create an abstract class that all our exclusive accessories will be based on
    // This class won't be autoloaded by tModLoader, meaning it won't "exist" in the game, and we don't need to provide it a texture
    // Further down below will be the actual items (Green/Yellow Exclusive Accessory)
    public abstract class HeartOfSothis : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Heart of the Progenitor God. Her power flows throughout it.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.Green;
        }
    }
}