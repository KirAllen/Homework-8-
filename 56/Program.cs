// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Enter Rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Columns");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns]; 
CreateArray(array); 
PrintArray(array); 
GetLeastSum(array);

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,9); 
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");  
        }
     Console.WriteLine();
    }
    
}

void GetLeastSum(int[,] array)
{   
    
    int minSum = 0; // В этой переменной будет храниться минимальная сумма
    int minIndex =0; // В этой переменной будет храниться индех строки с минимальной суммой
    int[] sumArray = new int[array.GetLength(0)]; // Этот Массив будет хранить все суммы строк 
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        
        int sum = 0; 

        
        for(int j = 0; j < array.GetLength(1); j++)
        {   
             sum = sum + array[i,j];

            minSum = minSum + array[i,j]; 
        }   
          
        sumArray[i] = sum;
        minSum = sumArray[0];
    } 

    for(int h=0; h < sumArray.Length; h++)
    {
        if(minSum > sumArray[h])
        {
            minSum = sumArray[h];
            minIndex = h; 
        }
    }

    Console.WriteLine($"MinSum in Line № {minIndex + 1} = {minSum}");
}

