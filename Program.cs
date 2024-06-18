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
        int minValueInArray = 0;
        int maxValueInArray = 9;
        int summDigitInRow = 0;
        int rowForSumm = 1;
        int productDigitInColumn = 1;
        int columnForProduct = 0;
        Random random = new Random();

        int arrayQuantityOfRow = array.GetLength(0);
        int arrayQuantityOfColumn = array.GetLength(1);

        for (int i = 0; i < arrayQuantityOfRow; i++)
        {
            for (int j = 0; j < arrayQuantityOfColumn; j++)
                array[i, j] = random.Next(minValueInArray, maxValueInArray);
        }

        for (int i = 0; i < arrayQuantityOfRow; i++)
        {
            for (int j = 0; j < arrayQuantityOfColumn; j++)
                Console.Write(array[i, j]);

            Console.WriteLine();
        }

        for (int j = 0; j < arrayQuantityOfColumn; j++)
            summDigitInRow += array[rowForSumm, j];

        Console.WriteLine();
        Console.WriteLine("Сумма чисел строки № " + (rowForSumm + OffsetForShow) + " = " + summDigitInRow);

        for (int i = 0; i < arrayQuantityOfRow; i++)
            productDigitInColumn *= array[i, columnForProduct];

        Console.WriteLine("Произведение чисел колонки № " + (columnForProduct + OffsetForShow) + " = " + productDigitInColumn);
    }
}
