﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class Dynamite4 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Endless Dynamite Cannon IV");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 20f;
			item.shoot = ProjectileID.Dynamite;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 10;
			item.useTime = 10;
			item.noMelee = true;
			item.value = Item.buyPrice(2, 65, 0, 0);
			item.rare = 7;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Dynamite3", 1);
			recipe.AddIngredient(ItemID.RocketIII, 4995);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
