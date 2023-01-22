/* Написать программу, которая из имеющегося
массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести
с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключетльно массивами. */

Console.WriteLine("Введите значения массива через пробел");
string[] startArray = CustomArray();

// Разделение массива пользователя на отдельные элементы
string[] CustomArray()
{
    return Console.ReadLine().Split(" ");
}

// Счетчик элементов нужной длины
int CounterOfElementsNeedLong (string[] customesrArray, int numbOfNeedLength)
{
    int count = 0;
    for (int i = 0; i < customesrArray.Length; i++)
    {
        count++;
    }
    return count;
}
