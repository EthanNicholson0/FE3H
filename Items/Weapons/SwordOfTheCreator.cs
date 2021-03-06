using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class SwordOfTheCreator : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("SwordOfTheCreator"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A Hero's Relic said to be a gift to humanity from the Goddess herself.");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.useTurn = true;
            item.width = 76;
            item.height = 76;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = Item.sellPrice(copper: 20);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Placeable.RelicOre>(), 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}