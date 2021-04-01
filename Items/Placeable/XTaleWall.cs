using XTaleWorld.Tiles;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleWall : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("X-Tale Wall");
			Tooltip.SetDefault("It feel shiny and fresh");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.rare = 5;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("XTaleWall");
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleBrickBlock>(), 1);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this, 2);
			r.AddRecipe();
		}
	}
}