using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Items.Helmet
{

	[AutoloadEquip(EquipType.Head)]
	public class Helmet : ModItem
	{
		public override void SetStaticDefaults()
		 {
			DisplayName.SetDefault("Berserk Helmet");
			Tooltip.SetDefault("5% increased melee crit, Add life force buff");
		}
		
		public override void SetDefaults() 
{
			item.width = 40; 
			item.height = 40; 
			item.value = 1000000; 
			item.rare = 10; 
			item.defense = 45; 
}

		
		public override void UpdateEquip(Player player) 
		{
			player.meleeCrit += 5;
			player.moveSpeed += 2;
}
		public override void UpdateArmorSet(Player player)
{
			player.meleeDamage += 30f;
			player.moveSpeed += 10;
			player.AddBuff(BuffID.Lifeforce, 15);
}


		
		public override void AddRecipes() 
{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Bar", 20);
			recipe.AddRecipeGroup("Stigmes", 15);
			recipe.AddIngredient(ItemID.SoulofNight, 50);
			recipe.AddIngredient(ItemID.SoulofFright, 35);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

}
}

