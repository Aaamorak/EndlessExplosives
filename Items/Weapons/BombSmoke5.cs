using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class BombSmoke5 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Smoke Bomb Cannon V");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 25f;
			item.shoot = ProjectileID.SmokeBomb;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 2;
			item.useTime = 2;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 97, 0, 0);
			item.rare = 10;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BombSmoke4", 1);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
