Console.Clear();

Console.Write("Vvedite_chislo A: ");
int number_A=int.Parse(Console.ReadLine());

Console.Write("Vvedite_chislo B: ");
int number_B=int.Parse(Console.ReadLine());

if (number_A==Math.Pow(number_B,2))
{
    Console.Write($"Chislo {number_A} kvadrat chisla {number_B}");
}
else
{
    Console.Write($"Chislo {number_A} ne kvadrat chisla {number_B}");
}
