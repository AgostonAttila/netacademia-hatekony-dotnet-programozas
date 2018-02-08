# Netacademia Hatékony programozás .NET-ben tanfolyam

https://netacademia.hu/Tanfolyam/hatekony-programozas-net-ben

Sokan fejlesztenek Web alapú alkalmazásokat. De kevesen tudják, hogy a modern alkalmazások és munkamódszerek használatával mennyi idõt takaríthatnának meg. Ha érdekel mi az Nmp, Grunt, Git, Less, AngularJS, NodeJS, MongoDB, akkor ez a Te tanfolyamod. Egy élõ rendszert fogunk együtt készíteni ezek használatával, az alapoktól. Minden lépést végigveszünk, a fejlesztõi környezet felállításától a kész alkalmazásig. A tanfolyam célja a modern fejlesztõeszközök megismerése. Ezek hatékony használata, beállítása, testreszabása. Saját automatizált környezet felállítása. Versenyképes tudás a legkeresettebb technológiák területén.


## Fejlesztési környezeteink áttekintése, WPF, Silverlight, MVC gyorstalpaló
Ezen a napon megalapozzuk Windows-alkalmazásfejlesztési képességeinket. Megismerkedünk a Zûrlapok felépítésével és használatával, a XAML-leírónyelvvel és az adatkötés (DataBind) mûvészetével.
Mi fán terem a SilverLight? Ez most web, vagy desktop? Az aszinkronitás gyönyörei. Együttmûködés a futtatókörnyezettel: JavaScripttel a SilverLight ellen, SilverLighttal a HTML ellen. Futtatás böngészõn kívül.
MVC-helyszínelõk. Hogyan kezdjünk neki egy MVC-webalkalmazásnak? A Model, View, Controller szentháromság. Miért pont /Home/Index? Támaszkodjuk a Model Binderre!
Halál a macskakörömre!

## Probléma halmazkezelés. Megoldás: LINQ, avagy hogyan kezeljünk „enumerátumokat”?
A mai modern adatelérés alapja a LINQ, amely – nevébõl fakadóan – a C#-nyelvbe integrált lekérdezési nyelv. Egyáltalán nem adatbázisfüggõ, bármit le lehet kérdezni vele, ami IENumerable<>. De mi a csuda az az IENumerable? Megismerendõ LINQ-kulcsszavak: select, from, where, orderby, group, any, single, first, last, skip, take.
Halál a macskakörömre!

## Probléma: adattárolás. Megoldás: LINQ providerek, Code First
SQL-adatbázis létrehozása, vagy csatlakozás meglévõhöz, esetleg az SQL adatbázis figyelmen kívül hagyása :) DataContext és DataSet objektumok. Egy-egy, egy-több, több-több táblakapcsolat kezelése. Lekérdezések, beszúrás, módosítás, törlés.
Figyelem! Felkészülés az Azure-ra: Azure regisztráció!
Halál a macskakörömre!

## Probléma: adathelyesség-ellenõrzés. Megoldás: validálás!
Az adatok felcicomázása érvényességellenõrökkel: Data Annotation. Validátorok megjelenítése, validáló interfacek. Tulajdonság- és objektumszintû érvényesítõk. Adatok megjelenítése „rácsban”: a grid. Megjelenítéssel kapcsolatos attribútumok áttekintése.

## Probléma: bejelentkeztetés, jogosultságellenõrzés. Megoldás: Autentikáció és autorizáció!
A beépített jogosultsági rendszerek áttekintése: Forms, Windows. Kontrollerek és akciók jogosultságvédelme. A Membership és Role objektumokhasználata. Bejelentkezés távoli (web)szolgáltatásokra.

## Probléma: konfigurációs adatok elhelyezése. Megoldás: Config- és, XML-fájlok
App.config, web.config, azure config áttekintése. Miket szokás tárolni bennük? Hogyan érjük el a beállításokat kódból? A ConfigurationManager objektum használata. Felhasználói  beállítások.

## Probléma: XML elõállítása, értelmezése. Megoldás: XML-kezelés.
Élõ példa: állítsunk elõ számlát a Számlázz.hu rendszerével, automatikusan.

## Probléma: fájl- és dokumentumkezelés. Megoldás: OpenXML, fájlkezelés
Fájl feltöltése weboldalon, és adatbázisba mentése. Fájl olvasása, írása, kipi-kopi. Tömörítés ZIP-be. Fájl mentése profilkönyvtárba. Különbözõ fájlformátumok értelmezése (szövegek, képek stb.) Excel táblák megnyitása, értékek olvasása/írása OpenXML-lel. Word doksi írása. Silverlight Isolated Storage használata.

## Probléma: nyomtatás. Megoldás: szerteágazó :)
Nyomtatás WPF-bõl: bénázás a FlowDocument objektummal. Nyomtatás SilverLightból: nyomtatási kép megtervezése designerrel. Nyomtatás webalkalmazásból: print friendly CSS. Többoldalas nyomtatás fejlécekkel, láblécekkel.

## Probléma: friss árfolyaminformáció megszerzése a webrõl. Megoldás: Webservice hívása!
További problémák: népességi adatok, idõjárásinformációk, szótárazás, Google mashup stb. Szolgáltatási végpontok megtalálása. Webservice help: WSDL. A Windows Communication Frameworok beizzítása. Hogyan kezelem az akármilyen webservice-t a saját kódomból? A proxyobjektumok szerepe. MNB webservice.

## Probléma: email küldése. Megoldás: SMTP
Egyszerû szöveges levelek küldése. Csilivili levelek elõállítása HTML-sablonok felhasználásával. Csatolmányok hozzácsapása a levélhez. Az autentikáció kiegészítése visszaigazoló levéllel. Copy-Paste Wordbõl, HTML-tisztogatás.

## Probléma: képkezelés. Megoldás: XAML (és XAML to MVC)!
Képfeltöltés, átméretezés, elforgatás, vízjelezés. Tetszõleges alakú képek kezelése, átlátszóság. Capthca készítése. Gyorsbillentyûk használata.

## Komplett alkalmazás készítese az eddigi DLL-ekbõl
Hiperautomatizált e-kereskedelmi webhely létrehozása. Az összes sales dolgozót kirúgtuk, tehát készíteni kell egy árajánlatkészítõ rendszert, ami azt imitálja, hogy hús-vér emberek foglalkoznak a vevõ igényeivel, és igény esetén testreszabott árajánlatot küldenek neki emailben.

## Probléma: olcsó, megbízható publikálás. Megodás: felhõ!
Azure publikáció, SQL Azure használata. Elsõ lépés: adatok a felhõbe. Adatok elérhetõvé tétele bárki számára REST-tel. Második lépés: webalkalmazás a felhõbe. Az Azure SDK használata.  A managementfelület áttekintése. Jogosultsági beállítások.

## Probléma: jaj, egy napom van egy komplett SAP leprogramozására! Megoldás: LightSwitch
A LightSwith segítségével könnyedén állíthatunk elõ adatbázisra épülõ, ûrlapalapú alkalmazásokat. A LightSwitch a megboldogult ReMind, a Magic és hasonló alkalmazásgenerátorok XXI.századi utóda.