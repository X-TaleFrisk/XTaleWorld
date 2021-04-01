using XTaleWorld.Items;
using XTaleWorld.Items.Placeable;
using XTaleWorld.Dusts;
using XTaleWorld.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Tools
{
	public class XTaleOveraxe : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("X-Tale Frisk's Overaxe");
			Tooltip.SetDefault("It having soft holding space and is light"
				+ "\nBaby size hammer and axe");
		}

		public override void SetDefaults() {
			item.damage = 8370;
			item.crit = 48;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 1;
			item.useAnimation = 10;
			item.axe = 2500;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 5700;      //How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 125500000;
			item.rare = 10;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.useTurn = true;
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
