using FE3H.Items;
using FE3H.Tiles;
using FE3H.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class SwordOfTheCreatorWhip : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("SwordOfTheCreator"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A Hero's Relic said to be a gift to humanity from the Goddess herself.");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = Item.sellPrice(gold: 50);
            item.rare = 7;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAnimation = 20;
            item.useTime = 20;
            item.knockBack = 4f;
            item.damage = 100;
            item.shoot = ModContent.ProjectileType<SotCWhip>();
            item.shootSpeed = 50.0f;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.crit = 9;
            item.channel = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Placeable.RelicOre>(), 150);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}