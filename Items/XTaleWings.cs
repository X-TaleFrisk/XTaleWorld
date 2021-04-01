using Terraria.ID;
using XTaleWorld.Tiles;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class XTaleWings : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("[c/FFA6F6:X-Tale Frisk's Wings]");
			Tooltip.SetDefault("They feel really soft and warm..");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 20;
			item.value = 130500000;
			item.rare = 5;
			item.accessory = true;
			item.defense = 15;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) 
		{
			player.wingTimeMax = 999999;
		}

		public override bool CanEquipAccessory(Player player, int slot) 
		{
            if (player.statMana == 400)             //when the player has 35+ mana he can use this item
            {
				return true;
            }
            else 
            {
				return false;                    //this make that when you have 0 mana you cant use the item
            }
        }

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) 
		{
			ascentWhenFalling = 0.32f;
			ascentWhenRising = 0.32f;
			maxCanAscendMultiplier = 2f;
			maxAscentMultiplier = 4f;
			constantAscend = 0.120f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration) 
		{
			speed = 30f;
			acceleration *= 40f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "XTaleSoul", 20);
			recipe.AddIngredient(null, "XTaleiumBar", 5);
			recipe.AddIngredient(ItemID.AngelWings, 5);
			recipe.AddTile(null, "XTaleWorkbenchTile");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}