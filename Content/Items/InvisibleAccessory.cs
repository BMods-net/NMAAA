using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NMAAA.Content.Items
{
    public class InvisibleAccessory : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.accessory = true;
            Item.rare = ItemRarityID.Red;
            Item.value = Item.sellPrice(copper: 0);
        }
    }
}
