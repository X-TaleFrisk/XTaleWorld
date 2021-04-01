using XTaleWorld.Items;
using XTaleWorld.Items.Placeable;
using XTaleWorld.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items
{
	public class XFragment : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("X-Tale Shard");
			Tooltip.SetDefault("Shiny and powerful shard");
		}

		public override void SetDefaults()
		{
			item.maxStack = 99;
			item.rare = 10;
			item.value = 33500000;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleiumBar>(), 30);
			r.AddIngredient(ModContent.ItemType<XTaleSoul>(), 20);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.AddIngredient(ItemID.BrokenHeroSword, 10);
			r.SetResult(this);
			r.AddRecipe();
		}

		public override bool CanBurnInLava() 
		{
			return false;
		}
	}
}