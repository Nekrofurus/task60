// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
Console.WriteLine("Для того чтобы создать трехмерный массив из неповторяющихся двухзначных чисел: ");
int numberX = UserInput("Введите количество элементов по оси X - ");
int numberY = UserInput("Введите количество элементов по оси Y - ");
int numberZ = UserInput("Введите количество элементов по оси X - ");
if ( numberX * numberY * numberZ > 90)
{
    Console.WriteLine("Ошибка! Размер трехмерного массива превышает количество неповторяющихся двухзначных чисел");
}
else
{
    int[] arreyAllTwoNumberElements = ArreyAllTwoNumberElements();
    Shuffle(arreyAllTwoNumberElements);
    PrintArrey3D(CreateArrey3DNumber(arreyAllTwoNumberElements, numberX, numberY, numberZ), numberX, numberY, numberZ);
}


int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] ArreyAllTwoNumberElements()
{
    int[] arrey = new int[90];
    for (int i = 0; i < 90; i++)
    {
        arrey[i] = i + 10;
    }
    return arrey;
}
void Shuffle(int[] array)
{
    var random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        var tmp = array[i];
        var rnd = random.Next(i, array.Length);
        array[i] = array[rnd];
        array[rnd] = tmp;
    }
}
int[,,] CreateArrey3DNumber(int[] arr, int x, int y, int z)
{
    int[,,] arrey3D = new int[x, y, z];
    int index = 0;
    for (int i = 0; i < arrey3D.GetLength(0); i++)
    {
        for (int j = 0; j < arrey3D.GetLength(1); j++)
        {
            for (int k = 0; k < arrey3D.GetLength(2); k++)
            {
                arrey3D[i, j, k] = arr[index];
                index++;
            }
        }
    }
    return arrey3D;
}
void PrintArrey3D(int[,,] arrey3D, int x, int y, int z)
{
    for (int i = 0; i < arrey3D.GetLength(0); i++)
    {
        for (int j = 0; j < arrey3D.GetLength(1); j++)
        {
            for (int k = 0; k < arrey3D.GetLength(2); k++)
            {
                Console.Write($"{arrey3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
