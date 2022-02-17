using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    internal class Program
    {
        static void Main (string[] args)
        {
            ElementCollection myCollection = new ElementCollection();

            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2 {2}", element.Name, element.Field1, element.Field2);
            }
            Console.ReadKey();
        }
    }
}
