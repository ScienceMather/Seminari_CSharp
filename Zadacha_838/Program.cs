int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int Rekyrsion(int rek)
{
    if (rek==0) return rek;
    else
    {
        rek=rek%10+Rekyrsion(rek/10);
        Console.Write($"{rek} ");
        return rek;
    }
    
}

int rekyrs =GetNumber("VVedite N: ");
int result =Rekyrsion(rekyrs);
// Console.WriteLine($"{result}");
