using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static bool bbrackets(string n)
        {
            int lnght = n.Length;
            if (lnght % 2 == 1)
            {
                return false;
            }
            else
            {
                if (n.Substring(0,1)!= "(")
                {
                    return false;
                }
                else if (n.Substring(lnght - 1, 1) != ")")
                {
                    return false;
                }
                else
                {
                    int count = 0;
                    char charToCount = '(';
                    foreach(char c in n)
                    {
                        if (c == charToCount)
                        {
                            count++;
                        }
                    }
                    int count2 = 0;
                    charToCount = ')';
                    foreach(char c in n)
                    {
                        if (c == charToCount)
                        {
                            count2++;
                        }
                    }
                    if (count == count2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter brackets: ");
            string brackets = Console.ReadLine();
            Console.WriteLine(bbrackets(brackets));
        }
    }
}
