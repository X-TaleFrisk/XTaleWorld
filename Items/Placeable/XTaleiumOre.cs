using XTaleWorld.Tiles;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleiumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("X-Taleium Ore");
			Tooltip.SetDefault("It's the highest treasure what could be found. Legends says that code of XEvent have merged with your world."
				+ "\nIt has been made with XFrisk's Overwrite power to make strongest weapons and tools in the multiverse.");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 408;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 6;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.width = 12;
			item.height = 12;
			item.value = 2500000;
			item.rare = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("XTaleiumOreTile");
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ItemID.LunarOre, 3);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
