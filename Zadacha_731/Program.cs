
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}



int[,] Create_duo_mass(int strok, int stolb, int f1_num, int f2_num)
{
    int[,] rand_mass = new int[strok, stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            rand_mass[i, j] = new Random().Next(f1_num, f2_num);
        }
    }
    return rand_mass;
}

void PrintMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "  ");
        }
    }
    Console.WriteLine();
}

int[,] Swap_frow_lrow(int[,] mass)
{
    int[] swapRow = new int[mass.GetLength(1)];

    for (int j = 0; j < mass.GetLength(1); j++)
    {
        swapRow[j] = mass[0, j];
        
    }
    // Console.WriteLine($"[{string.Join(",",swapRow)}]");


    for (int k = 0; k < mass.GetLength(1); k++)
    {
        mass[0, k] = mass[mass.GetLength(0)-1, k];
        mass[mass.GetLength(0)-1, k] = swapRow[k];
    }
    return mass;
}

int num_i = new Random().Next(3, 7);
int num_j = new Random().Next(3, 7);

int[,] d_mass = Create_duo_mass(num_i, num_j, -10, 11);
PrintMass(d_mass);
int[,] fl_row = Swap_frow_lrow(d_mass);
PrintMass(fl_row);

