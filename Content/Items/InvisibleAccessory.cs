using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class InvisibleAccessory : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.accessory = true; // Без этого нелзя одеть в слот для аксессуаров
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.sellPrice(gold: 99);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 1000;

            player.statLife = player.statLifeMax2;

            if (player.statLife < 100)
            {
                player.statLife = player.statLifeMax2;
            }

            player.noKnockback = true;
        }


    }
}
