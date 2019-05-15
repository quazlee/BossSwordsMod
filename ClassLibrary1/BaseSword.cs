using System;
using System.Collections.Generic;
using System.Text;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

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
            item.damage = 10;
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

        public override bool CanUseItem(Player player)
        {
            if (NPC.downedSlimeKing)
            {
                item.damage = 15;
            }
            if (NPC.downedBoss1)
            {
                item.damage = 20;
            }
            if (NPC.downedBoss2)
            {
                item.damage = 27;
            }
            if (NPC.downedQueenBee)
            {
                item.damage = 34;
            }
            if (NPC.downedBoss3)
            {
                item.damage = 40;
            }
            if (Main.hardMode)
            {
                item.damage = 48;
            }
            if (NPC.downedMechBoss1)
            {
                item.damage += 5;
            }
            if (NPC.downedMechBoss2)
            {
                item.damage += 5;
            }
            if (NPC.downedMechBoss3)
            {
                item.damage += 5;
            }
            return true;
        }


    }
}
