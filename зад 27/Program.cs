// Зад.27
// программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
n=Convert.ToInt32(Console.ReadLine());
result=0;
while (n!=0)
{result+= n %10;
n/=10;}
Console.WriteLine($"{result}");




























// int Prompt(string message)
// {System.Console.Write(message);
// string readInput =System.Console.ReadLine();
// int result=int.Parse(readInput);
// return result;}
// int SumAllDigital(int number)
// {int result=0;
// while (number>0)
// {result+=number%10;
// number=number%10;}
// return result;}
// int number=Prompt("Введите число");
// System.Console.WriteLine($"({SumAllDigital(number)})");



//int Length= number.Length;
// char i=number[Length];
//int sum=0;
//int i=0;
//while (i<Length)
//{sum=sum+number[i];
//i=i+1;}
//Console.Write(number[0]);
// Console.WriteLine($"Сумма чисел ({sum})");
//int []array = new int [length];
// int sum=0;int count=length;
// while(count<length)
// {
    //array[count]=Convert.ToInt32(N);
    //count=count-1;}
    //for (int i =0; i<length;i++)
  //sum=array[N1];
// Console.WriteLine(System.Int32 ("int []array"));};

// int Length=message.Length;
//}
// for (int i<=Length; i++; i=0)
// {Console.WriteLine(message);
// return Convert.ToInt32(Console.ReadLine());}
// double n=numA;
// double power=numB;
// int result= Convert.ToInt32(Math.Pow(n,power));
// {Console.WriteLine(result);}

