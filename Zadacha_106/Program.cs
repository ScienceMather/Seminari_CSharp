// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

Console.Write("Vvedite_chislo: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Vvedite_chislo: ");
int b = int.Parse(Console.ReadLine());
int result = a%b;
if (result==0) Console.WriteLine("Chislo delitsya nacelo!");
else Console.WriteLine($"Chislo ne kratno, ostsok {result}.");