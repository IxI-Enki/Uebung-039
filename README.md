# Uebung-039  -- Kreditkarten Prüfer

###### [Angabezettel (.pdf)](https://github.com/IxI-Enki/Uebung-039/blob/main/EPR%20KreditkartenPruefer.pdf)

## Lernziele:  

*In dieser Übung/Kontrolle lerne/überprüfe ich:*
  - Wie ein verbaler Algorithmus in ein Programm umgesetzt wird.
  - Wie ein Test zur Überprüfung von verschiedener Eingabe erstellt wird.

## Aufgabenstellung:  

### Kreditkarten-Prüfer
   In dieser Übung sollen Sie einen Kreditkarten-Prüfer implementieren. 
   Das heißt, Ihr Programm liest vom Benutzer eine Kartennummer ein und prüft diese Nummer auf Gültigkeit. 
   Die Kartennummer ist eine 16-stellige Nummer als Zeichenkette und Sie überprüfen anschließend nach folgenden Kriterien:
   
   Die Kreditkartennummer (16 Stellen) ist durch eine Prüfziffer 
    `(16. Stelle, die bei der Berechnung nicht mitverwendet wird)` 
       wie folgt gegen Fehleingaben abgesichert:
       
  - Die Ziffern an den Stellen mit gerader Nummer (beginnend bei 0) werden verdoppelt und deren Ziffernsumme wird aufsummiert
  - Die Ziffern an den Stellen mit ungerader Nummer werden aufsummiert
  - Die beiden erhaltenen Zahlen werden addiert und die Differenz zur nächsten Zehnerzahl wird ermittelt, die gleich groß oder größer ist als die Summe.
  - Diese Ziffer (0-9) ist die Prüfziffer
  - Ist die Eingabe gültig, liefert die Prüfroutine true, false sonst.

##### Ein Beispiel für die Kreditkartennummer *2718 2818 2845 8567*:
  ![Beispiel](https://github.com/IxI-Enki/Uebung-039/assets/138018029/a1bd6575-ad37-46a9-8826-abb1826e54de)


  

```c#



```



