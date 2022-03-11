# ⬜🟥 Polskie tłumaczenie do Calamity Moda


<h3> 📖 Jak pomóc w tłumaczeniu?</h3>

> **Rozwiń** by przeczytać przydługi tutorial, który wprowadzi Cię w tłumaczenie Calamity.

<details><summary>Rozwiń</summary>
<p>

&nbsp;&nbsp;&nbsp;&nbsp; <h3> **1.** Wybierz plik, który chcesz edytować.</h3>

> Tłumaczenie dzieli się na 5 głównych plików, które znajdują się w folderze **Translations**.<br>Poniżej masz tabelkę, w której opisałem który plik odpowiada za daną część tłumaczenia.

| **Plik** | **Zastosowanie** |
| --- | --- |
| `ItemNameDictionary.cs` | Tłumaczenie **nazw przedmiotów** |
| `ItemToolTipDictionary.cs` | Tłumaczenie **opisów przedmiotów** |
| `EffectNameDictionary.cs` | Tłumaczenie **nazw buffów/debuffów** |
| `EffectDescriptionDictionary.cs` | Tłumaczenie **opisów buffów/debuffów** |
| `NPCNameDictionary.cs` | Tłumaczenie **nazw NPC/bossów** |

> Jeśli wybrałeś plik, który chcesz edytować - zabieramy się do pracy!<br>

&nbsp;&nbsp;&nbsp;&nbsp; <h3> **2.** Wejdź w wybrany plik, ja na potrzeby poradnika wybrałem `Translations/NPCNameDictionary.cs` </h3>

> Jeśli nie znasz języka C#, lub ogólnie masz niskie zrozumienie języków programowania, to nic się nie martw, wszystko napisałem jak najbardziej "łopatologicznie".

> Jak widzisz, plik w którym obecnie jesteś, to powtarzająca się linia tekstu:<br>

```cs
{"ID","Tłumaczenie"},
```

> Edytując odpowiednie pola pomiędzy cudzysłowiami możesz zmieniać tłumaczenia, które pojawią się w grze. <br>
```cs
{"CoreofEleum", "Rdzeń Eleum"},
```
> Przykładowo ta linijka z `Translations/ItemNameDictionary.cs` odnosi się do Core Of Eleum, tłumacząc jego nazwę na Rdzeń Eleum. <br> Wszystko świetnie, prawda? No właśnie nie do końca. <br> Jak już pewnie zauważyłeś, każda przetłumaczona rzecz wymaga odpowiedniego ID, które mu odpowiada. <br> Tylko skąd je wziąć? <br>

> Opcji jest kilka, a najbardziej efektywna z nich, to wypakowanie plików Calamity przez https://github.com/IVogel/tModUnpacker i szukanie odpowiedniego ID metodą prób i błędów. <br> W wolnym czasie zrobię poradnik w formie filmu, gdzie wytłumaczę proces wyciągania ID z modów.

> Wracając jednak do naszego `Translations/NPCNameDictionary.cs`, weźmy przykładowo ID Aero Slime'a - czyli `AeroSlime`. <br> Najczęściej ID są identyczne jak nazwa, tylko bez spacji. Czasami jednak zdarza się, że twórca moda nazywa rzeczy dość "abstrakcyjnie". <br> Dla przykładu, w Calamity mini-boss Earth Elemental to w kodzie `Horse`

  &nbsp;&nbsp;&nbsp;&nbsp;  <h3>**3.** Wybierz opcję, która Cię interesuje.</h3>

> Masz w sumie 3 opcje. Kolorami zaznaczyłem je zgodnie z poziomem trudności.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;🟢 Poprawa obecnego tłumaczenia<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;🟡 Dodanie nowego tłumaczenia do obecnego ID<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;🔴 Dodanie nowego tłumaczenia wraz z nowym ID<br>

🟢  Wystarczy, że w wybranej linijce, która według Ciebie powinna zostać zmieniona, zamienisz pole z tłumaczeniem na swoją propozycję. <br> Na przykład:

