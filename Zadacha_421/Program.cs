

int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int [] Pr_ind(int [] mass)
{
    int srez = mass.Length/2+mass.Length%2;
    int [] mass_Pr =new int[srez];
    for (int i =0;i<srez;i++)
    {
        int ind =mass[i]*mass[mass.Length-i-1];
        mass_Pr[i]=ind;
    }
    return mass_Pr;
}

int size_mass = new Random().Next(5,11);
int [] massiv = CreateMass(size_mass,1,5);
Console.WriteLine($"[{string.Join(",",massiv)}]");
int [] PR = Pr_ind(massiv);
Console.WriteLine($"[{string.Join(",",PR)}]");

