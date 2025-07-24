using System;

namespace UserInput {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name); // + concatinating

            Console.WriteLine("Enter how many candies you want?:");
            string candy = Console.ReadLine();
            //int candy = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You will get 4 more candies" + candy+4);
            //output is 104 candies it considers 4 as a string and concatinated.
            Console.WriteLine("You will get 4 more candies:" + (Convert.ToInt32(candy) + 4));
            // adding () gives prority. 
        }
    }
}
