using System;

namespace Inlämningsuppgift
{
    class Program
    //TODO
    /* Display the keys in console
     * Create sounded notes
     * a, a#, b, c, c#, d, d#, e, f, f#. g, g#
     * navigate "up" the scale of the "keys"

    //TODO:
    // gå höger/vänster för att välja mini-tangent
    // space så spelar man tangenten man är på (alla låter lika dant)
    // '12 tone equal temprament' för att ha rätt Hz på tangenterna
    // pröva OOP, ett objekt per tangent som har ett 'Hz' fält och en char för hur tangenten ser ut
    // lägg alla tangent objekt i en lista och rita upp dem via att loopa listan
    // skapa större tangenter
     */
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

            //antalet positioner för varje tangent
            int[] position = new int[13];

            //Varje positions index
            position[0] = 4;
            position[1] = 8;
            position[2] = 12;
            position[3] = 16;
            position[4] = 20;
            position[5] = 28;
            position[6] = 32;
            position[7] = 36;
            position[8] = 40;
            position[9] = 44;
            position[10] = 48;
            position[11] = 52;
            position[12] = 59;

            int index = 0;

            //startposition
            Console.CursorLeft = 4;


            while (true)
            {
                //ReadKey - en metod som läser in tryck av tangent
                var cursor_movement = Console.ReadKey(true);
                //vad som händer när du trycker på högerpil..
                if (cursor_movement.Key == ConsoleKey.RightArrow)
                {
                    try
                    {
                        index++;
                        Console.CursorLeft = position[index];
                    }
                    catch (IndexOutOfRangeException e) {
                        // något har gått snett
                    }
                }
                //när du trycker på vänsterpil..
                if (cursor_movement.Key == ConsoleKey.LeftArrow)
                {

                    if (index > 0)
                    {
                        index--;
                        Console.CursorLeft = position[index];
                    }
                }

                // vid x position, spela y ton
                if (index == 0)
                {
                    C4 c4 = new C4();

                    c4.PlayNote();
                }
                else if (index == 1)
                {
                    CSharp4 csharp = new CSharp4();

                    csharp.PlayNote();
                }
                else if (index == 2)
                {
                    D4 d4 = new D4();

                    d4.PlayNote();
                }
                else if (index == 3)
                {
                    DSharp4 dsharp = new DSharp4();

                    dsharp.PlayNote();
                }
                else if (index == 4)
                {
                    E4 e4 = new E4();

                    e4.PlayNote();
                }
                else if (index == 5)
                {
                    F4 f4 = new F4();

                    f4.PlayNote();
                }
                else if (index == 6)
                {
                    FSharp4 fsharp = new FSharp4();

                    fsharp.PlayNote();
                }
                else if (index == 7)
                {
                    G4 g4 = new G4();

                    g4.PlayNote();
                }
                else if (index == 8)
                {
                    GSharp4 gsharp = new GSharp4();

                    gsharp.PlayNote();
                }
                else if (index == 9)
                {
                    A4 a4 = new A4();

                    a4.PlayNote();
                }
                else if (index == 10)
                {
                    ASharp4 asharp = new ASharp4();

                    asharp.PlayNote();
                }
                else if (index == 11)
                {
                    B4 b4 = new B4();

                    b4.PlayNote();
                }
                else if (index == 12)
                {
                    C5 c5 = new C5();

                    c5.PlayNote();
                }
            }


        }
    }
}
            
        

