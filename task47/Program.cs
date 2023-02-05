/*Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Clear();
double randomDouble(int minDouble, int maxDouble)
{
    double randomNumbers=new Random().NextDouble()*(maxDouble-minDouble)*maxDouble;
      return randomNumbers;
}
double[,]GetArray(int m, int n, int minDouble, int maxDouble)
{
     double[,] result = new double[m, n];
     Random rand = new Random();
     for (int i = 0; i < m; i++)
     { for (int j = 0; j < n; j++)
     {
        result[i,j]= randomDouble(minDouble,maxDouble);
     }
        
     }
     return result;

}
void PrintArray(double[,]inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", inArray[i, j]);
        }
        Console.WriteLine();
    }

}
double[,]array=GetArray(5,5,-2,2);
PrintArray(array);
