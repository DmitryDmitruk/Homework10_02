/* Задача 50: Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.Clear();

int[,]GetArray(int m, int n,int minValue, int maxValue)
{
    int[,] result = new int[m, n];
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
            Console.Write($" {inArray[i,j]} \t ");
       }
       Console.WriteLine(); 
    }
}
void positionOf(int [,]array1,int y, int x)
 

{
    if (y<array1.GetLength(0)&&x<array1.GetLength(1))
    {
        Console.WriteLine($"Элемент с данными индексами равен  {array1[y,x]}");
        
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
        
    }
}
    
int[,]array=GetArray(3,4,-5,5);
PrintArray(array);
Console.WriteLine("Введите позицию элемента y ");
int y1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию элемента x");
int x1=int.Parse(Console.ReadLine()!);
Console.WriteLine();
positionOf(array,y1,x1);


