// выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int Numbers(int N)
{
    if (N==0|| N==1)return 1;
    else return Numbers(N-1)+Numbers(N-2);
}
for (int i=0;i<number;i++)
{
    Console.Write($" {Numbers(i)} ");
}
Console.WriteLine();