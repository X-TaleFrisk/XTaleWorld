using XTaleWorld.Items.Placeable;
using XTaleWorld.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items
{
	public class XTaleSoul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("X-Tale Soul");
			Tooltip.SetDefault("'The essence of multiverse'");
			// ticksperframe, frameCount
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.AnimatesAsSoul[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		// The following 2 methods are purely to show off these 2 hooks. Don't use them in your own code.
		public override void GrabRange(Player player, ref int grabRange) 
		{
			grabRange *= 3;
		}

		public override void SetDefaults()
		{
			item.maxStack = 30;
			item.rare = 9;
			item.value = 5500000;
		}

		public override bool GrabStyle(Player player) 
		{
			Vector2 vectorItemToPlayer = player.Center - item.Center;
			Vector2 movement = -vectorItemToPlayer.SafeNormalize(default(Vector2)) * 0.1f;
			item.velocity = item.velocity + movement;
			item.velocity = Collision.TileCollision(item.position, item.velocity, item.width, item.height);
			return true;
		}

		public override void PostUpdate() 
		{
			Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleiumOre>(), 2);
			r.AddIngredient(ItemID.SoulofNight, 2);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}