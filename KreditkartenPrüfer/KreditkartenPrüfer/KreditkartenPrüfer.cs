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

      /*----------------------------- VARIABLES -----------------------------*/
      string userInput,          //  
             formattedOutput;    //  format decimal places of Output
      char userChoice;           //
      int input,                 //  
          output;                //  ✏

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n                Kreditkarten Prüfer                  " +
      /* cWidth: */ "\n=====================================================");

      /*---[in:]-------------------- PROMPT_USER ----------------------------*/
      Console.Write("\n .. " +    //  ✏
                    "\n .. ");    //  

      /*----------------------------- GET_INPUT -----------------------------*/
      userInput = Console.ReadLine();              //  get input + [enter]
                                                   //  
      int.TryParse(userInput, out input);          //  is int
      char.TryParse(userInput, out userChoice);    //  is char



      /*---[calc:]-------------------📝 NEW_CODE ----------------------------*/

      formattedOutput = output.ToString("0.00");    // .. 2 decimals



      /*---[out:]--------------------- SOLUTION -----------------------------*/
      Console.Write("\n ..Output.. ");    //  ✏ tell solution

      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}