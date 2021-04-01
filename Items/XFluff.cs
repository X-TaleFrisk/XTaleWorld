using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items
{
	public class XFluff : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("X-Tale Fluff");
			Tooltip.SetDefault("The most absorby material you can find");
		}

		public override void SetDefaults()
		{
			item.maxStack = 99;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ItemID.Cloud, 5);
			r.AddTile(TileID.WorkBenches);
			r.SetResult(this);
			r.AddRecipe();
		}

		public override bool CanBurnInLava() 
		{
			return true;
		}
	}
}