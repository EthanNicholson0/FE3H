using FE3H.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class OfficersUniformLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Trousers worn by members of the Officer's Academy."
                + "\nIncreased Mana Regen"
                + "\nAuto Consumption of Mana Potions");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 6;
            item.defense = 45;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaFlower = true;
            player.manaRegenBuff = true;
            player.lavaImmune = true;
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