using FE3H.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class Thyrsus : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Magic staff of House Gloucester. Right Click for bouncing magic ball, Left Click for explosion");
            Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.magic = true;
            item.mana = 12;
            item.width = 40;
            item.height = 40;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.value = Item.sellPrice(gold: 50);
            item.rare = 7;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = ProjectileType<CustomExplosiveProj>();
            item.shootSpeed = 16f;
        }

        public override bool AltFunctionUse(Player player)//You use this to allow the item to be right clicked
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 200;
                item.shoot = ProjectileType<SparklingBall>();
                item.shootSpeed = 16f;
            }
            else
            {
                item.shoot = ProjectileType<CustomExplosiveProj>();
                item.shootSpeed = 16f;
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Placeable.RelicOre>(), 150);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}