Console.Clear();
System.Console.WriteLine("ЗАДАЧА 1");
compareNumbers();
System.Console.WriteLine("ЗАДАЧА 2");
findMax();
System.Console.WriteLine("ЗАДАЧА 3");
CheckIfEven(2);
System.Console.WriteLine("ЗАДАЧА 4");
 dz4 ();


 static void compareNumbers (){
//Внутри класса Answer напишите метод CompareNumbers, который 
//на вход принимает два числа и выводит, какое число большее, а какое меньшее.
int a= Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
if (a>b)
System.Console.WriteLine("первое больше : " +a);
else if (a<b)
System.Console.WriteLine("второе больше : " +b);
else
System.Console.WriteLine("числа равны");
}
static void findMax(){
    int a= Convert.ToInt32(Console.ReadLine());
    int b= Convert.ToInt32(Console.ReadLine());
    int c= Convert.ToInt32(Console.ReadLine());
    int max;
    if (a>b)
    max=a;
    else if (b>c)
    max=b;
    else max=c;
    System.Console.WriteLine("большее из трёх: " + max);

    
//Внутри класса Answer напишите метод FindMax, 
//который принимает на вход три числа и выдаёт максимальное из этих чисел.

}
static void CheckIfEven(int number)
    {
      //Внутри класса Answer напишите метод CheckIfEven, 
      //который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

 number = Convert.ToInt32(Console.ReadLine()) ;

if(number % 2 == 0) 
{
    System.Console.WriteLine($"Число `{number}` чётное");
}
else
{
    System.Console.WriteLine($"Число `{number}` нечётное");
}
    }
    static void dz4 (){
      ﻿// Код, который на вход принимает число (number),
// а на выходе выводит все чётные числа от 1 до number (включительно),
// разделеные знаком табуляции.
      Console.Write ("Введите целое число: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;

for (int i = 2; i <= number; i+=2) {
    Console.Write(i + "\t");

    }
    }