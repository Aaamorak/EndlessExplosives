using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class GrenadeBee1 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Beenade Cannon");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.damage = 14;
			item.knockBack = 1f;
			item.thrown = true;
			item.shootSpeed = 6f;
			item.shoot = ProjectileID.Beenade;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 14;
			item.useTime = 14;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.rare = 2;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Beenade, 199);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
