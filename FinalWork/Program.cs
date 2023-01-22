/* Написать программу, которая из имеющегося
массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести
с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключетльно массивами. */

Console.WriteLine("Введите значения массива через пробел");
string[] startArray = CustomArray();
int nOfCutting = 3;
string[] finalArray = ArrangeArrayOfElementWithLongLessThatCertainNumber(startArray, nOfCutting);
PrintArray(finalArray);

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

// Организация массива с элементами нужной длины
string[] ArrangeArrayOfElementWithLongLessThatCertainNumber(string[] customersArray, int numbOfNeedLength)
{
    string[] final = new string[CounterOfElementsNeedLong(customersArray, numbOfNeedLength)];
    for (int i = 0, j = 0; i < customersArray.Length; i++)
    {
        if(customersArray[i].Length <= numbOfNeedLength)
        {
            final[j] = customersArray[i];
            j++;
        }
    }
    return final;
}

// Печать массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}