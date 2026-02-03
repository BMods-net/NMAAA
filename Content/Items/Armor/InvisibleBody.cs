using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NMAAA.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]

    public class InvisibleBody : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(copper: 0);
            Item.rare = ItemRarityID.Red;
            Item.vanity = true;
        }
        public override bool IsVanitySet(int head, int body, int legs) => true;
    }
}
