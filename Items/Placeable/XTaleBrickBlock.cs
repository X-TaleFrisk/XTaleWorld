using XTaleWorld.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace XTaleWorld.Items.Placeable
{
    public class XTaleBrickBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("X-Tale Block");
            Tooltip.SetDefault("Very valuable, one of strongest possible materials.");
            ItemID.Sets.SortingPriorityMaterials[item.type] = 408;
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
			item.value = 70000;
            item.useAnimation = 15;
            item.rare = 5;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("XTaleTileBrickBlock"); //put your CustomBlock Tile name
        }

        public override void AddRecipes()
		{
            ModRecipe r1 = new ModRecipe(mod);
			r1.AddIngredient(ItemID.GrayBrick, 50);
			r1.AddIngredient(ModContent.ItemType<XTaleSoul>(), 1);
			r1.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r1.SetResult(this, 50);
			r1.AddRecipe();

			ModRecipe r2 = new ModRecipe(mod);
			r2.AddIngredient(ModContent.ItemType<XTaleWall>(), 2);
			r2.AddTile(ModContent.TileType<XTaleWorkbenchTile>());
			r2.SetResult(this);
			r2.AddRecipe();
		}
    }
}
