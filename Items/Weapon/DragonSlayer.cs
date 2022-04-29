
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Items.Weapon
{
	public class DragonSlayer : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("DragonSlayer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Dragon Slayer is the massive sword Guts has wielded as his signature weapon since surviving the Eclipse.");
			DisplayName.SetDefault("Dragon Slayer");
		}

		public override void SetDefaults()
		{
			item.damage = 550;
			item.melee = true;
			item.width = 120;
			item.height = 176;
			item.useTime = 50;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 100000;
			item.rare = 10;
			item.crit = 20;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Bar", 10);  
            recipe.AddRecipeGroup("Stigmes", 12);
            recipe.AddIngredient(ItemID.SoulofFright, 25);
            recipe.AddIngredient(ItemID.SoulofNight, 50);
            recipe.AddTile(TileID.MythrilAnvil);   
            recipe.SetResult(this);  
            recipe.AddRecipe();
}
}
}