using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BerserkMod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Apostol : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Apostol");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 34;
			npc.height = 40;
			npc.damage = 200;
			npc.defense = 30;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			int x = spawnInfo.spawnTileX;
     		int y = spawnInfo.spawnTileY;
   		    int tile = (int)Main.tile[x, y].type;
    		return (tile == 147) && !Main.bloodMoon && spawnInfo.player.ZoneSnow && spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.1f : 0f;
		}

		public override void NPCLoot()
        {
            int amountToDrop = Main.rand.Next(3,10);
                    if(Main.rand.Next(60) == 0)
        
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Stigma"));
            }
		}
	}
