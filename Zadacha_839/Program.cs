int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int Rekyrsion(int ch,int st)
{
    if (st==1) return ch;
    else
    {
        ch=ch*Rekyrsion(ch,st-1);
        Console.Write($"{ch} ");
        return ch;
    }
    
}

int chislo =GetNumber("VVedite chislo: ");
int stepen =GetNumber("VVedite stepen: ");
int result =Rekyrsion(chislo,stepen);
// Console.WriteLine($"{result}");
