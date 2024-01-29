using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace MenuExercicios
{
    internal class Exercicio2 : Pilha
    {
        public bool IsBalanced(string? expression)
        {
            Stack<char> stack = new Stack<char>();
            if (expression == null)
            {
                return true;
            }
            foreach (char item in expression)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (item == ')' && top != '(')
                    {
                        return false;
                    }
                    else if (item == ']' && top != '[')
                    {
                        return false;
                    }
                    else if (item == '}' && top != '{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
