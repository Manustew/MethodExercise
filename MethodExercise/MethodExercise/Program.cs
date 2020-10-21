using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name any integer");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name another integer");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of your numbers is");
            Console.WriteLine(Add(num1, num2));
            Console.WriteLine("Their product is");  
            Console.WriteLine(Multiply(num1, num2));
            Console.WriteLine("Do you want to try a classic game of Mad-Libs?");
            var play = Console.ReadLine().ToLower();
            if (play == "yes" || play == "Yes" || play == "YES" || play == "sure" || play == "ya")
            {
                Console.WriteLine("Great!  Let's Play.");
            }
            else
            {
                Console.WriteLine("Too bad!  We're playing anyway!");
            }
            Console.WriteLine("Name a profession.");
            var profession = Console.ReadLine();
            Console.WriteLine("Name a Country");
            var country = Console.ReadLine();
            Console.WriteLine("Name an ailment or minor medical issue");
            var ailment = Console.ReadLine();
            Console.WriteLine("Name a bad or annoying habit");
            var badHabit = Console.ReadLine();
            Console.WriteLine("Name a uncommon profession");
            var uncommonProfession = Console.ReadLine();
            Console.WriteLine("Give a person's name");
            var name = Console.ReadLine();
            Console.WriteLine("Tell a little white lie about yourself");
            var lie = Console.ReadLine();
            Console.WriteLine("Name an animal");
            var animal = Console.ReadLine();
            Console.WriteLine("Name an adjective");
            var animalAdjective = Console.ReadLine();
            Console.WriteLine("Name a city");
            var city = Console.ReadLine();
            Console.WriteLine("Name an uncommon sport or hobby");
            var hobby = Console.ReadLine();
            Console.WriteLine("Name a food");
            var food = Console.ReadLine();
            Console.WriteLine("Name a hobby or skill that can take years to learn");
            var skill = Console.ReadLine();
            Console.WriteLine("Name another profession");
            var profession2 = Console.ReadLine();

            Console.WriteLine($"The details of my life are quite inconsequential\n " +
                $"My father was a relentlessly self improving {profession} from {country} with low grade {ailment} and a penchant for {badHabit}.\n" +
                $" My mother was a 15 year old {uncommonProfession} named {name} with webbed feet.\n " +
                $"My father would womanize and he would drink.  He's make outrageous claims like{lie}. \n " +
                $"Sometimes he accused {animal} of being {animalAdjective}. My childhood was typical.\n  Summers in {city}.  {hobby}.\n " +
                $"In the spring we'd make {food} helmets. At the age of 15 I went off to Evil Medical School. \n " +
                $"At the age of 25 I took up {skill}.\n  I wanted to be a triple threat.  Actor.  Dancer.  {profession2}.");








        }

        public static int Add(int num1, int num2)
        {
            int sum = (num1 + num2);
            return sum;
        }

        public static int Multiply(int num1, int num2)
        {
            int product = (num1 * num2);
            return product;
        }
    }
}
