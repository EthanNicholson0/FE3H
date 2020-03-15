using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class Thunderbrand : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Thunderbrand"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Sword of House Charon.");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.useTurn = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = Item.sellPrice(gold: 50);
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Placeable.RelicOre>(), 100);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}