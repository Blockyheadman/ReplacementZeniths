using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReplacementZeniths.Items
{
    public class TerraMere : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TerraMere");
            Tooltip.SetDefault("The End Goal of 1.3");
        }

        public override void SetDefaults()
        {
            item.damage = 315;
            item.melee = true;
            item.width = 46;
            item.height = 54;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 7.5f;
            item.value = Item.buyPrice(0, 40, 0, 0);
            item.shopCustomPrice = Item.sellPrice(0, 20, 0, 0);
            item.rare = ItemRarityID.Purple;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileID.Meowmere;
            item.shootSpeed = 10f;
            item.mana = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Meowmere, 1);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
