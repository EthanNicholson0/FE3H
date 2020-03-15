using FE3H.Items;
using FE3H.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class SublimeSwordOfTheCreator : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("SwordOfTheCreator"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The true power of the sword has been unlocked, but at what cost?");
        }

        public override void SetDefaults()
        {
            item.damage = 250;
            item.melee = true;
            item.useTurn = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(platinum: 2);
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Weapons.SwordOfTheCreator>());
            recipe.AddIngredient(ItemType<Items.HeartOfSothis>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}