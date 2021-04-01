using XTaleWorld.Dusts;
using XTaleWorld.Tiles;
using XTaleWorld.Items;
using XTaleWorld.Items.Placeable;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Tools
{
	public class XTalePickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("X-Tale Frisk's Pickaxe");
			Tooltip.SetDefault("Pulsing with your cutie presence"
				+ "\nNo block could stop you baby");
		}

		public override void SetDefaults() 
		{
			item.damage = 7250;
			item.crit = 48;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 1;
			item.useAnimation = 10;
			item.pick = 5700;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 147600000;
			item.rare = 10;
			item.useTurn = true;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(10)) {
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Flame"));
			}
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleSoul>(), 20);
			r.AddIngredient(ModContent.ItemType<XTaleiumBar>(), 20);	
			r.AddIngredient(ModContent.ItemType<XFragment>(), 1);
			r.AddIngredient(ItemID.Meowmere, 1); 	
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}