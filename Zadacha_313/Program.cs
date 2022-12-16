
int SummNumb(int a)
{
    int sumka =0;
    for (int i = 0; i <=a; i++)
    {
        sumka= sumka+i;
    }
    return sumka;

}


int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}



int chislo = GetNumber("Vvedite chislo: ");
int summ = SummNumb(chislo);
Console.WriteLine($"Summa:{summ}");
