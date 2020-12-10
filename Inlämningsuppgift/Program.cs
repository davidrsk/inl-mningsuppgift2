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
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |     |  |     |   |    |     |  |     |  |     |  |    |     |");
            Console.WriteLine("|    |_____|  |_____|   |    |_____|  |_____|  |_____|  |    |_____|");
            Console.WriteLine("|       |       |       |       |       |       |       |       |   ");
            Console.WriteLine("|       |       |       |       |       |       |       |       |   ");
            Console.WriteLine("|_______|_______|_______|_______|_______|_______|_______|_______|___");

            int[] position = new int[13];

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

            Console.CursorLeft = 4;


            while (true)
            {
                var cursor_movement = Console.ReadKey(true);
                if (cursor_movement.Key == ConsoleKey.RightArrow)
                {


                    if (index < 12)
                    {
                        index++;
                        Console.CursorLeft = position[index];
                    }
                }

                if (cursor_movement.Key == ConsoleKey.LeftArrow)
                {

                    if (index > 0)
                    {
                        index--;
                        Console.CursorLeft = position[index];
                    }
                }

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







                // string[] note_names = new string[12];
                // note_names[0] == Console.Beep(220, 1000)
                // note_names[1] == Console.Beep(233, 1000)
                // note_names[2] == Console.Beep(247, 1000)
                // note_names[3] == Console.Beep(262, 1000)
                // note_names[4] == Console.Beep(277, 1000)
                // note_names[5] == Console.Beep(294, 1000)
                // note_names[6] == Console.Beep(311, 1000)
                // note_names[8] == Console.Beep(330, 1000)
                // note_names[9] == Console.Beep(349, 1000)
                // note_names[10] == Console.Beep(370, 1000)
                // note_names[11] == Console.Beep(392, 1000)
                // note_names[12] == Console.Beep(415, 1000)

                /*
                char[,] canvas = new char[3, 3];
                int x = 1;
                int y = 1;
                canvas[x, y] = '*';

                // ___   [0,0] [1,0] [2,0]
                // _*_   [0,1] [1,1] [2,1]
                // ___   [0,2] [1,2] [2,2]
                */

            
        

