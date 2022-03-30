# Labb3-Databaser

### Om uppgiften

Denna labb bygger vidare på labb 2 och du ska alltså jobba vidare med samma databas som du skapade där.

**Du får, om du vill, ändra i databasens struktur och design när du gör denna uppgift!**

### Vad du ska göra

- [ ]  Fyll på dina databas från labb 2 med lite mer exempeldata i alla tabeller.
- [ ]  Skapa ett nytt console-program i C#
- [ ]  Skapa en enkel navigation i programmet som gör att användaren kan välja mellan följande funktioner.
    - [ ]  Hämta ut personal (ska lösas med SQL)
        
        Användaren får välja om denna vill se alla anställda, eller bara inom en av kategorierna så som lärare.
        
    - [ ]  Hämta ut alla elever (ska lösas med Entity framwork)
        
        Användaren får välja om de vill se eleverna sorterade på för- eller efternamn och om det ska vara stigande eller fallande sortering.
        
    - [ ]  Hämta ut alla elever i en viss klass (ska lösas med Entity framework)
        
        Användaren ska först få se en lista med alla klasser som finns, sen får användaren välja en av klasserna och då skrivs alla elever i den klassen ut.
        
        Extra utmaning: låt användaren även få välja sortering på eleverna som i punkten ovan.
        
    - [ ]  Hämta ut alla betyg som sats senaste månaden (ska lösas med SQL)
        
        Här får användaren direkt en lista med alla betyg som sats senaste månaden där elevens namn, kursens namn och betyget framgår.
        
    - [ ]  Hämta ut en lista med alla kurser och det snittbetyg som eleverna fått på den kursen samt det högsta och lägsta betyget som någon fått i kursen (ska lösas med SQL)
        
        Här får användaren direkt upp en lista med alla kurser i databasen samt snittbetyget, högsta och lägsta betyget för varje kurs
        
        Tips: Det kan vara svårt att göra detta med betyg i form av bokstäver så du kan välja att lagra betygen som siffror istället.
        
    - [ ]  Lägga till nya elever (ska lösas genom SQL)
        
        Användaren får möjlighet att mata in uppgifter om en ny elev och dessa sparas ner i databasen
        
    - [ ]  Lägga till ny personal (ska lösas genom Entity framework)
        
        Användaren får möjlighet att mata in uppgifter om en ny anställd och dessa sparas ner i databasen
