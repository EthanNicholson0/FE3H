using FE3H.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
    public class Failnaught : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Bow of House Reigan. Left Click fires an arrow, Right Click fires a beam of light");
        }

        public override void SetDefaults()
        {
            item.damage = 200;
            item.noMelee = true;
            item.magic = true;
            item.channel = false; //Channel so that you can held the weapon [Important]
            item.mana = 5;
            item.rare = 8;
            item.width = 32;
            item.height = 90;
            item.useTime = 20;
            item.UseSound = SoundID.Item13;
            item.useStyle = 5;
            item.shootSpeed = 14f;
            item.useAnimation = 20;
            item.shoot = ProjectileType<ArrowMagic>();
            item.value = Item.sellPrice(platinum: 1);
        }

        public override bool AltFunctionUse(Player player)//You use this to allow the item to be right clicked
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 150;
                item.shootSpeed = 50f;
                item.useTime = 50;
                item.channel = true; //Channel so that you can held the weapon [Important]
                item.shoot = ProjectileType<ExampleLaser>();
            }
            else
            {
                item.shootSpeed = 14f;
                item.shoot = ProjectileType<ArrowMagic>();
            }
            return base.CanUseItem(player);
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