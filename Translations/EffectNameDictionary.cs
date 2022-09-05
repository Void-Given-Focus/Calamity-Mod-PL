using System.Collections.Generic;

namespace CalamityPL
{
    public class EffectNameDict
    {
        public Dictionary<string, string> EffectName { get; } = new Dictionary<string, string>()
        {
            /* 
                Szybki tutorial tłumaczenia dla nietechnicznych:
                        { "ID", "Tłumaczenie" }, 
            */
            {"AlcoholPoisoning", "Zatrucie alkoholowe"},
            {"BloodyMaryBuff", "Krwawa Mary"},
            {"CaribbeanRumBuff", "Rum Karaibski"},
            {"CinnamonRollBuff", "Koktajl z cynamonem"},
            {"EverclearBuff", "Everclear"},
            {"EvergreenGinBuff", "Gin Evergreen"},
            {"FabsolVodkaBuff", "Fabsolówka"},
            {"FireballBuff", "Fireball"},
            {"MargaritaBuff", "Margarita"},
            {"MoonshineBuff", "Bimber"},
            {"MoscowMuleBuff", "Muł Moskiewski"},
            {"RedWineBuff", "Wino Czerwone"},
            {"RumBuff", "Rum"},
            {"ScrewdriverBuff", "Screwdriver"},
            {"StarBeamRyeBuff", "Gwiezdne Whisky"},
            {"TequilaBuff", "Tequila"},
            {"Trippy", "Halucynacje"},
            {"VodkaBuff", "Wódka"},
            {"WhiskeyBuff", "Whisky"},
            {"WhiteWineBuff", "Wino Białe"},
        };
    }
}
