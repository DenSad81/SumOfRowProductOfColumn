using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const int OffsetForShow = 1;
        int[,] array = new int[3, 6];
        int arrayRows = array.GetLength(0);
        int arrayColumns = array.GetLength(1);
        int minValueInArray = 0;
        int maxValueInArray = 10;
        int rowSumm = 0;
        int rowForSumm = 1;
        int columnProduct = 1;
        int columnForProduct = 0;
        Random random = new Random();

        for (int i = 0; i < arrayRows; i++)
        {
            for (int j = 0; j < arrayColumns; j++)
                array[i, j] = random.Next(minValueInArray, maxValueInArray);
        }

        for (int i = 0; i < arrayRows; i++)
        {
            for (int j = 0; j < arrayColumns; j++)
                Console.Write(array[i, j]);

            Console.WriteLine();
        }

        for (int j = 0; j < arrayColumns; j++)
            rowSumm += array[rowForSumm, j];

        Console.WriteLine();
        Console.WriteLine("Сумма чисел строки № " + (rowForSumm + OffsetForShow) + " = " + rowSumm);

        for (int i = 0; i < arrayRows; i++)
            columnProduct *= array[i, columnForProduct];

        Console.WriteLine("Произведение чисел колонки № " + (columnForProduct + OffsetForShow) + " = " + columnProduct);
    }
}
