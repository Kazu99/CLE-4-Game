Level Bijbel - team 12

Refereer naar het 'Egypte' level om voorbeelden van de omschreven technieken te zien.

Iedereen heeft een map met zijn naam in het Unity project. Al jouw toevoegingen of aanpassingen moeten hier in.

—hoe je culling gebruikt-
-in car/scripts/culling-
Dit script laat objecten in de verte verdwijnen wegens performance redenen.
dist bepaald de afstand dat dingen verdwijnen/getoond worden.
g zijn alle GameObjects die vanaf een bepaald punt moeten verdwijnen.
mr zijn alle mesh renderers die moeten verdwijnen.
mb zijn alle scripts die niet uitgevoerd moeten worden vanaf een bepaalde afstand.
Life hack: maak een empty GameObject de parent en maak dit object het enige onderdeel in g om tijd te besparen.

-belangrijk!!!-
—in car/prefs/importantObjs/essentials-
sleep dit in je scene en je hebt alles wat de speler nodig heeft.

-Voor offroad stukken-
Maak een box collider (zonder mesh renderer) markeer "Is Trigger". Geef deze de tag "offroad" en maak zijn layer "Ignore Raycast"

-voor hekjes collision-
maak een box collider (zonder mesh renderer). Doe verder niks

-Hoe je hekjes maakt-
Ga naar car/prefs/op en naast de weg/hek en sleep dit in je scene. Er zal een lijn getrokken worden tussen alle kind objecten (let er wel op dat je lege objecten gebruikt).

-hoe je een lijn over de weg laat gaan-
Ga naar car/prefs/op en naast de weg/grondLijn en sleep dit in je scene. Zorg dat dit 0.2 units boven je wegdek zweeft. Er zal een lijn getrokken worden tussen alle kind objecten (let er wel op dat je lege objecten gebruikt).

-hoe je obstakels plaatst-
Ga naar car/prefs/obstakels en drag&drop zoveel je wilt. Let op dat je culling MOET gebruiken als je level veel obstakels gaat hebben.

-hoe je verkeersborden plaats-
Ga naar car/prefs/borden en drag&drop zoveel je wilt. Let op dat je het kind object "noticeCollider" kan aanpassen als je wil aanpassen vanaf waar het bord rechtsboven in je scherm verschijnt.