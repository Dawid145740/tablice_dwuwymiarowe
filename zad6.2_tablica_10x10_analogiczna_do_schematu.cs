using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];
        int liczba = 1;
        int dol = 0;
        int gora = 9;
        int lewo = 0;
        int prawo = 9;

        while (liczba <= 100)
        {
            for (int i = lewo; i <= prawo; i++)
            {
                tablica[dol, i] = liczba++;
            }
            dol++;

            for (int i = dol; i <= gora; i++)
            {
                tablica[i, prawo] = liczba++;
            }
            prawo--;

            for (int i = prawo; i >= lewo; i--)
            {
                tablica[gora, i] = liczba++;
            }
            gora--;

            for (int i = gora; i >= dol; i--)
            {
                tablica[i, lewo] = liczba++;
            }
            lewo++;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}
