

int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int [] Invert_mass(int [] mass)
{
    int srez = mass.Length/2+mass.Length%2;
    
    for (int i =0;i<srez;i++)
    {
        int swap =mass[i];
        mass[i]=mass[mass.Length-i-1];
        mass[mass.Length-i-1]=swap;
    }
    return mass;
}

int size_mass = new Random().Next(5,11);
int [] massiv = CreateMass(size_mass,1,5);
Console.WriteLine($"[{string.Join(",",massiv)}]");
int [] SM = Invert_mass(massiv);
Console.WriteLine($"[{string.Join(",",SM)}]");

