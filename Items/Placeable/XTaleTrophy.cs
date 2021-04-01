using XTaleWorld.Tiles;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleTrophy : ModItem
	{
		public override void SetDefaults() {
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 50000;
			item.rare = 1;
			item.createTile = mod.TileType("XTaleTrophy");
			item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleGround>(), 5);
			r.AddIngredient(ModContent.ItemType<XTaleBrickBlock>(), 1);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}