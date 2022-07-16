Console.WriteLine("Введите координаты первой точки.");
Console.Write("x = ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки.");
Console.Write("x = ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int bz = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
Console.WriteLine($"Расстояние между точками равно: {d}");