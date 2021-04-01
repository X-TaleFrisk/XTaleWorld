using XTaleWorld.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class XTaleGround : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("X-Tale Ground");
			Tooltip.SetDefault("The ground of the X-Tale Universe.");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.value = 40000;
			item.useAnimation = 15;
			item.rare = 3;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("XTaleGroundTile"); //put your CustomBlock Tile name
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleSoul>(), 1);
			r.AddIngredient(ItemID.DirtBlock, 50);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this, 50);
			r.AddRecipe();
		}
	}
}