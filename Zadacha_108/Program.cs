// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.Write("Vvedite_chislo: ");
int number1=int.Parse(Console.ReadLine());

Console.Write("Vvedite_chislo: ");
int number2=int.Parse(Console.ReadLine());
int result = 0;
if (number1*number1==number2) result =1;
if (number2*number2==number1) result =1;
if (result==1) Console.WriteLine("Odno chislo kvadrat drygogo");
else Console.WriteLine("Chisla ne peresekautsya kvadratami!");
