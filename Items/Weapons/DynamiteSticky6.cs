﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EndlessExplosives.Items.Weapons
{
	class DynamiteSticky6 : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fast Endless Sticky Dynamite Cannon");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.shoot = ProjectileID.StickyDynamite;
			item.width = 32;
			item.height = 22;
			item.maxStack = 1;
			item.prefix = 0;
			item.UseSound = SoundID.Item11;
			item.useAnimation = 5;
			item.useTime = 5;
			item.noMelee = true;
			item.value = Item.buyPrice(2, 30, 0, 0);
			item.rare = 10;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DynamiteSticky1", 1);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
