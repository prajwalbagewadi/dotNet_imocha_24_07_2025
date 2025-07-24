//Datatypes variables and constants with user input.
using System;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datatypes {
    //class
    class Item {
        public string itemName;
        public decimal itemPrice;
        public Item() {
            //constructor 
            Console.WriteLine("Enter item name and price:");
            this.itemName = Console.ReadLine();
            this.itemPrice = Convert.ToDecimal(Console.ReadLine());
        }
        public void showItem() {
            Console.WriteLine("Item name=" + this.itemName);
            Console.WriteLine("Item price=" + this.itemPrice);
        }
    }
    //struct 
    struct Point {
        public int X,Y;
    }
    class Program {
        static void Main(string[] args) {
            // 1. Value Type
            Console.WriteLine("Datatypes in C#.");
            int a = 10; //integer numbers Size 4bytes
            Console.WriteLine("integer a=" + a);
            float pi = 3.14f; //float nums decimal with single precision Size 4bytes
            Console.WriteLine("float pi=" + pi);
            double d = 22.75; //double nums decimal with double precision Size 8bytes
            Console.WriteLine("double d=" + d);
            decimal salary = 50000.00m; //High precision for finance etc. Size 16bytes
            Console.WriteLine("decimal salary=" + salary);
            char c= 'A'; //Single ASCII character Size 2bytes
            Console.WriteLine("char c=" + c);
            bool isValid = true; //True or False Size 1bytes
            Console.WriteLine("bool isValid=" + isValid);
            byte b = 255; // 0 to 255 Size 1byte
            Console.WriteLine("byte b=" + b);
            short s = 10000; // short integer  Size 2bytes
            Console.WriteLine("short s=" + s);
            long big = 123456789; //large integer Size 8bytes
            Console.WriteLine("long big=" + big);

            //2. Reference type: Hold a reference (address) to the data
            //used for more complex data structures.

            string name = "harry"; //Sequence of characters.
            Console.WriteLine("string name=" + name);
            
            //object	Base type of all types (root type)	object obj = 5;
            object username = "prajwal";
            object age = 26;
            Console.WriteLine("objects username=" + username + " age=" + age);

            //dynamic Type is resolved at runtime dynamic x = "hello";
            dynamic dynm = 'a';
            Console.WriteLine("dynamic dynm=" + dynm);
            dynm = 12;
            Console.WriteLine("dynamic dynm=" + dynm);

            //Arrays Collection of elements  int[] arr = { 1, 2, 3 };
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 4;
            arr[2] = 3;
            arr[3] = 2;
            arr[4] = 1;
            Console.WriteLine("array arr=" + arr[0] + arr[1] + arr[2] + arr[3] + arr[4]);
            
            //Class / Struct    Custom types    Student s = new Student();
            
            //class object 
            Item i1 = new Item();
            i1.showItem();

            //struct object 
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine("point " + " X=" + p.X + "Y=" + p.Y);
            
            //USER INPUT
            //ReadLine : accepts from the user and returns a string.
            Console.WriteLine("enter your fav fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("fav fruit is:" + fruit);

            //constant 
            const decimal Dollar = 86.38m;
            Console.WriteLine("const Dollar=" + Dollar);
        }
    }
}
