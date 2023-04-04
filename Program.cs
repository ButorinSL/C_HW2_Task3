// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message) // int - тип возвращаемого значения, ReadInt - название функции, message - параметр
    {
    Console.Write($"{message} >"); // Вызов функции печати в консоль
    int value = Convert.ToInt32(Console.ReadLine()); // Ввод строки из консоли и преобразование в целое
    return value; // Возвращаемое значение
    }

int number = ReadInt("Введите число"); // Вызов функции ввода числа
if (number < 1 || number > 7)
{
    Console.WriteLine($"Введен не день недели");
}
else
{
    if (number > 5)
        {
            Console.WriteLine($"Это выходной");
        }
    else
    {
    Console.WriteLine($"Это рабочий день");
    }
}

