using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class GrenadeSticky1 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Sticky Grenade Cannon");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.damage = 60;
			item.knockBack = 8f;
			item.thrown = true;
			item.shootSpeed = 5.5f;
			item.shoot = ProjectileID.StickyGrenade;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 44;
			item.useTime = 44;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 7, 50, 0);
			item.rare = 2;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StickyGrenade, 199);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
