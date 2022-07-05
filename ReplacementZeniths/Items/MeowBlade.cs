using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReplacementZeniths.Items
{
    public class MeowBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MeowBlade");
            Tooltip.SetDefault("The Other End Goal of 1.3");
        }

        public override void SetDefaults()
        {
            item.damage = 315;
            item.melee = true;
            item.width = 50;
            item.height = 58;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 7.5f;
            item.value = Item.buyPrice(0, 40, 0, 0);
            item.shopCustomPrice = Item.sellPrice(0, 20, 0, 0);
            item.rare = ItemRarityID.Purple;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileID.TerraBeam;
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
