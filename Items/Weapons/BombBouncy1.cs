using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class BombBouncy1 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Bouncy Bomb Cannon");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 5f;
			item.shoot = ProjectileID.BouncyBomb;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 24;
			item.useTime = 24;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 2;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BouncyBomb, 199);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
