
int SummNumb(int a)
{
    int pro =1;
    for (int i = 1; i <=a; i++) pro= pro*i;
    return pro;
}


int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}



int chislo = GetNumber("Vvedite chislo: ");
int prov = SummNumb(chislo);
Console.WriteLine($"Proizvedenie: {prov}");
