/***********************************************************************************************
 * Übungsnr:        11                                     
 * Programmname:    SelectArrayElement
 * Autor:           karlof002  
 * Klasse:          1BHIF
 * Datum:           25.11.2013                               
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Lese 10 Zahlen ein und speichere diese in ein Integer Array.
 * Im Anschluss kann der Benutzer wählen, welches Array-Element ausgegeben werden soll.
 * Diese Auswahl wird solange wiederholt, bis der Benutzer „e“ eingibt!
*/

using System;

namespace SelectArrElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int actNum;
            int[] numbers = new int[10];
            //Zahlen einlesen
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}. Zahl eingeben: ",i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());   
            }

            //Ausgabe
            do
            {
                Console.Write("Die wievielte Zahl wollen Sie ausgeben (e für Ende)? ");
                input = Console.ReadLine();
                if (input != "e")
                {
                    actNum = Convert.ToInt32(input);
                    if ((actNum >= 1) && (actNum <= 10))
                    {
                        Console.WriteLine("Die Zahl lautet:" + numbers[actNum - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe!");
                    }
                }
            } while (input!="e");
            
        }
    }
}
