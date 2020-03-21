﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class GrenadeBouncy3 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Bouncy Grenade Cannon III");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.damage = 65;
			item.knockBack = 8f;
			item.thrown = true;
			item.shootSpeed = 15.6f;
			item.shoot = ProjectileID.BouncyGrenade;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 19;
			item.useTime = 19;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.rare = 4;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GrenadeBouncy2", 1);
			recipe.AddIngredient(ItemID.ExplosivePowder, 99);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
