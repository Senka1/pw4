using System;

class Orc
{
    private static int orcCount;
    private const int MaxGoldValue = 2;

    public Orc()
    {
        orcCount++;
    }

    public int ActualGoldValue
    {
        get
        {
            if (orcCount <= 5)
            {
                return orcCount * MaxGoldValue;
            }
            else
            {
                return (MaxGoldValue * 5) - (orcCount - 5) * 2;
            }
        }
    }

    public void Output()
    {
        Console.WriteLine($"У {orcCount} орк(а/ов) сейчас максимальное значение золота");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Orc[] orcs = new Orc[7];

        for (int i = 0; i < orcs.Length; i++)
        {
            orcs[i] = new Orc();
            orcs[i].Output();

            for (int j = 0; j <= i; j++)
            {
                Console.Write(orcs[j].ActualGoldValue);
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
