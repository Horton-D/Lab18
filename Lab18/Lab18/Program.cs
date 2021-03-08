using System;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var list = new List(10);
            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");


            Console.WriteLine(list.RemoveAt(3));
            list.Reverse();
            list.Print();
            
            Console.WriteLine(list.InsertAt(7, "here"));
          
           

           
        }
    }
}
