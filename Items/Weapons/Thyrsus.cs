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
            Tooltip.SetDefault("Magic staff of House Gloucester. Left Click for Cursed Flame, Right Click for Hades Omega");
            Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.magic = true;
            item.mana = 12;
            item.width = 80;
            item.height = 78;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.value = Item.sellPrice(gold: 50);
            item.rare = 7;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = ProjectileID.CursedFlameFriendly;
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
                item.mana = 100;
                item.useTime = 70;
                item.useAnimation = 70;
                item.shoot = ProjectileID.NebulaArcanum;
                item.shootSpeed = 1f;
            }
            else
            {
                item.damage = 100;
                item.mana = 12;
                item.useTime = 25;
                item.useAnimation = 25;
                item.shoot = ProjectileID.CursedFlameFriendly;
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