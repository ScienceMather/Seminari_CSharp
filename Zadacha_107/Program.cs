// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
Console.Write("Vvedite_chislo: ");
int num = int.Parse(Console.ReadLine());
if (num%7==0)
{
    if (num%23==0) Console.WriteLine("Chislo delitsya nacelo na 7 i na 23!");
}
else Console.WriteLine("Chislo ne delitsya na 7 i na 23 bez ostatka!");