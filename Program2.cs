int a;
Console.WriteLine("Введи трёхзначное число: ");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine(a);
string stringNumber = Convert.ToString(a);
Console.WriteLine("вторая цифра этого числа : " + stringNumber[1]);
