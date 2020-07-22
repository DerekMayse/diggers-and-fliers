using System;

namespace diggersAndFliers
{
    class Terrapin: ISwim, IMoveOnGround, ILiveInGround
    {
      public string  turtlestuff {get; set;}
        public string swimming { get ; set ; }
        public string walking { get ; set ; }
        public string digging { get ; set ; }

        public void findingAplaceToSleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
        }

        public void goingWithTheCurrent ()
        {
         Console.WriteLine("Helllllooooo Wooorrrlllddddd IIII neeeeedddd ssssooommmeee wwwwaaattteeerrr!!!!!!");
        }

        public void makingAhole()
        {
            Console.WriteLine("Just a turtle making a hole maybe???");
        }
    }
}