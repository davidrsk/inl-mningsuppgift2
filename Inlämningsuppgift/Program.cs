using System;

namespace Inlämningsuppgift
{
    class Program
    //TODO
    /* Display the keys in console
     * Create sounded notes
     * a, a#, b, c, c#, d, d#, e, f, f#. g, g#
     * navigate "up" the scale of the "keys"
     * lägg alla tangent objekt i en lista och rita upp dem via att loopa listan
     */

        //Komplettering
    //"Istället för att du har alla dina noter liggandes lösa, skapa en lista som innehåller alla noter List<Note>.
    //Då kan du korta ner alla dina if-satser till en rad kod 
    //där du kallar på den virtuella PlayNote metoden i Note basklassen"
    {
        static void Main(string[] args)
        {
            //Tangenterna 

            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |_____|  |_____|   |    |_____|  |_____|  |_____|  |    |_____|");
            Console.WriteLine("|       |       |       |       |       |       |       |       |   ");
            Console.WriteLine("|       |       |       |       |       |       |       |       |   ");
            Console.WriteLine("|_______|_______|_______|_______|_______|_______|_______|_______|___");

            Piano piano = new Piano(); //skapar piano-objektet
            piano.KeyboardSetup(); //åkallar setup med 

            //startposition
            Console.CursorLeft = piano.cursor; 


            while (true)
            {
                //ReadKey - en metod som läser in tryck av tangent
                var cursor_movement = Console.ReadKey(true);

                //vad som händer när du trycker på högerpil..
                if (cursor_movement.Key == ConsoleKey.RightArrow)
                {
                    try
                    {
                        piano.RightArrow();
                        Console.CursorLeft = piano.cursor;
                    }

                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }

                //när du trycker på vänsterpil..
                if (cursor_movement.Key == ConsoleKey.LeftArrow)
                {
                    piano.LeftArrow();
                    Console.CursorLeft = piano.cursor;
                }

                // action 
                piano.PlayNote();

            }


        }
    }
}
            
        