```cs
{"ID", "Słabe Tłumaczenie"}, możesz zmienić na {"ID", "Świetne Tłumaczenie"},
```

Jest to najłatwiejsza i najszybsza opcja pomocy przy tłumaczeniu.
<br><br>
🟡  Pola, które wyglądają tak: 

```cs 
//{"ID", ""},
``` 

...to ID oczekujące na tłumaczenie. Aby dodać swoje tłumaczenie, usuń komentarz *(// na początku linijki)* i pomiędzy 2 puste cudzysłowia wpisz tłumaczenie danego przedmiotu, buffa czy NPC.

```cs
{"ID", "Twoje Fantastyczne Tłumaczenie"},
```

<br>
🔴  Metoda najtrudniejsza, wymaga od Ciebie jakichkolwiek umiejętności technicznych. <br>

1. Pobierz `tModUnpacker` i wypakuj Calamity Moda.
2. W wypakowanych folderach znajdź sprite rzeczy, którą chcesz przetłumaczyć.
3. Nazwa pliku to jednocześnie jego ID. Bywa jednak, że w plikach moda są grafiki które już dawno nie istnieją w grze.
4. Jak je wyeliminować? Oczywiście metodą prób i błędów. Jeśli podczas kompilacji tłumaczenia z nowym ID pojawiają się błędy - nie istnieje ono już w obecnej wersji Calamity.
5. Gdy masz już działające ID, możesz je dodać do głównego kodu. Na samym końcu pliku, po ostatniej linijce tłumaczeń dodaj swoje:

```cs
{"TwojeID", "Tłumaczenie"},
```

Możesz je od razu przetłumaczyć, lub zostawić z komentarzem do przetłumaczenia komuś innemu.

```cs
//{"TwojeID", ""},
```

&nbsp;&nbsp;&nbsp;&nbsp; <h3> **4.** Powiedzmy, że wybrałem opcję żółtą. Ktoś już zostawił gotowe ID w pliku, a mi zostaje przetłumaczenie go na język ojczysty</h3>

```cs
//{"AeroSlime", ""},
```

> Wpisuję moją propozycję tłumaczenia i dodaje pull request do sprawdzenia przez moderatora.

```cs
{"AeroSlime", "Wietrzny Szlam"},
```

> Po zatwierdzeniu mojego tłumaczenia wychodzi nowa wersja, w której mogę podziwiać efekty mojej ciężkiej pracy:
<br>
<img src="https://camo.githubusercontent.com/643926bcc4a69a3821ecd96d876a26c69e0ff827045f93cb22158c6cb95e2047/68747470733a2f2f692e696d6775722e636f6d2f3877516b6c63452e706e67" data-canonical-src="https://i.imgur.com/8wQklcE.png" width="50%" height="auto" />

&nbsp;&nbsp;&nbsp;&nbsp; <h3> **5.** Pełna satysfakcja z dobrze wykonanej roboty</h3>

> Gratuluję! Przeczytałeś moje przydługie wypociny, a to oznacza, że jesteś gotowy do rozpoczęcia pracy nad tłumaczeniem razem z nami! <br>
> Jeśli masz jakieś pytania, odsyłam Cię na https://discord.gg/yH7nGMhrSu

</p>
</details>

<h3> ❌ Znalazłem buga lub błąd, co robić?</h3>

> Bug w modzie możesz zgłosić w zakładce **Issues** klikając w przycisk **New Issue**. <br> Jeśli widzisz **błąd językowy** lub **logiczny** w samym tłumaczeniu, możesz poprawić go bezpośrednio w kodzie. <br> Jeśli nie wiesz jak to zrobić, przeczytaj zawartość zakładki **Jak pomóc w tłumaczeniu?**

<h3> ✅ Czy mogę użyć tego kodu do mojego tłumaczenia?</h3>

> Tak, wszystko co znajdziesz na moim GitHubie jest w 100% open-source.<br>Masz pełne prawo do edytowania, kopiowania i rozpowszechniania kodu.<br>Bierz co chcesz!
