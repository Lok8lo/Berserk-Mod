using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Items.Placeable
{
	public class MetalicOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 16;
			item.useTime = 16;
			item.autoReuse = true;
			item.maxStack = 999;
			item.rare = 10;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.MetalicOre>();
			item.width = 12;
			item.height = 12;
			item.value = 30000;
		}
	}
}