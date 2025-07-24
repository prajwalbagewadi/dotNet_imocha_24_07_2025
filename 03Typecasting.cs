using System;

namespace Typecasting {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Type casting:");
            int a = 34;
            float pi = 3.14f;
            double d = 23.45;
            bool isGreat=true;
            char c = '$';
            Console.WriteLine("a=" + a);
            Console.WriteLine("pi=" + pi);
            Console.WriteLine("d=" + d);
            Console.WriteLine("isGreat=" + isGreat);
            Console.WriteLine("c=" + c);

            //Typecasting : converting Datatype of a value to another type;

            // 1.Implicit casting : automatic type casting
            // promoting char to int to long to float to double
            int x = 3;
            double y = x;
            char c1 = 'a';
            int asciival = c1;
            Console.WriteLine("x="+x);
            Console.WriteLine("y="+y);
            Console.WriteLine("char c1=" + c);
            Console.WriteLine("asciival=" + asciival);

            // 2.explicit casting : manual
            // if you want to go to reverse of promotion table 
            double d1 = 23.56;
            int a1 = (int)d1; //explicit casting
            Console.WriteLine("d1=" + d1);
            Console.WriteLine("a1=" + a1);

            //Type casting using methods
            double d2 = 3.55;
            float f2 = Convert.ToInt32(d2); //celing val
            Console.WriteLine("f2=" + f2);
            // eg: string to int
            string n1 = "34";
            int n2= Convert.ToInt32(n1);
            Console.WriteLine("n2=" + n2);
            
            //Convert.ToDouble();
            //Convert.ToString();
        }
    }
}
