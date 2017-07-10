using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool for us to create reusable pieces of code.
            //Methods are a way of us collecting a series of instructions and then call them 
            //when we need them.
            //Methods are ALWAYS part of a class. Methods are always children classes.
            //This means a method will never be inside another method or member of the class.
            FavoriteFood("orange", "pizza");



            RetirementCalculator(35);





        }




        //   public static int Add(int firstNumber, int secondNumber)
        // {

        //    int sum = firstNumber + secondNumber;
        //   return sum;
        //   }


        // create a method called Favorite Food



        // It should take two string parameters.One representing a name, and the other representing
        // a food.
        // the return type should be void 
        // the method should concatenate



        public static void FavoriteFood(string Name, string food)
        {


            Console.WriteLine("I like {0} and {1}", Name, food + "I also like {0} and {1}",Name,food);
        }







        // create a method called RetirementCalculator
        //it should take an int as a parameter representing the user's age
        //the method should calculate how many more years until the user retires using 65 as the age of retirement.
        //the return type should be void
        //once it calculates the user's retirement age it should print
        //the user will retire in x years where X represents the value that was calculated.
        public static void RetirementCalculator(int userAge)
        {


            int retirement = 65 - userAge;
            Console.WriteLine($"The user will {retirement} years");


        }
        
        
         
    }
}
