// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Enter Rows for first Matrix");
int firstrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Columns for First Matrix");
int firstColumns = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[firstrows, firstColumns]; 

Console.WriteLine("Enter Rows for second Matrix");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Columns for second Matrix");
int secondColumns = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = new int[secondRows, secondColumns]; 
int[,] multiplyArr = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)]; 

if(firstColumns == secondRows)
{
Console.WriteLine("First Matrix");
CreateFirstMatrix(firstMatrix); 
PrintArray(firstMatrix);

Console.WriteLine();
Console.WriteLine("Second Matrix");
CreateSecondMatrix(secondMatrix);
PrintArray(secondMatrix);

Console.WriteLine(""); 
MultiplyMatrix(firstMatrix, secondMatrix); 
Console.WriteLine("multiply Array");
PrintArray(multiplyArr); 
}
else
{
    Console.WriteLine("Error");
}


void CreateFirstMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,9); 
        }
    }
}

void CreateSecondMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,9); 
        }
    }
}

void MultiplyMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    for(int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < secondMatrix.GetLength(0); j++)
        {
            for(int k = 0; k < secondMatrix.GetLength(1); k++)
            {
                multiplyArr[i,k] += firstMatrix[i,j] * secondMatrix[j,k]; 
            }
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
