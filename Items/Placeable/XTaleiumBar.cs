using XTaleWorld.Tiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleiumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("X-Taleium Bar");
			Tooltip.SetDefault("It's very shiny, pulsing with essence of multiverse.");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 408;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 8500000;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.rare = 10;
			item.consumable = true;
			item.createTile = mod.TileType("XTaleiumBarTile");
			item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleiumOre>(), 4);
			r.AddIngredient(ItemID.SoulofNight, 1);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
