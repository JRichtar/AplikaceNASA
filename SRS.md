# Specifikace Požadavků
## Verze 1

Tvorba mobilní aplikace, která bude zobrazovat informace o tělesech v blízkosti Země

Jakub Richtár <br/>
richtar.jakub.2018@skola.ssps.cz <br/>
16. 11. 2021 - Poslední aktualizace

 

* Úvod
  * Účel dokumentu
    * Dokument bude informovat o tvorbě mobilní aplikace, na kterém pracuji v rámci MVOPu ve škole
  * Konvence dokumentu
    * Důležitost - 1 nejvyšší, 5 nejnižší
    * Všechny kritické požadavky budou tučně
* Celkový popis
  * Funkce
    * Aplikace bude sloužit k informování uživatelů ohledně objektů poblíž Země a informace o nich
  * Uživatelské skupiny
    * Aplikace bude určená pro všechny, jenž mají zájem 
  * Omezení návrhu
    * Omezení prozatím nejsou
* Požadavky na rozhraní
  * Uživatelská rozhraní
    * V aplikaci si může uživatel rozkliknout objekty poblíž Země, vzdálenost objktů od Země a čas aktualizace objektů 
  * Softwarová rozhraní
    * Aplikace bude vytvořena v Xamarin.Forms v jazyce C#
* Vlastnosti systému
  1. Spuštění aplikace
    * Důležitost: 1
    * Vstup : aplikace se otevře
    * Akce : načtení hlavní stránky
    * Výstup : chybové hlášení, když se hlavní stránka nenačte
  2. Zobrazení seznamu objektů 
    * Důležitost: 1
    * Vstup: spuštění aplikace  
    * Akce: tlačítkem Seznam Objektů
    * Výstup: načtění stránky 
    * Výstup: chybové hlášení, když se stránka nenačte
  3. Aktualizace/obnovení informací ohledně objektů
    * Důležitost: 1
    * Vstup: zobrazení seznamu objektů
    * Akce: tlačítkem Aktualizovat
    * Výstup: informace se aktualizují
    * Výstup: v režimu offline se objeví zpráva o nepřipojení k síti 
* Nefunkční požadavky
  * Odezva
    * Systém bude poskytovat odezvu do 5s od zadání akce
  * Spolehlivost
    * Systém neskončí s chybou ve více než 2% případů
