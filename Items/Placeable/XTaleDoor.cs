using XTaleWorld.Tiles;
using XTaleWorld.Items;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleDoor : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("X-Tale Door");
			Tooltip.SetDefault("The entrance to the beautiful world");
		}

		public override void SetDefaults() {
			item.width = 14;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 4666334;
			item.rare = 4;
			item.createTile = mod.TileType("XTaleDoorClosed");
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XFluff>(), 3);
			r.AddIngredient(ModContent.ItemType<XLayer>(), 2);
			r.AddIngredient(ModContent.ItemType<XTaleBrickBlock>(), 5);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}