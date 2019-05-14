using System;
using System.Collections.Generic;
using System.Text;
using Terraria.ModLoader;
using Terraria.ID;

namespace BSM.ClassLibrary1
{
    public class BaseSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boss Sword");
            Tooltip.SetDefault("This is a modded sword.");
        }
        public override void SetDefaults()
        {
            item.damage = BossSwordDamage.bossDamage;
            item.melee = true;
            item.width = 4;
            item.height = 4;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
