# WhereToSleep

## Popis aplikácie 
Je to aplikácia, pomocou ktorej si mozme vyhľadať rôzne hotely, miesta na prespanie. Môžeme si to vyhľadať buď pomocou hľadania (search), alebo pomocou funkcie NearME, pomocou GPS. Táto aplikácia má hlavne ukazovať okolité hotely za pomoci GPS... Ukáže ceny hotelov, hodnotenie, komentráre, rôzne názory iných ľudí a podobne. Táto apllikácia je naprogramovaná v jazyku C# za pomoci Xamarin.Forms. 

# Screeny
![splashscreen2](https://user-images.githubusercontent.com/71751430/111030096-ced71280-8400-11eb-9b28-c9b79df06074.png) ![mainpage](https://user-images.githubusercontent.com/71751430/114319263-0d9bdd80-9b11-11eb-969e-27acd6ec06cc.png) ![flyout](https://user-images.githubusercontent.com/71751430/114319171-9108ff00-9b10-11eb-9cdd-80458de10372.png)![map](https://user-images.githubusercontent.com/71751430/114319344-5bb0e100-9b11-11eb-9450-02864f260e26.png)
![exitbox](https://user-images.githubusercontent.com/71751172/114321359-c4e92200-9b1a-11eb-83e2-a49960ac6cf6.png)



- Úvodná obrazovka(splash screen)

- Main Page kde je vlastne úvod aplikácie. 

- Flyout na ktorom je vidno jeho design a Page na ktore sa mozme cezeň dostať. 

- Map Page, kde je Page s mapou. 

- Zatiaľ nedorobené - Menu na požiadavky - jednotlivé kategórie, ktoré môže zákazník zaškrtnúť ak ich chce (wifi/ lokácia/ názov/ jedlo/ cena/ lokácia GPS/ bazén/ parkovisko...)

# Buttony 
- Vyhľadávanie (search) s ikonkou lupy, po vyhladani hotela nam ukaze jeho  popis / hodnotenie/ komentáre/ cenník.
- Check in- deň kedy prídeme a zarezervujeme si hotel (dátum)
- Check out- deň kedy odchádzame (dátum)
- Rooms for - izba pre = vyberie sa počet osob ktore budu ubytovane 
- Tlačidlo pre navigáciu = presmeruje nas na Map Page kde su mapy spoločne s GPS (nie je ešte dokončená)
- Flyout Page = tam sa nachádza presmerovanie na niekoľko pagov / Map page, Main Page, Favourite Page 


# Prvé demo 15.3.2021

Do prvého dema chceme mať funkčnú splash screen, potom vizualizáciu appky, pridanú mapu a Flyout vľavo hore. Na úvodnej obrazovke buttony a funkčnosť aspoň jedného z nich.

Hlavná musí byť funkčnosť mapy/ GPS/ pinov

Dalšie tlačítka: obľúbené miesta, poznámky... (-/-)

Pokročilejšie: recenzie/ hodnotenie/ komentáre/ zľavy...

# Druhé demo 12.4.2021

Do druhého dema sme dorobili Map page kde sme nahrali basic vzhľad máp, Flyout, Funkčnosť navigation tlačidla, upravili vzhľad aplikácie taktiež aj flyoutu, pridal sa kalendár, popout okno pre rooms for tlačidlo.
Pridal sa taktiež exit box kvôli pre nechcené vypnutie aplikácie.

Upravila sa navigácia, opravili sa bugy a chyby. 

Čo by sme chceli zlepšiť do dalšieho dema:
 - Pokročilejšie funkcie atď: ešte sme na tom nepracovali, len sme uvažovali nad zpracovaním, využitím. 
 - Piny, ktoré ešte chýbajú
 - Na mape, aby nám ukazovalo aktuálnu poloh
 - Funkčné vyhľadávanie so zobrazením nejakých hotelov
 - Funkčné tlačidlo NearMe - vyhľadá hotel v blízkosti podľa aktuálnej polohy

