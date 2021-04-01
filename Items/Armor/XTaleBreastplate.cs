using XTaleWorld.Tiles;
using XTaleWorld.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class XTaleBreastplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("[c/FFA6F6:X-Tale Frisk's Little Dress]");
			Tooltip.SetDefault("Inside is really soft and lovely"
				+ "\nThe dress contains pink softy mittens");
		}

		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 18;
			item.rare = 5;
			item.defense = 80;
			item.value = 64500000;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.5f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemType<XTaleHelmet>() && legs.type == ItemType<XTaleLeggings>();
		}

		public override void UpdateArmorSet(Player player)
        {
			player.meleeDamage -= -0.5f;
			player.statManaMax2 += 100;
			player.moveSpeed += 0.9f;
			player.AddBuff(BuffID.Shine, 1);
			player.AddBuff(BuffID.Dangersense, 1);
			player.AddBuff(BuffID.NightOwl, 1);
			player.AddBuff(BuffID.Hunter, 1);
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