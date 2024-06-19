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
        int[,] digits = new int[3, 6];
        int quantityRows = digits.GetLength(0);
        int qyantityColumns = digits.GetLength(1);
        int minValueInDigits = 0;
        int maxValueInDigits = 10;
        int rowSumm = 0;
        int numberRowForSumm = 1;
        int columnProduct = 1;
        int numberColumnForProduct = 0;
        Random random = new Random();

        for (int i = 0; i < quantityRows; i++)
        {
            for (int j = 0; j < qyantityColumns; j++)
                digits[i, j] = random.Next(minValueInDigits, maxValueInDigits);
        }

        for (int i = 0; i < quantityRows; i++)
        {
            for (int j = 0; j < qyantityColumns; j++)
                Console.Write(digits[i, j]);

            Console.WriteLine();
        }

        for (int j = 0; j < qyantityColumns; j++)
            rowSumm += digits[numberRowForSumm, j];

        int rowForShow = numberRowForSumm + OffsetForShow;
        Console.WriteLine();
        Console.WriteLine("Сумма чисел строки № " + rowForShow + " = " + rowSumm);

        for (int i = 0; i < quantityRows; i++)
            columnProduct *= digits[i, numberColumnForProduct];

        int columnForShow = numberColumnForProduct + OffsetForShow;
        Console.WriteLine("Произведение чисел колонки № " + columnForShow + " = " + columnProduct);
    }
}
