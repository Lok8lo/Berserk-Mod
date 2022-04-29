using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Items.Leggings
{

	[AutoloadEquip(EquipType.Legs)]
	public class Leggings : ModItem
	{
		public override void SetStaticDefaults()
		 {
			DisplayName.SetDefault("Berserk Leggings");
			Tooltip.SetDefault("5% increased melee crit, 5% increased move speed");
}
		
		
		public override void SetDefaults() 
{
			item.width = 26; 
			item.height = 22; 
			item.value = 1000000; 
			item.rare = 10; 
			item.defense = 40; 
}
		public override bool IsArmorSet(Item head, Item body, Item legs)
{
			return body.type == mod.ItemType("Chestplate") && head.type == mod.ItemType("Helmet");
}
		
		public override void UpdateArmorSet(Player player)
{
			player.AddBuff(BuffID.Thorns, 300);
}

		public override void UpdateEquip(Player player) 
		{
			player.meleeCrit += 5;
			player.moveSpeed += 5;
}

		
		public override void AddRecipes() 
{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Bar", 20);
			recipe.AddRecipeGroup("Stigmes", 17);
			recipe.AddIngredient(ItemID.SoulofNight, 50);
			recipe.AddIngredient(ItemID.SoulofSight, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

}
}