// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.Write("Vvedite_chislo: ");
int num1=int.Parse(Console.ReadLine());

Console.Write("Vvedite_chislo: ");
int num2=int.Parse(Console.ReadLine());
int result = 0;
if (num1*num1==num2 || num2*num2==num1) result =1;
if (result==1) Console.WriteLine("Odno chislo kvadrat drygogo");
else Console.WriteLine("Chisla ne peresekautsya kvadratami!");
