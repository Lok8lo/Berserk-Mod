using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Tiles
{
	public class MetalicBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
			DisplayName.SetDefault("Metalic Bar");
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
			item.width = 30;
			item.height = 24;
			item.value = 30000;
		}
		public override void AddRecipes()
{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AnyWood", 4);  
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);  
            recipe.AddRecipe();
}
	}
}