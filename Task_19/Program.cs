Console.Write("Введите пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num.ToString().Length != 5)
{
    Console.Write("Не верный ввод данных! Введите пятизначное целое число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int reverse(int x)
{
    int lenX = x.ToString().Length;
    int a = 0;
    int i = 0;
    int f = 10000;
    while (i <= lenX)
    {
        a = a + (x % 10) * f;
        f = f / 10;
        x = x / 10;
        i++;
    }
    return a;
}

int num2 = reverse(num);
if (num == num2) Console.WriteLine("Число является палиндромом!");
else Console.WriteLine("Число не является палиндромом!");