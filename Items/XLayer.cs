using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items
{
	public class XLayer : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("X-Tale Layer");
			Tooltip.SetDefault("The softest layers in the world");
		}

		public override void SetDefaults()
		{
			item.maxStack = 99;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ItemID.Silk, 3);
			r.AddIngredient(ItemID.Cloud, 40);
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