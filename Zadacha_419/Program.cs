
int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

void Check_Num(int [] mass)
{
    Console.WriteLine("Vvedite iskomoe chislo: ");
    int num = int.Parse(Console.ReadLine());
    bool result =false;
    for (int n = 0; n < mass.Length; n++)
    {
        if (mass[n]==num)
        {
            result =true;
            break;
        }
    }
    if (result) Console.WriteLine($"Chislo {num} nahoditsya v [{string.Join(",",mass)}]");
    else Console.WriteLine($"Chislo {num} ne nahoditsya v [{string.Join(",",mass)}]");
}
int size_mass = new Random().Next(5,16);
int [] massiv = CreateMass(size_mass,-10,10);
Console.WriteLine($"[{string.Join(",",massiv)}]");
Check_Num(massiv);

