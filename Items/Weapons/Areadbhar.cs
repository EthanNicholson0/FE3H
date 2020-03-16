using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class Areadbhar : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Blutgang"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Legendary lance of House Blaiddyd.");
        }
        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 78;
            item.height = 62;
            item.scale = 1f;
            item.maxStack = 1;
            item.useTime = 16;
            item.useAnimation = 16;
            item.knockBack = 5.5f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(platinum: 2);
            item.rare = 8;
            item.shoot = mod.ProjectileType("AreadbharProjectile");
            item.shootSpeed = 2.7f;
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