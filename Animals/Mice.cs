using System;

namespace diggersAndFliers
{
    class Mice: IMoveOnGround
    {
      public string  squeak {get; set;}
   
        public string walking { get ; set ; }
       

        public void findingAplaceToSleep()
        {
            Console.WriteLine("Hopefully in a nice bed");
        }



    }
}