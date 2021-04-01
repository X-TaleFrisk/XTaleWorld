using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleWorkbench : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("X-Tale Workbench"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Pulsing with energy of multiverse.");
		}

		public override void SetDefaults() 
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 100000;
			item.rare = 9;
			item.createTile = mod.TileType("XTaleWorkbenchTile");
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ItemID.WorkBench);
			r.AddIngredient(ItemID.SoulofNight, 5);
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}