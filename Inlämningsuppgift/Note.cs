using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public class Note
    {
        public virtual void PlayNote()
        {
            //metod som ärvs genom class Note till varje note/ton
        }
    }
    public class C4 : Note
    {
        public override void PlayNote() //beep(x, y) en metod där x = frekvens, y = duration
        {
            Console.Beep(261, 400); 
        }
    }
    class CSharp4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(277, 400);
        }
    }
    class D4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(293, 400);
        }
    }
    class DSharp4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(311, 400);
        }
    }
    class E4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(329, 400);
        }
    }
    class F4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(349, 400);
        }
    }
    class FSharp4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(370, 400);
        }
    }
    class G4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(392, 400);
        }
    }
    class GSharp4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(415, 400);
        }
    }
    class A4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(440, 400);
        }
    }
    class ASharp4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(466, 400);
        }
    }
    class B4 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(494, 400);
        }
    }
    class C5 : Note
    {
        public override void PlayNote()
        {
            Console.Beep(523, 400);
        }
    }


}
