# Netacademia Hat�kony programoz�s .NET-ben tanfolyam

https://netacademia.hu/Tanfolyam/hatekony-programozas-net-ben

Sokan fejlesztenek Web alap� alkalmaz�sokat. De kevesen tudj�k, hogy a modern alkalmaz�sok �s munkam�dszerek haszn�lat�val mennyi id�t takar�thatn�nak meg. Ha �rdekel mi az Nmp, Grunt, Git, Less, AngularJS, NodeJS, MongoDB, akkor ez a Te tanfolyamod. Egy �l� rendszert fogunk egy�tt k�sz�teni ezek haszn�lat�val, az alapokt�l. Minden l�p�st v�gigvesz�nk, a fejleszt�i k�rnyezet fel�ll�t�s�t�l a k�sz alkalmaz�sig. A tanfolyam c�lja a modern fejleszt�eszk�z�k megismer�se. Ezek hat�kony haszn�lata, be�ll�t�sa, testreszab�sa. Saj�t automatiz�lt k�rnyezet fel�ll�t�sa. Versenyk�pes tud�s a legkeresettebb technol�gi�k ter�let�n.


## Fejleszt�si k�rnyezeteink �ttekint�se, WPF, Silverlight, MVC gyorstalpal�
Ezen a napon megalapozzuk Windows-alkalmaz�sfejleszt�si k�pess�geinket. Megismerked�nk a Z�rlapok fel�p�t�s�vel �s haszn�lat�val, a XAML-le�r�nyelvvel �s az adatk�t�s (DataBind) m�v�szet�vel.
Mi f�n terem a SilverLight? Ez most web, vagy desktop? Az aszinkronit�s gy�ny�rei. Egy�ttm�k�d�s a futtat�k�rnyezettel: JavaScripttel a SilverLight ellen, SilverLighttal a HTML ellen. Futtat�s b�ng�sz�n k�v�l.
MVC-helysz�nel�k. Hogyan kezdj�nk neki egy MVC-webalkalmaz�snak? A Model, View, Controller szenth�roms�g. Mi�rt pont /Home/Index? T�maszkodjuk a Model Binderre!
Hal�l a macskak�r�mre!

## Probl�ma halmazkezel�s. Megold�s: LINQ, avagy hogyan kezelj�nk �enumer�tumokat�?
A mai modern adatel�r�s alapja a LINQ, amely � nev�b�l fakad�an � a C#-nyelvbe integr�lt lek�rdez�si nyelv. Egy�ltal�n nem adatb�zisf�gg�, b�rmit le lehet k�rdezni vele, ami IENumerable<>. De mi a csuda az az IENumerable? Megismerend� LINQ-kulcsszavak: select, from, where, orderby, group, any, single, first, last, skip, take.
Hal�l a macskak�r�mre!

## Probl�ma: adatt�rol�s. Megold�s: LINQ providerek, Code First
SQL-adatb�zis l�trehoz�sa, vagy csatlakoz�s megl�v�h�z, esetleg az SQL adatb�zis figyelmen k�v�l hagy�sa :) DataContext �s DataSet objektumok. Egy-egy, egy-t�bb, t�bb-t�bb t�blakapcsolat kezel�se. Lek�rdez�sek, besz�r�s, m�dos�t�s, t�rl�s.
Figyelem! Felk�sz�l�s az Azure-ra: Azure regisztr�ci�!
Hal�l a macskak�r�mre!

## Probl�ma: adathelyess�g-ellen�rz�s. Megold�s: valid�l�s!
Az adatok felcicom�z�sa �rv�nyess�gellen�r�kkel: Data Annotation. Valid�torok megjelen�t�se, valid�l� interfacek. Tulajdons�g- �s objektumszint� �rv�nyes�t�k. Adatok megjelen�t�se �r�csban�: a grid. Megjelen�t�ssel kapcsolatos attrib�tumok �ttekint�se.

## Probl�ma: bejelentkeztet�s, jogosults�gellen�rz�s. Megold�s: Autentik�ci� �s autoriz�ci�!
A be�p�tett jogosults�gi rendszerek �ttekint�se: Forms, Windows. Kontrollerek �s akci�k jogosults�gv�delme. A Membership �s Role objektumokhaszn�lata. Bejelentkez�s t�voli (web)szolg�ltat�sokra.

