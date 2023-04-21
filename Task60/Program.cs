//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] arrayX3 = new int[x, y, z];
CreateArray(arrayX3);
WriteArray(arrayX3);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] arrayX3)
{
  for (int i = 0; i < arrayX3.GetLength(0); i++)
  {
    for (int j = 0; j < arrayX3.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arrayX3.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arrayX3[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


void CreateArray(int[,,] arrayX3)
{
  int[] temp = new int[arrayX3.GetLength(0) * arrayX3.GetLength(1) * arrayX3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrayX3.GetLength(0); x++)
  {
    for (int y = 0; y < arrayX3.GetLength(1); y++)
    {
      for (int z = 0; z < arrayX3.GetLength(2); z++)
      {
        arrayX3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}