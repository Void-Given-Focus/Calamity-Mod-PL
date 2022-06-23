using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using System.Collections.Generic;
using System;

namespace CalamityPL
{
    public class CalamityPL : Mod
    {
        public CalamityPL()
        {

        }
        public override void PostSetupContent()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod Calamity))
            {

                /*
                    ╔════════════════════════════════╗
                    ║ +-+ | Dictionary Loading | +-+ ║
                    ╚════════════════════════════════╝
                */

                ItemNameDict itemNameDictionary = new ItemNameDict();
                ItemToolTipDict itemTooltipDictionary = new ItemToolTipDict();
                NPCNameDict npcNameDictionary = new NPCNameDict();
                EffectNameDict effectNameDictionary = new EffectNameDict();
                EffectDescriptionDict effectDescriptionDictionary = new EffectDescriptionDict();

                /*
                    ╔══════════════════════════════╗
                    ║ +-+ | Item Translation | +-+ ║
                    ╚══════════════════════════════╝
                */
                    
                //ItemName Dictionary Loading:
                foreach (var itemName in itemNameDictionary.ItemName)
                {
                    Calamity.Find<ModItem>(itemName.Key).DisplayName.AddTranslation(9, itemName.Value);
                }
                
                //ItemToopTip Dictionary Loading:
                foreach (var itemTooltip in itemTooltipDictionary.ItemToolTip)
                {
                    Calamity.Find<ModItem>(itemTooltip.Key).Tooltip.AddTranslation(9, itemTooltip.Value);
                }
                /*
                    ╔════════════════════════════════╗
                    ║ +-+ | Effect Translation | +-+ ║
                    ╚════════════════════════════════╝
                */

                //EffectName Dictionary Loading:
                foreach (var effectName in effectNameDictionary.EffectName)
                {
                    Calamity.Find<ModBuff>(effectName.Key).DisplayName.AddTranslation(9, effectName.Value);
                }

                //EffectName Dictionary Loading:
                foreach (var effectDescription in effectDescriptionDictionary.EffectDescription)
                {
                    Calamity.Find<ModBuff>(effectDescription.Key).Description.AddTranslation(9, effectDescription.Value);
                }
                /*
                    ╔═════════════════════════════╗
                    ║ +-+ | NPC Translation | +-+ ║
                    ╚═════════════════════════════╝
                */

                //NPCName Dictionary Loading:
                foreach (var npcName in npcNameDictionary.NPCName)
                {
                    Calamity.Find<ModNPC>(npcName.Key).DisplayName.AddTranslation(9, npcName.Value);
                }
            }
        }
    }
}