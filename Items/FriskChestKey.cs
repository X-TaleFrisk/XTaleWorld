using XTaleWorld.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XTaleWorld.Items
{
	class FriskChestKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[c/FFA6F6:X-Tale Frisk's Chest Key]");
			Tooltip.SetDefault("Unlock your best baby toys and diaper supplies, and a secret..");
		}

		public override void SetDefaults() {
			//item.CloneDefaults(ItemID.GoldenKey);
			item.width = 14;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 5;
			item.accessory = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 40;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleSoul>(), 5);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
