﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class GrenadeBouncy2 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Bouncy Grenade Cannon II");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.damage = 65;
			item.knockBack = 8f;
			item.thrown = true;
			item.shootSpeed = 6.5f;
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
			item.rare = 3;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GrenadeBouncy1", 1);
			recipe.AddIngredient(ItemID.FeralClaws, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
