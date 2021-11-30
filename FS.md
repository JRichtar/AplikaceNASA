# Funkční Specifikace
## Verze 1

Tvorba mobilní aplikace, která bude zobrazovat informace o tělesech v blízkosti Země

Jakub Richtár <br/>
richtar.jakub.2018@skola.ssps.cz <br/>
29. 11. 2021

 

* Úvod
  * Účel dokumentu
    * Dokument bude informovat o tvorbě mobilní aplikace, na kterém pracuji v rámci MVOPu ve škole
  * Konvence dokumentu
    * Všechny kritické požadavky budou tučně
* Scénáře
  * Všechny reálné způsoby použití
    * Především pro informativní účely, lze také použít jako studijní materiál
  * Typy uživatelských rolí
    1. Role uživatel: zjišťuje informace o tělesech v blízkosti země
    2. Role student: používá volně dostupný kód aplikace pro vlastní, nebo studijní účely
  * Vymezení rozsahu
    * V aplikaci nebude možné provádět žádné úpravy, pouze aktualizaci dat
* Celková hrubá architektura 
  * Pracovní tok
    * Po spuštění aplikace se načte hlavní stránka přes se kterou pomocí tlačitka uživatel dostane k seznamu objektů. Dále pak může uživatel aktualizovat data, případně se vrátit zpět na hlavní stránku. 
  * Hlavní moduly
    1. Modul pro vytvoření hlavní stránky
    2. Modul pro vytvoření druhé stránky
    3. Modul pro vytvoření seznamu objektů
    4. Modul pro aktualizování dat 
  * Všechny detaily
    * Obrazovka bude pouze jedna, stránky budou dvě, budou se vyskytovat oznamovací okna např. při chybné aktualizaci dat. Všechny akce se budou spouštět tlačítky.
  
