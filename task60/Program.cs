// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int rowsCount, int columnsCount, int pagesCount)
{
    int[,,] matrix = new int[rowsCount, columnsCount, pagesCount];

    for (int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write ("Введите новое двузначное число: ");
                matrix[i, j, k] = Convert.ToInt32(Console.ReadLine());;
            }
            
        }
    }
    return matrix;

}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix [i, j, k] + " (" + i +", "+ j + ", " + k +") ");
            }
            Console.WriteLine();
        }
        
    }
}
int[,,] matrix = FillMatrix(2,2,2);
PrintMatrix(matrix);