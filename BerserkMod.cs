using Terraria;
using Terraria.ID;
using BerserkMod.Items;
using Terraria.ModLoader;

namespace BerserkMod
{
	public class BerserkMod : Mod
	{
public override void AddRecipeGroups()
        {      

            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + "Any wood", new int[] //Any Wood - название группы
           {
                ItemType("MetalicOre"),  //Добавление модовых предметов 
                ItemID.Wood,    //Добавление ванильных предметов
                ItemID.RichMahogany,
                ItemID.Shadewood,
                ItemID.Ebonwood,
                ItemID.Pearlwood,
                ItemID.SpookyWood,
                ItemID.DynastyWood,
                ItemID.BorealWood,
                ItemID.PalmWood,
            });
            RecipeGroup.RegisterGroup("AnyWood", group); //тут Any wood (в рифму) это уже обозначение группы в коде
        	RecipeGroup grop = new RecipeGroup(() => Lang.misc[37] + "Bar", new int[]
        	{
        		ItemType("MetalicBar"),
        		ItemID.IronBar,
        	});
        	RecipeGroup.RegisterGroup("Bar", grop);
        	RecipeGroup gr = new RecipeGroup(() => Lang.misc[37] + "Stigmes", new int[] //Any Wood - название группы
           {
                ItemType("Stigma"),  //Добавление модовых предметов 
               
            });
            RecipeGroup.RegisterGroup("Stigmes", gr);
        }
	}
}