using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class Aymr : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Aymr"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Created for a conqueror who wishes to end the churches reign.");
        }

        public override void SetDefaults()
        {
            item.damage = 500;
            item.melee = true;
            item.width = 77;
            item.height = 69;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 11;
            item.value = Item.sellPrice(platinum: 1);
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Placeable.RelicOre>(), 200);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}