using System;
using System.Collections.Generic;

namespace Bowling {
    class Program {
        /* --Group in Class Project Bowling 2/19--
             create generic collection of integers
            use forloop to make it run 10 times to get random numbers
            use foreach loop to add up frame score and total game score*/
        static void Main(string[] args) {
            //get random number generated
            var rnd = new Random();//
            //create collection
            var game = new List<int>(10);
            //for loop will happen 10 times
            for (var idx = 0; idx < 10; idx++) {
                var score = rnd.Next(0, 31);
                game.Add(score);
            }
            //now add all the scores up

            var total = 0;
            foreach (var score in game) {
                total += score;
            } 
            // If I keep running this print statement the score numbers will change

                Console.WriteLine($"Bowling score is {total}");
        

            /* --Group in Class Project Bowling 2/19--
             create generic collection of integers
            use forloop to make it run 10 times to get random numbers
            use foreach loop to add up frame score and total game score*/

            



        }
    }
}
