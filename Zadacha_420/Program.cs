
int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int Scan_Mass(int [] mass)
{
    int count =0;
    for (int n = 0; n < mass.Length; n++)
    {
        if (mass[n]>10 && mass[n]<99) count+=1;
    }
    return count;
}
int [] massiv = CreateMass(5,0,124);
int int_in = Scan_Mass(massiv);
Console.WriteLine($"[{string.Join(",",massiv)}] -> {int_in}");
