using System;

namespace diggersAndFliers
{
    class Betta: ISwim
    {
      public string  blerb {get; set;}
        public string swimming { get ; set ; }

        public void goingWithTheCurrent ()
        {
         Console.WriteLine("There's no current because I'm stuck in a bowl FML");
        }
    }
}