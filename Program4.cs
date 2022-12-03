int a;
Console.WriteLine("Введи цифру, обозначающую день недели:");
int.TryParse(Console.ReadLine(), out a);
{
  if (a == 6 || a == 7) 
  {
  Console.WriteLine("это выходной день");
  }
  else if (a > 7)
  {
    Console.WriteLine("Эта цифра не обозначает день недели");
  }
  else
  Console.WriteLine("это не выходной день");
}

