using XTaleWorld.Items.Armor;
using XTaleWorld.Items;
using XTaleWorld.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace XTaleWorld.Items.Accessories
{
	public class XTaleFriskPrincessDiaper : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("[c/FFA6F6:X-Tale Frisk's Princess Diaper]");
			Tooltip.SetDefault("That diapy looks so cuuute, it feels really lovely and softy-"
			+"\nThey would let you always go potty in any place cutie <3");

		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.rare = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.AddBuff(BuffID.Lovestruck, 2);
			player.AddBuff(BuffID.Swiftness, 2);
			player.AddBuff(BuffID.Heartreach, 2);
			player.AddBuff(BuffID.Panic, 2);
			player.statManaMax2 += 60;
		}
		
		public override void AddRecipes() {
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XLayer>(), 6);
			r.AddIngredient(ModContent.ItemType<XFluff>(), 40);
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
