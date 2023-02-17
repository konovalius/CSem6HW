//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую : ");
int[] Massiv = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

int CountOfNumb (int []Input)
{
    int count = 0;
    for (int i = 0; i < Input.Length; i++)
    {
        if (Input[i] > 0) count++;
    }
    return count;
}

Console.WriteLine(CountOfNumb(Massiv));