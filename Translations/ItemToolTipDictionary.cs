using System.Collections.Generic;

namespace CalamityPL
{
    public class ItemToolTipDict
    {
        public Dictionary<string, string> ItemToolTip { get; } = new Dictionary<string, string>()
        {
            { "Abaddon", "Redukuje otrzymywane obrażenia spowodowane przez Siarczyste Płomienie, a także nadaje niewrażliwość na efekty Palącej Lawy" },
            /* Tłumaczenia tooltipów na razie są wyłączone. Trzeba poprawić wartości, które się zmieniły po update Calamity.
                                ======================================================
            {"AbyssalAmulet", "Ataki nakładają na przeciwników osłabienie Miażdżącej Otchłani\nPodczas przebywania w otchłani zyskujesz dodatkowo 10% maksymalnego zdrowia"},
            {"AbyssalDivingGear", "Redukuje obrażenia spowodowane ciśnieniem otchłani podczas duszenia się\nNiweluje efekt krwawienia w otchłani\nZapewnia możliwość pływania i ogromnie zwiększa długość oddychania pod wodą\nZapewnia światło pod wodą oraz zwiększa mobilność na lodzie\nZapewnia umiarkowane światło w otchłani\nOgromnie zmniejsza utratę powietrza w otchłani"},
            {"AbyssalDivingSuit", "Zamienia posiadacza w uzbrojonego nurka\nPrędkość poruszania zwiększona w wodzie oraz zmniejszona poza nią\nPłyty zbroi redukują obrażenia o 15%\nPłyty te otrzymają obrażenia tylko gdy otrzymane obrażenia przekroczą 50\nGdy zbroja otrzyma zbyt wiele obrażeń jej płyty będą regenerowały się przez 3 minuty\nRedukuje obrażenia spowodowane ciśnieniem otchłani podczas duszenia się\nNiweluje efekt krwawienia we wszystkich warstwach otchłani za wyjątkiem najgłębszej\nZapewnia możliwość pływania i ogromnie zwiększa długość oddychania pod wodą\nZapewnia światło pod wodą oraz zwiększa mobilność na lodzie\nZapewnia umiarkowane światło w otchłani\nOgromnie zmniejsza utratę powietrza w otchłani\nRedukuje możliwość stworzeń do wykrycia cię w otchłani\nRedukuje efekt obniżenia obrony którą otchłań powoduje\nPozwala na szybsze zanurzanie się w cieczach"},
            {"AbyssalMirror", "Światło nie dociera do głębin oceanu\nZnacząco zmniejsza agresywność przeciwników nawet w otchłani\nSkrytość generuje się 30% szybciej stojąc w miejscu i 20% szybciej w ruchu\nZapewnia małą szansę na uniknięcie ataku, wytwarzając chmurę płynu lumenylowego, raniącego i ogłuszającego pobliskich przeciwników\nUniknięcie ataku zapewnia większą skrytość\nUniknięcie ataku może nastąpić co 20 sekund"},
            {"AeroStone", "Jeden ze starożytnych reliktów\nZwiększa prędkość poruszania o 10%, prędkość skoku o 20% oraz zadawane obrażenia o 3%"},
            {"Affliction", "Zwiększa regenerację zdrowia twoją i twojej drużyny o 1\n10% zwiększone maksymalne zdrowie, 7% zwiększona redukcja obrażeń, obrona zwiększona o 20 oraz 10% zwiększone obrażenia"},
            {"AlchemicalFlask", "Wszystkie ataki wstrzykują przeciwnikom osłabienie plagi\nZmniejsza otrzymywane obrażenia spowodowane osłabieniem plagi\nNiweluje efekt oślepienia powodowany przez plagę\nPo trafieniu przeciwnika pociski rodzą węszycieli plagi"},
            {"AlluringBait", "Moc wędkowania zwiększona o 30 w dzień, o 45 w nocy i 60 podczas zaćmienia\nNiesamowicie zwiększa szansę wyłowienia ryby alchemicznej"},
            {"AmalgamatedBrain", "10% zwiększone obrażenia\nOtrzymanie obrażeń powoduje deszcz cienia i dezorientuje twoich przeciwników"},
            {"AmbrosialAmpoule", "25% zwiększona prędkość kopania\nEmitujesz światło\n5% zwiększona redukcja obrażeń i zwiększona regeneracja zdrowia\nOdporność na zatrucie, zamrożenie, ochłodzenie, odmrożenie i jad\nRegeneracja zdrowia jak po wskoczeniu do miodu, bez kary za prędkość poruszania\nWiększość pszczoło/szerszenio-podobnych przeciwników zadaje 75% obrażeń"},
            {"AmidiasPendant", "Z nieba losowo spadają odłamki pryzmatu które mogą chwilowo ogłuszyć przeciwników"},
            {"AmidiasSpark", "Otrzymanie obrażeń powoduje eksplozję iskr\nIskry zadają dodatkowe obrażenia w Hardmode"},
            {"AncientFossil", "Zwiększa prędkość kopania o 15% będąc pod ziemią"},
            {"AnechoicPlating", "Redukuje możliwość stworzeń do wykrycia cię w otchłani\nRedukuje efekt obniżenia obrony którą otchłań powoduje "},
            {"AngelTreads", "Ekstremalna prędkość!\n36% zwiększone przyspieszenie podczas biegania\nZwiększony czas lotu\nZwiększona mobilność na lodzie\nMożliwość chodzenia po wodzie i lawie\nChwilowa odporność na lawę"},
            {"AquaticEmblem", "Większość przeciwników z oceanu staje się przyjazna oraz zapewnia oddychanie pod wodą\nBycie pod wodą powoli zwiększa obronę lecz zmniejsza prędkość poruszania\nEfekty te powoli zanikają po wyjściu z wody\nEfekt maksymalnie zwiększy obronę o 30, i redukcję prędkości poruszania się do 5%\nZapewnia niewielką ilość światła w otchłani\nUmiarkowanie redukuje utratę oddechu w otchłani"},
            {"SirensHeart", "Zamienia posiadacza w żywiołaka wody\nOtrzymujesz specjalne wzmocnienie po wejściu do wody\nOgromnie redukuje utratę oddechu i zapewnia niewielkie światło w otchłani\nPo otrzymaniu obrażeń zamrażasz przeciwnika\nNosisz na sobie lodową powłokę absorbującą 20% otrzymanych obrażeń, która kruszy się i regeneruje przez następne 30 sekund\nFajnie, od teraz możesz pływać!\nWiększość efektów jest aktywna dopiero po pokonaniu Szkieletrona"},
            {"ArcanumoftheVoid", "Masz 5% szans na odbicie pocisków\nZostaniesz uleczony o obrażenia tego pocisku"},
            {"ArchaicPowder", "20% zwiększona prędkość kopania, 7% zwiększona redukcja obrażeń i obrona większa o 3 w podziemiach i w piekle"},
            {"DaedalusEmblem", "10% zwiększone obrażenia dystansowe, 5% zwiększona szansa na trafienie krytyczne oraz 20% szans na nieużycie amunicji\nObrona większa o 5, regeneracja zdrowia większa o 2 oraz 15% zwiększona prędkość kopania"},
            {"AsgardsValor", "Zapewnia odporność na odrzut i bloki podpalające\nZapewnia odporność na większość osłabień i redukuje obrażenia spowodowane osłabieniem Siarkowych Płomieni\n10% redukcji obrażeń po zanurzeniu w cieczach\n+20 do maksymalnego zdrowia\nPozwala na wykonanie uniku świętego ognia który można wykorzystać do staranowania przeciwników"},
            {"AsgardianAegis", "Zapewnia odporność na odrzut i bloki podpalające\nZapewnia odporność na większość osłabień\n+40 do maksymalnego zdrowia\nPozwala na wykonanie uniku mistrzowskiego świętego ognia\nMożna go wykorzystać do staranowania przeciwników\nNaciśnij [ Elysian Guard Toggle ] aby aktywować wzmocnienie obrażeń, szansy na trafienie krytyczne i obrony\nAktywacja tego wzmocnienia spowalnia prędkość poruszania i zwiększa agresywność przeciwników\n10% redukcji obrażeń po zanurzeniu w cieczach"},
            {"AstralArcanum", "Otrzymanie obrażeń powoduje spadanie gwiazd z nieba\nZapewnia odporność przeciwko gwiezdnej zarazie\nMasz 5% na odbicie nadchodzącego pocisków\nPo odbiciu zostaniesz uleczony o obrażenia tego pocisku\nPrzyspiesza regenerację zdrowia pod wpływem raniących osłabień\nDopóki te osłabienia trwają otrzymujesz 20 pkt. obrony\nNaciśnij [UI Toggle] aby otworzyć UI teleportacji"},
            {"AstralBulwark", "Otrzymanie obrażeń powoduje spadanie gwiazd z nieba\nZapewnia odporność przeciwko gwiezdnej zarazie"},
            {"AureateWings", "Prędkość Macha bez hamulców!\nPrędkość pozioma: 8\nMnożnik przyspieszenia: 1.5\nDobra wysokość pionowa\n15% zwiększona prędkość poruszania się w zbroi Zbójcy"},
            */
        };
    }
}
