using XTaleWorld.Tiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
	public class FriskChest : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("X-Tale Frisk's Chest");
			Tooltip.SetDefault("Most safe place for your cutie baby plushies, baby clothes, toys"
				+"\nAnd some of your softy diapers");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.rare = 7;
			item.createTile = mod.TileType("FriskChestTile");
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleGround>(), 5);
			r.AddIngredient(ModContent.ItemType<XTaleiumBar>(), 1);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}