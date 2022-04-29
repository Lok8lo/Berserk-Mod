using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Items.Stigma
{
	public class Stigma : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
			DisplayName.SetDefault("Stigma");
			Tooltip.SetDefault("the stigma of the victim");
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
			item.width = 22;
			item.height = 35;
			item.value = 30000;
		}
	}
}