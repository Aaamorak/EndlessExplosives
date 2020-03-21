using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class BombFish3 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Bomb Fish Cannon III");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 14.4f;
			item.shoot = ProjectileID.BombFish;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 12;
			item.useTime = 12;
			item.noMelee = true;
			item.value = Item.buyPrice(1, 15, 0, 0);
			item.rare = 4;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BombFish2", 1);
			recipe.AddIngredient(ItemID.ExplosivePowder, 99);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
