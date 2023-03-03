// Зад.25
// Напиcать цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int numA= ReadLine ("Введите число A: ");
int numB= ReadLine("Введите число B: ");
int ReadLine (string message)
{Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());}
double n=numA;
double power=numB;
int result= Convert.ToInt32(Math.Pow(n,power));
{Console.WriteLine(result);}
