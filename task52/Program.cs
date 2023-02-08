/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();

int[,]GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result=new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          result[i,j]= new Random().Next(minValue,maxValue);
        }  
        
    }
    return result;
}
void PrintArray(int[,]inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
void average(int[,]array1)
{
    double sum0=0;
    double sum1=0;
    double sum2=0;
    
     for (int j = 0; j < array1.GetLength(0); j++)
     {         
        
        sum0=sum0+array1[j,0];
        sum1 = sum1+array1[j,1];
        sum2= sum2+array1[j,2];
       
     }
     Console.WriteLine($"Сумма первого столбца равна {sum0}");
     Console.WriteLine($"Сумма второго столбца равна {sum1}");
     Console.WriteLine($"Сумма третьего столбца равна {sum2}");
     double average0=sum0/array1.GetLength(0);
     Console.WriteLine($"Ср.арифм.sum0= {average0}");
     double average1=sum1/array1.GetLength(0);
     Console.WriteLine($"Ср.арифм.sum1={average1}");
     double average2=sum2/array1.GetLength(0);
     Console.WriteLine($"Ср.арифм.sum2={average2}");
             
}    
int[,]array=GetArray(5,3,0,10);
PrintArray(array);
average(array);
