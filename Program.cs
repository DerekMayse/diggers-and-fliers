using System;

namespace diggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage cageforbirds = new Cage();

            Cardboardbox animalbox = new Cardboardbox();

            SmallerBox smallBox = new SmallerBox();

            Tank waterAnmimals = new Tank();

            Ant fredandGeorge = new Ant(){
                marching = "one by one hurah",
                walking = "hey, Im walking here",
                digging = "dig faster for our queen",
            };

            smallBox.smallerbox.Add(fredandGeorge);

            Betta fishheads = new Betta(){
                blerb = "blerb, blerb",
                swimming ="hey, Im swimming here"

            };

            waterAnmimals.tank.Add(fishheads);

            Copperhead snakey = new Copperhead{
                coperheadssssssss ="snake jazz",
                walking = "Idont",
                digging= "not exactly sure how digging works for me"

            } ;

            animalbox.box.Add(snakey);

            Earthworm Jim = new Earthworm (){
              earthwormJim = "cow tipper",
              digging = "tunnel time"

            };

            smallBox.smallerbox.Add(Jim);

            Finch flappyBird = new Finch(){
                squak ="squak",
                flying ="flying better than the parakeet"
            };

            cageforbirds.cage.Add(flappyBird);

            Gerbil herbTheGerb = new Gerbil(){
                gerbilstuff ="Ima Gerbil",
                walking= "likeaBOSS!!!"
            };

            animalbox.box.Add(herbTheGerb);

            Mice mickey = new Mice (){
                squeak ="squeeeeeeeek",
                walking = "scattering all across the floor"
            };

            animalbox.box.Add(mickey);

            Parakeet tweety = new Parakeet(){
                tweet = "tweet, tweet",
                flying = "screw flappy bird"
            };

            cageforbirds.cage.Add(tweety);

            Rattlesnake tailShaker = new Rattlesnake(){
                ssssssss = "sssssnake jazzzzzz",
                walking = "slither",
                digging = "I use a shovel"
            };

            animalbox.box.Add(tailShaker);

            Terrapin shelly = new Terrapin(){
                turtlestuff = "slow and steady",
                swimming = "blerbadubbadubdub",
                walking = "one foot in front of the other",
                digging = "in the sand hopefully"
            };

            waterAnmimals.tank.Add(shelly);

            Console.WriteLine();





            


        }
    }
}
