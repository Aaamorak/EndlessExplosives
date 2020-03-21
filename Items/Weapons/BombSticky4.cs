using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class BombSticky4 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Sticky Bomb Cannon IV");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 25f;
			item.shoot = ProjectileID.StickyBomb;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 6;
			item.useTime = 6;
			item.noMelee = true;
			item.value = Item.buyPrice(1, 15, 0, 0);
			item.rare = 7;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BombSticky3", 1);
			recipe.AddIngredient(ItemID.RocketIII, 4995);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
