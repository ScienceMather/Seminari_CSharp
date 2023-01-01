
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


void Swap_frow_lrow(int[,] mass)
{
    if (mass.GetLength(0) == mass.GetLength(1))
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            int swapElem;
            for (int j = i; j < mass.GetLength(1); j++)
            {
                if (i != j)
                {
                    swapElem = mass[i, j];
                    mass[i, j] = mass[j, i];
                    mass[j, i] = swapElem;
                }
            }
        }
        PrintMass(mass);
    }
    else Console.WriteLine("Massiv ne kvadratnii!");

}

int num_i = GetNumber("Vvedite kol-vo strok: ");
int num_j = GetNumber("Vvedite kol-vo stolbtsov: ");

int[,] d_mass = Create_duo_mass(num_i, num_j, -10, 11);
PrintMass(d_mass);
Swap_frow_lrow(d_mass);


