// Зад.27
// программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
string number =Console.ReadLine();
int result=int.Parse(readInput);
return result;
int SumAllDigital(int number)
{int result=0;
while (number>0)
{result+=number%10;
number=number%10;}
return result;}
Console.WriteLine($"(SumAllDigital({number}))");
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

