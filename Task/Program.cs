/*Задача: Написать программу которая из имеющегося массива строк формирует массив из
 строк длина которых меньше, либо равна трём символам. Массив можно задать 
 на старте, либо ввести пользователем.
*/

string[] arrayFirst = new string[] { "876", "msa", "hello", "world", "vdv", "12" };
string[] arraySecond = new string[arrayFirst.Length];

void SecondArray(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrayFirst, arraySecond);
PrintArray(arraySecond);