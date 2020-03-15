using FE3H.Items;
using FE3H.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FE3H.NPCs
{
    public class FE3HGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        public bool eFlames;
        public bool exampleJavelin;

        public override void ResetEffects(NPC npc)
        {
            eFlames = false;
            exampleJavelin = false;
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Dryad)
            {
                shop.item[nextSlot].SetDefaults(ItemType<Items.Placeable.RelicOre>());
                nextSlot++;
            }
        }

        public override void NPCLoot(NPC npc)
        {
            // See BossBags.OpenVanillaBag to see how to handle adding items to the boss bags used in expert mode. You'll want to do both for most items added to boss drops.
            if (npc.type == NPCID.TheDestroyer)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.HeartOfSothis>());
            }
        }
    }
}