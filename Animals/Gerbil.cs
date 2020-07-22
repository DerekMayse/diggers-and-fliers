using System;

namespace diggersAndFliers
{
    class Gerbil: IMoveOnGround
    {
      public string  gerbilstuff {get; set;}
   
        public string walking { get ; set ; }
       

        public void findingAplaceToSleep()
        {
            Console.WriteLine("Ima GERBIL!!!!  Gerbil SLEEP NOW!!!!");
        }



    }
}