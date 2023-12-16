/*-----------------------------------------------------------------------------
*                      HTBLA-Leonding / Class: 3ACIF                          
*-----------------------------------------------------------------------------
*                      Jan Ritt                                               
*-----------------------------------------------------------------------------
*  Description:  The Program tests CreditCard Numbers
*-----------------------------------------------------------------------------
*/

/*_________________________________libraries_________________________________*/
using System;                   //  
using System.Text;              //  Unicode Symbols
using System.Threading;         //  Thread.Sleep(1000) = 1 sec

/*---------------------------------- START ----------------------------------*/
namespace KreditkartenPrüfer   //  
{                              //
  public class Program         //
  {                            //
    static void Main()         //
    {
      ///*----------------------- console_settings ------------------------*///
      const int cWidth = 53;                     //  console width
      const int cHeight = 30;                    //  & height
      Console.SetWindowSize(cWidth, cHeight);    //
      Console.OutputEncoding = Encoding.UTF8;    //  Unicode Symbols

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

      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}