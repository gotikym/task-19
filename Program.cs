using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите символы  (  и  )  в любом количестве и порядке, \nа мы определим корректность" +
            " и максимальную глубину вложенности скобок");
        string rowSimbol = Console.ReadLine();
        char simbol1 = '(';
        char simbol2 = ')';
        int nestingDepth = 0;
        int maxNestingDepth = 0;

        for (int i = 0; i < rowSimbol.Length; i++)
        {
            if (rowSimbol[i] == simbol2)
            {
                nestingDepth--;
            }
            else if (rowSimbol[i] == simbol1)
            {
                nestingDepth++;
            }
            if (nestingDepth < 0)
            {
                Console.WriteLine("Не корректное скобочное выражение");
                break;
            }
            else if (maxNestingDepth < nestingDepth)
            {
                maxNestingDepth = nestingDepth;
            }
        }
        if (nestingDepth != 0)
        {
            Console.WriteLine("Не корректное скобочное выражение");
        }
        else
        {
            Console.WriteLine("Данное скобочное выражение является корректным и максимальная глубина вложенности" +
                " скобок равна " + maxNestingDepth);
        }
    }
}