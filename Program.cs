// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
System.Console.WriteLine("Решаем задачу №1");
System.Console.WriteLine();
int[,] array = new int[3,4]; // задаем размерность массива

void CreateArray() // записываем функцию создания массива
{
    for (int i = 0; i < array.GetLength(0); i++) // цикл 1: заполнение строк массива циклом 2
    {
        for (int j = 0; j < array.GetLength(1); j++) // цикл 2: заполнение значений в строках
        {
            array[i,j] = new Random().Next(1,10); // значения элементов определяются случайным образом генератором в диапазоне 1-9
        }
    }
}
CreateArray(); // запускаем функцию создания массива (создаем массив)
Console.WriteLine("Введите номер строки искомого элемента массива"); // запрашиваем с пользователя значение первой координаты элемента массива
int i1=Convert.ToInt32(Console.ReadLine()); // создаем координате 1 переменную, присваиваем ей введенное пользователем значение
Console.WriteLine("Введите номер столбца искомого элемента массива"); // запрашиваем с пользователя значение второй координаты элемента массива
int j1=Convert.ToInt32(Console.ReadLine()); // создаем координате 2 переменную, присваиваем ей введенное пользователем значение
if (i1>=array.GetLength(0)) // проверка: соответствие координаты 1 диапазону строки
{
    System.Console.WriteLine("Такого элемента нет");
}
else if(j1>=array.GetLength(1)) // проверка: соответствие координаты 1 диапазону столбца
{
    System.Console.WriteLine("Такого элемента нет");
}

else
{
    System.Console.WriteLine("Искомый элемент массива: " + array [i1,j1]);
}

// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
System.Console.WriteLine();
System.Console.WriteLine("Решаем задачу №2");
System.Console.WriteLine();
int [,] array1 = new int [3,4]; // задаем размерность массива

void CreateArray1() // записываем функцию создания массива
{
    for (int i = 0; i < array1.GetLength(0); i++) // цикл 1: заполнение строк массива циклом 2
    {
        for (int j = 0; j < array1.GetLength(1); j++) // цикл 2: заполнение значений в строках
        {
            array1[i,j] = new Random().Next(1,10); // значения элементов определяются случайным образом генератором в диапазоне 1-9
        }
    }
}

void PrintArray1()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {

            System.Console.Write(array1[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
CreateArray1(); // запускаем функцию создания массива (создаем массив)

System.Console.WriteLine("Исходный массив ");
System.Console.WriteLine();
PrintArray1(); // запускаем функцию вывода массива

for(int j = 0; j < array1.GetLength(1); j++)
    {
        int temp1=0; // задаем временные переменные хранения элементов массива
        int temp2=0; // задаем временные переменные хранения элементов массива
        temp1=array1[0,j]; // записываем элемент строки 0
        temp2=array1[array1.GetLength(0)-1 , j]; // записываем элемент последней строки
        // System.Console.WriteLine(temp1 + "   "+ temp2);
        array1[0,j]=temp2; // производим замену элемента строки 0 на элемент последней строки
        array1[array1.GetLength(0)-1 , j]=temp1; // производим замену элемента последней строки на элемент строки 0
    }
System.Console.WriteLine("Трансформированный массив");
System.Console.WriteLine(); // Пустая строка 
PrintArray1(); // выводим массив с замененными строками