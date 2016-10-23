using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class ListExample
    {
        static void Main(string[] args)
        {
            GenericList<string> listOfGenerics = new GenericList<string>();
            listOfGenerics.Add("bok"); 
            listOfGenerics.Add("bok2"); 
            listOfGenerics.Add("pozdrav"); 
            listOfGenerics.Add("hej"); 
            listOfGenerics.Add("yo"); 
            listOfGenerics.RemoveAt(0);
            listOfGenerics.Remove("pozdrav"); 
            listOfGenerics.Contains("pozdrav");
            listOfGenerics.Contains("pozdrav");
            Console.WriteLine(listOfGenerics.GetElement(1));
            Console.WriteLine(listOfGenerics.Count); // 3
            Console.WriteLine(listOfGenerics.Remove("yo")); // false
            Console.WriteLine(listOfGenerics.RemoveAt(5)); // false
            listOfGenerics.Clear(); // []
            Console.WriteLine(listOfGenerics.Count); // 0
            Console.ReadLine();
        }
    }
}
