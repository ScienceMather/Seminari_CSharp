
// int [] sumass = new int [12];
// int sum_N =0;
// int sum_P =0;
// for (int i = 0; i < sumass.Length; i++)
// {
//     sumass[i] = new Random().Next(-9,10);  
// }
// for (int n = 0; n < sumass.Length; n++)
//     {
//         if (sumass[n]<0) sum_N=sum_N+sumass[n];
//         if (sumass[n]>0) sum_P=sum_P+sumass[n];
//     }
// Console.WriteLine($"[{string.Join(",",sumass)}]");
// Console.WriteLine($"Summ_Pol: {sum_P}, Summ_Neg: {sum_N}.");

int[] CreateMass(int len, int start,int end)
{
    int [] sumass= new int [len];
    for (int i = 0; i < len; i++)
    {
        sumass[i] = new Random().Next(start,end+1);
    }
    return sumass;
}

int Summator(int [] mass, bool ans)
{
    int summer=0;
    for (int n = 0; n < mass.Length; n++)
    {
        if (ans) if (mass[n]<0) summer+=mass[n];
        if (ans == false) if (mass[n]>0) summer+=mass[n];
    }
    return summer;
}

int [] massiv = CreateMass(12,-9,9);
int  Summ_Neg =Summator(massiv, true);
int  Summ_Pol =Summator(massiv, false);

Console.WriteLine($"[{string.Join(",",massiv)}]");
Console.WriteLine($"Summ_Pol: {Summ_Pol}, Summ_Neg: {Summ_Neg}.");
