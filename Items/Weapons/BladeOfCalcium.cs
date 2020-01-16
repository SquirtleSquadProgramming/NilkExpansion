using Terraria.ID;
using Terraria.ModLoader;

namespace NilkExpansion.Items
{
	public class BladeOfCalcium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blade Of Calcium");
			Tooltip.SetDefault("A mighty blade of calcium");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
