using System;
using System.Collections.Generic;
using System.Text;
using Terraria.ModLoader;
using Terraria.GameContent;
using Terraria;

namespace BSM
{
    
    public class BossSwordDamage
    {
        public static int bossDamage = 10;
        public static int X = 10;

        public void Scaling()
        {
#pragma warning disable CS0665 // Assignment in conditional expression is always constant
            if (NPC.downedBoss1 = true)
#pragma warning restore CS0665 // Assignment in conditional expression is always constant
            {
                bossDamage += 10;
            }
        }


    }
}
