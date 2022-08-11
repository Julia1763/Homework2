Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int num2 = num/10;
Console.WriteLine($"Вторая цифра числа {num} является {num2%10}");
