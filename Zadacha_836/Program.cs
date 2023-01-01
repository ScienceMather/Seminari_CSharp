int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int Rekyrsion(int rek)
{
    if (rek==1) return rek;
    else
    {
        Console.Write($"{Rekyrsion(rek-1)},");
        return rek;
    }
    
}

int rekyrs =GetNumber("VVedite N: ");
Rekyrsion(rekyrs);
Console.Write(rekyrs);



// double Fibonacci(int n)
// {
//     if (n==1 || n==2) return 1;
//     else return Fibonacci(n-1)+Fibonacci(n-2);
// }



// int Rekyrsion(int rek)
// {
//     if (rek==1)
//     {
//         Console.WriteLine($"{rek}");
//         return 1;
//     }
    

//     else
//     {
//         Console.WriteLine($"{rek}");
//         return Rekyrsion(rek-1);
//     }
    
// }



// int rekyrs =GetNumber("VVedite N: ");
// Rekyrsion(rekyrs);