int Mode_cucle(string text_cord)
{
    Console.WriteLine(text_cord);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int N = EnterData("Vvedite chislo N: ");
int rej = Mode_cucle("Vvedite rejim cikla 1 ili 2: ");
int count =1; 
int result = 0;
if (rej==1)
{
    for(int i =1;i<=N;i++)
    {
        if (count!=N)
        {
        Console.Write(Math.Pow(count,2)+",");
        count++;
        }
        else
        {
        Console.Write(Math.Pow(count,2)+".");
        count++;
        }
    }
}
if (rej==2)
{
    while (count<=N)
    {
        if (count!=N)
        {
            Console.Write(Math.Pow(count,2)+",");
            count++;
        }
        else
        {
            Console.Write(Math.Pow(count,2)+".");
            count++;
        }

    } 
}
