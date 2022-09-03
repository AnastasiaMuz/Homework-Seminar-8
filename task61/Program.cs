//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            Console.Write(matrix [i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int columns = 4;
int firstNumber = 1;
int [,] matrix = new int [rows,columns];

int i = 0, j = 0, k;
while (i< rows*columns)
{
    j++;
    for(k = j - 1; j < columns - j + 1; k++)
    {
        matrix[j-1,k] = firstNumber++;
        i++;
    }

    for(k = j; k < rows - j + 1; k++)
    {
        matrix[k,columns - j] = firstNumber++;
        i++;
    }
    for (k = columns - j - 1; k >= j; k--)
    {
        matrix[rows - j, k] = firstNumber++;
        i++;
    }
    for (k = rows - j - 1; k >= j; k--)
    {
        matrix[columns - j,k] = firstNumber++;
        i++;
    }
}


PrintMatrix(matrix);
