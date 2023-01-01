// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника


int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}



int[,] Create_duo_mass(int strok, int stolb, int f1_num, int f2_num)
{
    int[,] rand_mass = new int[strok, stolb];
    rand_mass[0,0]=1;
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

int[,] FillPascal(int[,] mass)
{
    // int[,] pascaltreyg = new int[mass.GetLength(1),mass.GetLength(1)];

    for (int i = 1; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (j==0)  mass[i,j]=1;
        else mass[i,j]=mass[i-1,j]+mass[i-1,j-1];
    }
    }
    // Console.WriteLine($"[{string.Join(",",swapRow)}]");
    return mass;
}

int razm = GetNumber("Vvedite razmer treyg: ");
int num_i = razm;
int num_j = razm;

int[,] d_mass = Create_duo_mass(num_i, num_j, -10, 11);
PrintMass(d_mass);
int[,] fl_row = FillPascal(d_mass);
PrintMass(fl_row);

// 0
// 00
// 000
// 0000
// 00000
// 000000
// добавить равнобедренность