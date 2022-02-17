using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.    Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
 * Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно,
 * а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо;
 * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая
 * скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
 * в конце прохода стек должен быть пуст.*/


namespace lab18zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст со скобками (), [], {}");
            string stringBKT = Console.ReadLine();
            Console.WriteLine(Check(stringBKT));
            Console.ReadKey();
        }

        static bool Check(string stringBKT)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bkt = new Dictionary<char, char> { { '(', ')' }, { '{', '}' }, { '[', ']' } };

            foreach (char c in stringBKT)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(bkt[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
