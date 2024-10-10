int n1 = 3 + 4 * 2;
Console.WriteLine(n1);
Console.WriteLine("-------------------");

int n2 = (3 + 4) * 2;
Console.WriteLine(n2);
Console.WriteLine("-------------------");

int n3 = 17 % 3;
Console.WriteLine(n3);
Console.WriteLine("-------------------");

double n4 = 10.0 / 8.0;
Console.WriteLine(n4);
Console.WriteLine("-------------------");

double a = 1.0, b = -3.0, c = -4.0;
Console.WriteLine("a, b, c");
Console.WriteLine("-------------------");

double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
Console.WriteLine(delta);
Console.WriteLine("-------------------");

double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
Console.WriteLine($"x1: {x1}, x2: {x2}");

