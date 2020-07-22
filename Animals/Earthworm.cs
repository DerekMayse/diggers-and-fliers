using System;

namespace diggersAndFliers
{
    class Earthworm :  ILiveInGround
    {
        public string earthwormJim { get; set; }

     
        public string digging { get; set; }

     

        public void makingAhole()
        {
            Console.WriteLine("Owww");
        }
    }
}