using System;

namespace Coding.Exercise {

    public class Exercise {
        public void RunExercise() {
            string myString = "This is a string.";
            decimal myDecimal = 1000d;
            bool myBoolean = true;

            Console.WriteLine(myString.GetType());
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(myBoolean.GetType());

        }
    }
}