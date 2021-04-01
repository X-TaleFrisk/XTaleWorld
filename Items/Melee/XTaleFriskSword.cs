using XTaleWorld.Items;
using XTaleWorld.Items.Placeable;
using XTaleWorld.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XTaleWorld.Items.Melee
{
	public class XTaleFriskSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("X-Tale Frisk's Sword");
			Tooltip.SetDefault("Pulsing with your cutie presence"
				+ "\nFills you with love and care");
		}

        public override bool CanUseItem(Player player)
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

		public override void SetDefaults()
		{
			item.damage = 14700; 
			item.crit = 72;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 273500000;
			item.rare = 10;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("XTaleSwordProjectile");
			item.shootSpeed = 20f;
		}
		
		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<XTaleSoul>(), 20);
			r.AddIngredient(ModContent.ItemType<XTaleiumBar>(), 30);
			r.AddIngredient(ModContent.ItemType<XFragment>(), 2);
			r.AddIngredient(ItemID.Meowmere, 10); 	
			r.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r.SetResult(this);
			r.AddRecipe();
		}
    }
}