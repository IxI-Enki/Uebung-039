# Uebung-039  --  [***KreditkartenPrüfer***](https://github.com/IxI-Enki/Uebung-039/blob/main)  

<!-- ---------------------------------------------|-------------------------------------------- -->
###### 📎[**Angabe**](https://github.com/IxI-Enki/Uebung-039/blob/main/work-directory/EPR%20KreditkartenPruefer.pdf) *.pdf*
<sup><sub> 
---
</sub></sup>

<!-- ---------------------------------------------|-------------------------------------------- -->
## 📊 Lernziele:   

  - ↳ Wie ein verbaler Algorithmus in ein Programm umgesetzt wird.
  - ↳ Wie ein Test zur Überprüfung von verschiedener Eingabe erstellt wird.  
 
---

<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧮 **Aufgabenstellung:**  

  - In dieser Übung sollen Sie einen Kreditkarten-Prüfer implementieren.  
  - Das heißt, Ihr Programm liest vom Benutzer eine Kartennummer ein und prüft diese Nummer auf Gültigkeit.  
  - Die Kartennummer ist eine 16-stellige Nummer als Zeichenkette und Sie überprüfen anschließend unten angeführten Kriterien.  
  
---
 
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🔎 **Beispiel einer Kreditkartennummer:**

   |       Bsp:    *2718 2818 2845 8567*   |  
   | :----------------------------------------------------------------------------------------------------------------- |
   |  ![**Beispielnummer 📎**](https://github.com/IxI-Enki/Uebung-039/assets/138018029/5f82124a-15df-4cdd-9b5e-acc5f93f530e)  |


---

<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧩 **Hinweis** / <sub>Ablauf</sub> 🧠<sup>💭</sup>  

Die Kreditkartennummer (16 Stellen) ist durch eine Prüfziffer  
    **(16. Stelle, die bei der Berechnung nicht mitverwendet wird)**    
wie folgt gegen Fehleingaben abgesichert:  
       
### *Ablauf:*         

- 1.) Die Ziffern an den Stellen mit gerader Nummer (beginnend bei 0) werden verdoppelt und deren Ziffernsumme wird aufsummiert.  
- 2.) Die Ziffern an den Stellen mit ungerader Nummer werden aufsummiert.  
- 3.) Die beiden erhaltenen Zahlen werden addiert und die Differenz zur nächsten Zehnerzahl wird ermittelt, die gleich groß oder größer ist als die Summe.  
- 4.) Diese Ziffer (0-9) ist die Prüfziffer.  
- 5.) Ist die Eingabe gültig, liefert die Prüfroutine true, false sonst.  
 
 ---

<!-- ---------------------------------------------|-------------------------------------------- --

# *SPOILER* <sub><sup> → [*Lösung*](https://github.com/IxI-Enki/Uebung-<<AUSFÜHRBAREDAT>>.cs) <sup></sub>:




### 🖥 **Ausgabe**: 
   |            ❗ *`direkt in die README einfügen`*   
   |--------------------------------|
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/Uebung-<direkt ins Markdownfile>.cs) |

> <sub> [..*weiterführende Quelle*..] </sub> [ **⁶** ]()

---

## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>


 ```c#
namespace <<Bezeichnung>>   //  
{                           //  
  public class Program      //  
  {                         //  
    static void Main()      //  
    {

    `CODE`

    }
  }
}

```

-->
