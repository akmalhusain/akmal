using System;

namespace hello
{
    class program
    {
        static int add(int x) //method with parameter.wewq
        {
            return 10 + x;

        }
        static void name(string fanme, string lname)//method with parameter.
        {
            Console.WriteLine(fanme + lname);
        }
        static void add1(string name = "husain") //method with defualt paramter
        {
            Console.WriteLine(name);
        }
        static void add2(string a, string b, string c) //named argument.
        {
            Console.WriteLine("c is youngest child " + c);
        }
        static void Main(string[] args)
        {
            //int result=add(30);
            Console.WriteLine(add(23));
            name("akmal", "husain");
            name("ajmal", "husain");
            add1("sadiya");
            add1("aayat");
            add1("foziya");
            add1();
            add2(a: "naziya", b: "anam", c: "azmati");
        }
    }
}
