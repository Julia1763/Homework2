Console.WriteLine("Введите цифру: ");
int days = int.Parse(Console.ReadLine());
if (days>5)
{
  Console.WriteLine("Выходной");  
  if (days>7)
  {
    Console.WriteLine("День недели под таким номером отсутствует"); 
  }
}
else
{
   Console.WriteLine("Не является выходным");
}