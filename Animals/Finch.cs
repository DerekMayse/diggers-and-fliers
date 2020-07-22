using System;

namespace diggersAndFliers
{
    class Finch: IFly
    {
      public string  squak {get; set;}
        public string flying { get ; set ; }

        public void takingOff()
        {
         Console.WriteLine("Screw the parakeet I'm flying the highest ");
        }
    }
}