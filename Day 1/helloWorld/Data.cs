using System;

namespace Coding.Exercise 
{
    public class Exercise {
        public void RunExercise() {

            Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>() {
                {"cheese", 5.99},
                {"carrrots", 2.99}
            }; 

            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);
        }
    }
}