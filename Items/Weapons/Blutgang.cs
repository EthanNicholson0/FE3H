using FE3H.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace FE3H.Items.Weapons
{
    public class Blutgang : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Blutgang"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Sword of House Edmund. Fires Black Beast heads with every swing.");
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.useTurn = true;
            item.width = 72;
            item.height = 64;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = Item.sellPrice(gold: 50);
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override bool AltFunctionUse(Player player)//You use this to allow the item to be right clicked
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.melee = false;
                item.magic = true;
                item.damage = 200;
                item.shoot = ProjectileType<BlackBeast>();
                item.shootSpeed = 16f;
            }
            else
            {
                item.melee = true;
            }
            return base.CanUseItem(player);
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