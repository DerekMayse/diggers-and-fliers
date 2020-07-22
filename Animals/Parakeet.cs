using System;

namespace diggersAndFliers
{
    class Parakeet: IFly
    {
      public string  tweet {get; set;}
        public string flying { get ; set ; }

        public void takingOff()
        {
         Console.WriteLine("Soaring higher than the finches");
        }
    }
}