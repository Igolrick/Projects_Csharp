namespace MergeSort;
using System;


class MergeSort
{
    //Hauptmethode zum Sortieren
    static void Sort(int[] array, int left, int right)
    {
        if (left < right)
        {

            int middle = (left + right) / 2;

            Sort(array, left, middle);

            Sort(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }
    //Methode zum Zusammenführen zweier sortierter Teilarrays
    static void Merge(int[] array, int left, int middle, int right)
    {
        //grösse berechnen
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // temp array
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        //daten in temp. Arrays kopieren
        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = array[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = array[middle + 1 + j];
        }

        int indexLeft = 0;
        int indexRight = 0;
        int indexMerged = left;
        // vergleichen und zusammenführen
        while (indexLeft < n1 && indexRight < n2)
        {
            if (leftArray[indexLeft] <= rightArray[indexRight])
            {
                array[indexMerged] = leftArray[indexLeft];
                indexLeft++;
            }
            else
            {
                array[indexMerged] = rightArray[indexRight];
                indexRight++;
            }
            indexMerged++;
        }
        // restliche Elemente kopieren
        while (indexLeft < n1)
        {
            array[indexMerged] = leftArray[indexLeft];
            indexLeft++;
            indexMerged++;
        }

        while (indexRight < n2)
        {
            array[indexMerged] = rightArray[indexRight];
            indexRight++;
            indexMerged++;
        }
    }
    // Hilfsmethode zum Ausgeben des Arrays
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] + " ");
        }
        Console.WriteLine();
    }
    //Beispiel
    static void Main()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Unsortiertes Array");
        PrintArray(array);

        Sort(array, 0, array.Length - 1);
        Console.WriteLine("\nSortiertes Array:");
        PrintArray(array);
    }
}
