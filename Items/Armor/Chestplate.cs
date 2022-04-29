using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Items.Armor
{

	[AutoloadEquip(EquipType.Body)]
	public class Chestplate : ModItem
	{
		public override void SetStaticDefaults()
		 {
			DisplayName.SetDefault("Berserk Chestplate");
			Tooltip.SetDefault("5% increased melee crit, Add life magnet buff");
}
		
		
		public override void SetDefaults() 
{
			item.width = 30; 
			item.height = 25; 
			item.value = 1000000; 
			item.rare = 10; 
			item.defense = 50; 
}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == mod.ItemType("Helmet") && legs.type == mod.ItemType("Leggings");
		}
		
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Bleeding Buff, Lifeforce Buff,Thorns Buff, Max hp +500, Melee Damage bufed";
			player.AddBuff(BuffID.Bleeding, 300);
			player.AddBuff(BuffID.Lifeforce, 50);
			player.statLifeMax2 += 500;
			player.meleeDamage += 20f;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.meleeCrit += 5;
			player.moveSpeed += 2;
			player.lifeMagnet = true;
			
}


		
		public override void AddRecipes() 
{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Bar", 25);
			recipe.AddRecipeGroup("Stigmes", 20);
			recipe.AddIngredient(ItemID.SoulofNight, 50);
			recipe.AddIngredient(ItemID.SoulofMight, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
}
}
}

        
