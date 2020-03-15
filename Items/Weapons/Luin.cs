using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using FE3H.Items.Placeable;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class Luin : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Luin"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Lance of House Daphnel.");
        }
        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.scale = 1f;
            item.maxStack = 1;
            item.useTime = 18;
            item.useAnimation = 18;
            item.knockBack = 3.5f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(gold: 50);
            item.rare = 7;
            item.shoot = mod.ProjectileType("LuinProjectile");
            item.shootSpeed = 3.2f;
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