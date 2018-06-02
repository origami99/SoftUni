using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var expression = Console.ReadLine();
        var brackets = new Stack<char>();

        var areBalanced = true;

        foreach (char bracket in expression)
        {

            switch (bracket)
            {
                case '(':
                case '[':
                case '{':
                    brackets.Push(bracket);
                    break;
                case ')':
                    if (!brackets.Any() || brackets.Pop() != '(')
                    {
                        areBalanced = false;
                    }
                    break;
                case ']':
                    if (!brackets.Any() || brackets.Pop() != '[')
                    {
                        areBalanced = false;
                    }
                    break;
                case '}':
                    if (!brackets.Any() || brackets.Pop() != '{')
                    {
                        areBalanced = false;
                    }
                    break;
            }

            if (!areBalanced)
            {
                break;
            }
        }

        if (areBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
