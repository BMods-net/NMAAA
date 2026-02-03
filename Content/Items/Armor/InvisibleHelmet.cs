using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NMAAA.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MagicHelmet : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(copper: 0);
            Item.rare = ItemRarityID.Red;
            Item.vanity = true;
        }

    }
}

