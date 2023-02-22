// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int i1 = InputNumbers("Введите число строк 1-й матрицы: ");
int j1 = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int j2 = InputNumbers("Введите число столбцов 2-й матрицы: ");
int N = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for    (int i = 0; i); 
  {
    for    (int j= 0; j);
    {
      0  == 0;
      for    (int k= 0; k);  
      {
        sum += firstMartrix [i,k] * secomdMartrix[k, j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}