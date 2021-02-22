using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public class Piano
    {
        public int cursor = 4;

        public int index = 0;

        List<Note> notes = new List<Note>();

        //antalet positioner för varje tangent
        int[] position = new int[13];

        public void KeyboardSetup() //Keyboardens tangent-platser och toner
        {
            //Varje tangent-positions index
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

            notes.Add(new C4());
            notes.Add(new CSharp4());
            notes.Add(new D4());
            notes.Add(new DSharp4());
            notes.Add(new E4());
            notes.Add(new F4());
            notes.Add(new FSharp4());
            notes.Add(new G4());
            notes.Add(new GSharp4());
            notes.Add(new A4());
            notes.Add(new ASharp4());
            notes.Add(new B4());
            notes.Add(new C5());
        }

        public void LeftArrow() //navigera högerut längs tangenterna
        {
            if (index > 0)
            {
                index--;
                cursor = position[index];
            }
        }

        public void RightArrow() //navigera vänsterut längs tangenterna
        {
            if (index < 12)
            {
                index++;
                cursor = position[index];
            }
        }

        public void PlayNote() //spela ton vid angivet index
        {
            notes[index].PlayNote();
        }

        public Note GetNote(int index) //constructor häntar ton genom parametern som skickas in dvs index-talet
        {
            return notes[index];
        }
    }
}
