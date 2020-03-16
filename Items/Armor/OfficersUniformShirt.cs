using FE3H.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class OfficersUniformShirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Officer's Academy Shirt");
            Tooltip.SetDefault("Shirt worn by members of the Officer's Academy."
                + "\nImmunity to 'Broken Armor'"
                + "\nImmunity to 'Bleeding'"
                + "\n+100 max mana");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 6;
            item.defense = 60;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.Bleeding] = true;
            player.statManaMax2 += 100;
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