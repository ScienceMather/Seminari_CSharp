
int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int [] Invertor(int [] mass)
{
    for (int n = 0; n < mass.Length; n++)
    {
        mass[n]*=-1;
    }
    return mass;
}
int size_mass = new Random().Next(5,16);
int [] massiv = CreateMass(size_mass,-10,10);
Console.WriteLine($"Nach_mass: [{string.Join(",",massiv)}]");
int [] inv_massiv =Invertor(massiv);
Console.WriteLine($"Con_mass: [{string.Join(",",inv_massiv)}].");
