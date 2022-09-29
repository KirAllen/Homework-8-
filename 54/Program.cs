//  Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Enter Rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Columns");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns]; 
CreateArray(array); 
PrintArray(array); 
ArangeArray(array); 
Console.WriteLine("");
Console.WriteLine("Aranged Array");
PrintArray(array); 


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

void ArangeArray(int[,] array)
{  

     for(int i = 0; i < array.GetLength(0); i++)
    {  
        
        
        for(int j = 0; j < array.GetLength(1); j++)
        {       
            for(int h = array.GetLength(1) - 1; h > j; h--)
            {
                if(array[i,h] > array[i,h-1])
                {
                    int tmp = array[i,h];  
                    array[i,h] = array[i,h-1];  
                    array[i,h-1] = tmp; 
                }
            }
        } 
    }
    
}