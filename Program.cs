// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] massiv = new int[3, 4];
Zapolnenie(massiv);
PrintMass(massiv);
Sortirovka(massiv);
Console.WriteLine();
PrintMass(massiv);

void Zapolnenie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Sortirovka(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"\nВведите размер массива m x n");
int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

int minSum = 0;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLine(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой элементов ({sum})");

int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int Input(string input)
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
      array[i, j] = new Random().Next(0, 9);
    }
  }
}

void PrintArray (int[,] array)
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



// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine($"\nВведите размеры матриц:");
int m = Input("Введите число строк 1-й матрицы: ");
int n = Input("Введите число столбцов 1-й матрицы и строк 2-й: ");
int p = Input("Введите число столбцов 2-й матрицы: ");


int[,] oneMass = new int[m, n];
CreateArray(oneMass);
Console.WriteLine($"\nПервая матрица:");
WriteArray(oneMass);

int[,] twoMass = new int[n, p];
CreateArray(twoMass);
Console.WriteLine($"\nВторая матрица:");
WriteArray(twoMass);

int[,] result = new int[m,p];

product(oneMass, twoMass, result);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(result);

void product(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int Input(string input)
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
      array[i, j] = new Random().Next(0, 9);
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



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = Input("Введите X: ");
int y = Input("Введите Y: ");
int z = Input("Введите Z: ");
Console.WriteLine($"");

int[,,] array3x = new int[x, y, z];
CreateArray(array3x);
WriteArray(array3x);

int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3)
{
  int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3.GetLength(0); x++)
  {
    for (int y = 0; y < array3.GetLength(1); y++)
    {
      for (int z = 0; z < array3.GetLength(2); z++)
      {
        array3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}




// Задача 62: Заполните спирально массив 4 на 4.

int n = 4;
int[,] mass = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= mass.GetLength(0) * mass.GetLength(1))
{
  mass[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < mass.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= mass.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > mass.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(mass);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}