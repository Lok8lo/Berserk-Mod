using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.Tiles
{
	public class MetalicOre : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 700; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 975; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			mineResist = 4f;
			minPick = 210;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("MetalicOre");
			AddMapEntry(new Color(152, 171, 198), name);

			dustType = 84;
			drop = ModContent.ItemType<Items.Placeable.MetalicOre>();
			soundType = SoundID.Tink;
			soundStyle = 1;
			//mineResist = 4f;
			//minPick = 200;
		}
	}
}