Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Pow3(int x)
{
    int i = 1;
    int result = 0;
    while (i <= x)
    {
        result = i*i*i;
        Console.Write($"{result}, ");
        i++;
    }
}

Pow3(num);