## Probl�ma: konfigur�ci�s adatok elhelyez�se. Megold�s: Config- �s, XML-f�jlok
App.config, web.config, azure config �ttekint�se. Miket szok�s t�rolni benn�k? Hogyan �rj�k el a be�ll�t�sokat k�db�l? A ConfigurationManager objektum haszn�lata. Felhaszn�l�i  be�ll�t�sok.

## Probl�ma: XML el��ll�t�sa, �rtelmez�se. Megold�s: XML-kezel�s.
�l� p�lda: �ll�tsunk el� sz�ml�t a Sz�ml�zz.hu rendszer�vel, automatikusan.

## Probl�ma: f�jl- �s dokumentumkezel�s. Megold�s: OpenXML, f�jlkezel�s
F�jl felt�lt�se weboldalon, �s adatb�zisba ment�se. F�jl olvas�sa, �r�sa, kipi-kopi. T�m�r�t�s ZIP-be. F�jl ment�se profilk�nyvt�rba. K�l�nb�z� f�jlform�tumok �rtelmez�se (sz�vegek, k�pek stb.) Excel t�bl�k megnyit�sa, �rt�kek olvas�sa/�r�sa OpenXML-lel. Word doksi �r�sa. Silverlight Isolated Storage haszn�lata.

## Probl�ma: nyomtat�s. Megold�s: szerte�gaz� :)
Nyomtat�s WPF-b�l: b�n�z�s a FlowDocument objektummal. Nyomtat�s SilverLightb�l: nyomtat�si k�p megtervez�se designerrel. Nyomtat�s webalkalmaz�sb�l: print friendly CSS. T�bboldalas nyomtat�s fejl�cekkel, l�bl�cekkel.

## Probl�ma: friss �rfolyaminform�ci� megszerz�se a webr�l. Megold�s: Webservice h�v�sa!
Tov�bbi probl�m�k: n�pess�gi adatok, id�j�r�sinform�ci�k, sz�t�raz�s, Google mashup stb. Szolg�ltat�si v�gpontok megtal�l�sa. Webservice help: WSDL. A Windows Communication Frameworok beizz�t�sa. Hogyan kezelem az ak�rmilyen webservice-t a saj�t k�domb�l? A proxyobjektumok szerepe. MNB webservice.

## Probl�ma: email k�ld�se. Megold�s: SMTP
Egyszer� sz�veges levelek k�ld�se. Csilivili levelek el��ll�t�sa HTML-sablonok felhaszn�l�s�val. Csatolm�nyok hozz�csap�sa a lev�lhez. Az autentik�ci� kieg�sz�t�se visszaigazol� lev�llel. Copy-Paste Wordb�l, HTML-tisztogat�s.

## Probl�ma: k�pkezel�s. Megold�s: XAML (�s XAML to MVC)!
K�pfelt�lt�s, �tm�retez�s, elforgat�s, v�zjelez�s. Tetsz�leges alak� k�pek kezel�se, �tl�tsz�s�g. Capthca k�sz�t�se. Gyorsbillenty�k haszn�lata.

## Komplett alkalmaz�s k�sz�tese az eddigi DLL-ekb�l
Hiperautomatiz�lt e-kereskedelmi webhely l�trehoz�sa. Az �sszes sales dolgoz�t kir�gtuk, teh�t k�sz�teni kell egy �raj�nlatk�sz�t� rendszert, ami azt imit�lja, hogy h�s-v�r emberek foglalkoznak a vev� ig�nyeivel, �s ig�ny eset�n testreszabott �raj�nlatot k�ldenek neki emailben.

## Probl�ma: olcs�, megb�zhat� publik�l�s. Megod�s: felh�!
Azure publik�ci�, SQL Azure haszn�lata. Els� l�p�s: adatok a felh�be. Adatok el�rhet�v� t�tele b�rki sz�m�ra REST-tel. M�sodik l�p�s: webalkalmaz�s a felh�be. Az Azure SDK haszn�lata.  A managementfel�let �ttekint�se. Jogosults�gi be�ll�t�sok.

## Probl�ma: jaj, egy napom van egy komplett SAP leprogramoz�s�ra! Megold�s: LightSwitch
A LightSwith seg�ts�g�vel k�nnyed�n �ll�thatunk el� adatb�zisra �p�l�, �rlapalap� alkalmaz�sokat. A LightSwitch a megboldogult ReMind, a Magic �s hasonl� alkalmaz�sgener�torok XXI.sz�zadi ut�da.