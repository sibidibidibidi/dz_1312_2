using System;
using System.Collections.Generic;
public interface ioutput2
{
    void showeven();
    void showodd();
}
public interface icalc2
{
    int countdistinct();
    int equaltovalue(int valuetocompare);
}

public class arraysmth : icalc2, ioutput2
{
    public int[] array { get; private set; }

    public arraysmth(int[] arr)
    {
        this.array = arr;
    }

    public int countdistinct()
    {
        List<int> uniquevalues = new List<int>();
        for (int i = 0; i < array.Length; ++i)
        {
            if (!uniquevalues.Contains(array[i]))
                uniquevalues.Add(array[i]);
        }
        return uniquevalues.Count;
    }

    public int equaltovalue(int valuetocompare)
    {
        int count = 0;
        foreach (var el in array)
        {
            if (el == valuetocompare)
            {
                count++;
            }
        }
        return count;
    }

    public void showeven()
    {
        Console.Write("Парні числа: ");
        foreach (var el in array)
        {
            if (el % 2 == 0)
            {
                Console.Write(el + " ");
            }
        }
        Console.WriteLine();
    }

    public void showodd()
    {
        Console.Write("Непарні числа: ");
        foreach (var el in array)
        {
            if (el % 2 != 0)
            {
                Console.Write(el + " ");
            }
        }
        Console.WriteLine();
    }
}

public class helloworld
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 2, 3, 3, 4, 5 };

        arraysmth math = new arraysmth(arr);

        Console.WriteLine("Унікальних значень: " + math.countdistinct());
        Console.WriteLine("Кількість 3 в масиві: " + math.equaltovalue(3));
        math.showeven();
        math.showodd();

        Console.ReadLine();
    }
}
