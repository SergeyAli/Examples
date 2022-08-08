/* 
string [,] table = new string[2,5];
//String.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]


table [1,2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
   
}
*/

// void PrintArray(int[,] matr)
//     {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         System.Console.Write($"{matr[i,j]} ");
//     }  
//     System.Console.WriteLine();
//     }
// }

// void FillArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }


// int [,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};
void PrintImage(int[,] image) // подрограмма которая не выводить нули из масива , а единицы еняет на плюс
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //System.Console.Write($"{image[i,j]} ");
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }  
        System.Console.WriteLine();
    }
}
void FillImage (int row, int col) // подпрагамма закрашивания аргументы - row - строка col - пиксел
{
    if (pic[row, col] ==0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}


PrintImage(pic);
FillImage(10, 10);
PrintImage(pic);

