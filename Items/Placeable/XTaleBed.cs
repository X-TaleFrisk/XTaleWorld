using XTaleWorld.Tiles;
using XTaleWorld.Items.Placeable;
using XTaleWorld.Items;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleBed : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Softy baby bed");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 6588;
			item.rare = 4;
			item.createTile = mod.TileType("XTaleBedTile");
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XFluff>(), 20);
			r.AddIngredient(ModContent.ItemType<XLayer>(), 10);
			r.AddIngredient(ModContent.ItemType<XTaleBrickBlock>(), 3);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}