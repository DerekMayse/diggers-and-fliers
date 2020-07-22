using System;

namespace diggersAndFliers
{
    class Ant : IMoveOnGround, ILiveInGround
    {
        public string marching { get; set; }

        public string walking { get; set; }
        public string digging { get; set; }

        public void findingAplaceToSleep()
        {
            Console.WriteLine("Next to our queen");
        }

        public void makingAhole()
        {
            Console.WriteLine("For our queen");
        }
    }
}