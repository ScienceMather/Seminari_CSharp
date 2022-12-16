
int SummNumb(int a)
{
    int count =0;
    while (true)
    {
        if (a!=0)
        {
            a= a/10;
            count++;
        }
        else break;
    }
    return count;

}


int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int chislo = GetNumber("Vvedite chislo: ");
int schetchik = SummNumb(chislo);
Console.WriteLine($"dlina chisla = {schetchik}");
