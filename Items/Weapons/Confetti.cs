using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class Confetti : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Confetti Cannon");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 45f;
			item.shoot = ProjectileID.ConfettiGun;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 2;
			item.useTime = 2;
			item.noMelee = true;
			item.value = Item.buyPrice(5, 0, 0, 0);
			item.rare = -12;
			item.autoReuse = true;
		}
	}
}
