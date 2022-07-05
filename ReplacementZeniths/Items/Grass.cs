using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReplacementZeniths.Items
{
    public class Grass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Grass"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It's just grass. It doesn't help much.");
		}

		public override void SetDefaults() 
		{
			item.width = 12;
			item.height = 12;
			item.rare = ItemRarityID.Gray;
			//A value of 5 is one copper. 500 is one silver. 50,000 one gold. 5,000,000 is one platinum.
			item.shopCustomPrice = Item.sellPrice(0, 0, 0, 7);
			item.value = Item.buyPrice(0, 0, 0, 15);
			item.maxStack = 999;
			item.autoReuse = true;
			item.createTile = TileID.Dirt; // mod.TileType("TileName") for modded tiles
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.noMelee = true;
			item.UseSound = SoundID.Item1;
			item.consumable = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(ItemID.GrassSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}