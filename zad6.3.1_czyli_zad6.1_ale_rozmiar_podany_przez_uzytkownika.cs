using System;

class Program
{
    static void Main()
    {
        int rozmiar = PodajRozmiarTablicy();
        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = liczba++;
                }
            }
            else
            {
                for (int j = rozmiar - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba++;
                }
            }
        }

        WyswietlTablice(tablica);
    }

    static int PodajRozmiarTablicy()
    {
        int liczbaKolumn = 0;
        int liczbaWierszy = 0;
        bool poprawnyRozmiar = false;

        do
        {
            Console.Write("Podaj rozmiar tablicy (liczba_kolumn x liczba_wierszy): ");
            string input = Console.ReadLine();

            string[] rozmiar = input.Split('x');

            if (rozmiar.Length == 2 && int.TryParse(rozmiar[0].Trim(), out liczbaKolumn) && int.TryParse(rozmiar[1].Trim(), out liczbaWierszy) && liczbaKolumn > 0 && liczbaWierszy > 0)
            {
                if (liczbaKolumn == liczbaWierszy)
                {
                    poprawnyRozmiar = true;
                }
                else
                {
                    Console.WriteLine("Liczba kolumn musi być równa liczbie wierszy. Spróbuj ponownie.");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny format rozmiaru tablicy. Spróbuj ponownie.");
            }
        } while (!poprawnyRozmiar);

        return liczbaKolumn;
    }

    static void WyswietlTablice(int[,] tablica)
    {
        int rozmiar = tablica.GetLength(0);

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}
