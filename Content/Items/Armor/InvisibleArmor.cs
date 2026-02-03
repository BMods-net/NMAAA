using NMAAA.Content.Items;
using NMAAA.Content.Items.Armor;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NMAAA.Items.Armor
{
    public class InvisibleArmor : ModPlayer
    {
        public override void FrameEffects()
        {
            if (Player.armor[0].type == ModContent.ItemType<InvisibleHelmet>() ||
                Player.armor[10].type == ModContent.ItemType<InvisibleHelmet>())
            {
                Player.head = -1;
            }

            if (Player.armor[1].type == ModContent.ItemType<InvisibleBody>() ||
                Player.armor[11].type == ModContent.ItemType<InvisibleBody>())
            {
                Player.body = -1;
            }

            if (Player.armor[2].type == ModContent.ItemType<InvisibleLegs>() ||
                Player.armor[12].type == ModContent.ItemType<InvisibleLegs>())
            {
                Player.legs = -1;
            }
        }
    }
}