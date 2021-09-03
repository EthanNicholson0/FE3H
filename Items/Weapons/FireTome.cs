using FE3H.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Weapons
{
	public class FireTome : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Tome of fire magic, shoots many fireballs");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 30;
			item.magic = true;
			item.mana = 5;
			item.width = 23;
			item.height = 29;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.BallofFire;
			item.shootSpeed = 16f;
		}
        

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.Placeable.RelicOre>(), 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}