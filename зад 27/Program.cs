Console.Clear();
int numA= ReadLine ("Введите число A: ");
int numB= ReadLine("Введите число B: ");
double n=numA;
double power=numB;
int result= Convert.ToInt32(Math.Pow(n,power));
{Console.WriteLine(result);}

int ReadLine (string message)
{Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());}