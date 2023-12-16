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

<!-- ---------------------------------------------|-------------------------------------------- -->

# *SPOILER* <sub><sup> → [*Lösung*](https://github.com/IxI-Enki/Uebung-039/blob/main/KreditkartenPrüfer/KreditkartenPrüfer/KreditkartenPrüfer.cs) <sup></sub>:

> nicht meine Beste Leisutng 👎🙈

### 🖥 **Ausgabe**: 
   |            Ausgabe  |
   |--------------------------------|
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/Uebung-039/assets/138018029/5d1fa307-e566-408e-b067-23b389815451) |
   
---

## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>


 ```c#
      /*----------------------------- CONSTANTS -----------------------------*/
      const int LENGTH = 16;

      /*----------------------------- VARIABLES -----------------------------*/
      string userInput;               //  TEST with: 
                                      //              2718281828458567
      double input = 0;               //  test with: 
      int digitIndex, length, checkDigit,       //    1234567890123456
          remainder,
          validDigit,                 //
          checkEven = 0, checkUneven = 0, checkAll = 0;

      int[] cardNumberDigits = new int[LENGTH];

      bool validNumber,
        abort = false;

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n                Kreditkarten Prüfer                  " +
      /* cWidth: */ "\n=====================================================");

      /*---[in:]-------------------- PROMPT_USER ----------------------------*/
      Console.Write("\n Geben Sie eine gültige Kartennummer ein: " +
                    "\n ");
      /*----------------------------- GET_INPUT -----------------------------*/
      userInput = Console.ReadLine();              //  get input + [enter]

      //  test for length
      validNumber = (userInput.Length == LENGTH) ? true : false;
      length = userInput.Length;

      //  test for numbers
      if (validNumber)
      {
        if (double.TryParse(userInput, out input) == true)
        { validNumber = true; }
        else
        { validNumber = false; }
        //  separate input into digits
        for (digitIndex = 0; digitIndex < length; digitIndex++)
        {
          cardNumberDigits[digitIndex] = (int)(input % 10);
          input = (Int64)(input / 10);
        }
        /*___TEST__OUTPUT_______________________________________________
        for (digitIndex = 0; digitIndex < length; digitIndex++)
        {
          Console.Write($"\n {digitIndex}: {cardNumberDigits[digitIndex]}");
        } //----------------------------------------------------------*/

        // CHECK FULL CREDITCARDNUMBER:
        for (digitIndex = 1; digitIndex < LENGTH; digitIndex++)
        {
          if ((digitIndex + 1) % 2 == 0)
          {
            if (cardNumberDigits[digitIndex] * 2 > 10)
            {
              remainder = cardNumberDigits[digitIndex] * 2;
              checkDigit = 0;
              while (remainder / 10 > 0)
              {
                checkDigit = remainder % 10;
                remainder = remainder / 10;
                checkDigit = checkDigit + remainder;
              }
              remainder = 0;
              cardNumberDigits[digitIndex] = checkDigit;
            }
            else
            { cardNumberDigits[digitIndex] = cardNumberDigits[digitIndex] * 2; }
            checkEven = checkEven + cardNumberDigits[digitIndex];
            // Console.Write($"\n {digitIndex}even: {checkEven}");
          }
          else
          {
            checkUneven = checkUneven + cardNumberDigits[digitIndex];
            // Console.Write($"\n {digitIndex}Uneven: {checkUneven}");
          }
          checkAll = checkUneven + checkEven;
          //  Console.Write($"\n CheckAll:{checkAll}");
        }
        // Console.Write($"\n Check All + testdigit: {checkAll + cardNumberDigits[0]}");
        validNumber = ((checkAll + cardNumberDigits[0]) % 10 == 0) ? true : false;
      }

      // OUT:
      Console.Write("\n-----------------------------------------------------" +
                   $"\n Die Kartennummer ist {(validNumber ? "eine" : "keine")} valide Nummer" +
                   $"\n=====================================================");
```

