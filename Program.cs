int a;
Console.WriteLine("Введите трёхзначное число");
int.TryParse(Console.ReadLine(), out a);
if (Math.Floor(Math.Log10(a)) <= 1) // if (a.ToString().Length <= 1) - Альтернативный вариант решения
{
    Console.WriteLine("Третья цифра не наблюдается");
}
else
{
    Console.WriteLine("Третья цифра " + a.ToString()[2]);
}
Console.ReadKey(); 
