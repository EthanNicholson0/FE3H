using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FE3H.Items
{
    public class HeartOfSothis : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Heart of the Progenitor God. Her power flows throughout it.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = Item.sellPrice(platinum: 1);
            item.maxStack = 1;
            item.rare = 9;
        }
    }
}

    