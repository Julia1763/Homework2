Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number>99)
{
  Console.WriteLine((number/100)%10);
}
else
{
  Console.WriteLine("У заданного числа отсутствует третья цифра");    
}