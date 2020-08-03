using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] MyArray ={"Zebra","Ant","Owl","Lion"};
            Array.Sort(MyArray);
            for (var i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            foreach (string a in MyArray) {
                Console.WriteLine(a);
            }
            var arr = 0;
            do
            {
                Console.WriteLine(MyArray[arr]);
                arr++;
            }
            while (arr<4);
            var array = 0;
            while (array < MyArray.Length)
            {
                Console.WriteLine(MyArray[array]);
                array++;
            }
            string[] ArrayTwo = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            Array.Sort(ArrayTwo);
            for (var i = 0; i < ArrayTwo.Length; i++)
            {
                Console.WriteLine(ArrayTwo[i]);
            }



            string[] ArrayThree = { "Africa", "New Zealand", "Jamaica", "India" };
            Array.Sort(ArrayThree);
            for (var i = 0; i < ArrayThree.Length; i++)
            {
                Console.WriteLine(ArrayThree[i]);
            }


            Console.Read();

            

                
            

        }
    }
}
