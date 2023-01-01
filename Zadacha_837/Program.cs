int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int Rekyrsion(int start,int end)
{
    if (start==end) return start;
    else
    {
        Console.Write($"{Rekyrsion(start,end-1)},");
        return end;
    }
    
}

int start =GetNumber("VVedite SN: ");
int end =GetNumber("VVedite EN: ");
Rekyrsion(start,end);
Console.Write(end);