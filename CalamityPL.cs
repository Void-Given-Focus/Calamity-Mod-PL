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
                /*
                //ItemToopTip Dictionary Loading:
                try
                {
                    foreach (var itemTooltip in itemTooltipDictionary.ItemToolTip)
                    {
                        Calamity.GetItem(itemTooltip.Key).Tooltip.AddTranslation(GameCulture.CultureName.Polish, itemTooltip.Value);
                    }
                } catch (Exception e)
                {
                    Logger.Error("CalamityPL-ItemTooltipError: " + e.ToString());
                }
                */
                /*
                    ╔════════════════════════════════╗
                    ║ +-+ | Effect Translation | +-+ ║
                    ╚════════════════════════════════╝
                */

                //EffectName Dictionary Loading:
                /*
                try
                {
                    foreach (var effectName in effectNameDictionary.EffectName)
                    {
                        Calamity.GetBuff(effectName.Key).DisplayName.AddTranslation(GameCulture.CultureName.Polish, effectName.Value);
                    }
                } catch (Exception e)
                {
                    Logger.Error("CalamityPL-EffectNameError: " + e.ToString());
                }

                //EffectName Dictionary Loading:
                try
                {
                    foreach (var effectDescription in effectDescriptionDictionary.EffectDescription)
                    {
                        Calamity.GetBuff(effectDescription.Key).Description.AddTranslation(GameCulture.CultureName.Polish, effectDescription.Value);
                    }
                } catch (Exception e)
                {
                    Logger.Error("CalamityPL-EffectDescriptionError: " + e.ToString());
                }
                */
                /*
                    ╔═════════════════════════════╗
                    ║ +-+ | NPC Translation | +-+ ║
                    ╚═════════════════════════════╝
                */
                /*
                try
                {
                    foreach (var npcName in npcNameDictionary.NPCName)
                    {
                        Calamity.GetNPC(npcName.Key).DisplayName.AddTranslation(GameCulture.CultureName.Polish, npcName.Value);
                    }
                } catch (Exception e)
                {
                    Logger.Error("CalamityPL-NPCNameError: " + e.ToString());
                }
                */
            }
        }
    }
}
