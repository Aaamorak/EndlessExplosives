using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class BombSmoke3 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Smoke Bomb Cannon III");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 14.4f;
			item.shoot = ProjectileID.SmokeBomb;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 7;
			item.useTime = 7;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 17, 0, 0);
			item.rare = 4;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BombSmoke2", 1);
			recipe.AddIngredient(ItemID.ExplosivePowder, 99);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
