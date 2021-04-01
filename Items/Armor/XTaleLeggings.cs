using XTaleWorld.Tiles;
using XTaleWorld.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class XTaleLeggings : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("[c/FFA6F6:X-Tale Frisk's Booties]");
			Tooltip.SetDefault("Cutie softy booties"
				+ "\nInside is softy padding making you feel lovely");
		}
		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.rare = 5;
			item.defense = 60;
			item.value = 64500000;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleSoul>(), 10);
			r.AddIngredient(ModContent.ItemType<XTaleiumBar>(), 15);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}