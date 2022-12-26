
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}



int [,] Create_duo_mass (int strok,int stolb, int f1_num ,int f2_num)
{
    int [,] rand_mass=new int[strok,stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            rand_mass[i,j]=new Random().Next(f1_num,f2_num);
        }
    }
    return rand_mass;
}

int PrintMass(int [,] mass)
{
    int count =0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i == j)
                count+=mass[i,j];
            Console.Write(mass[i,j] + "  ");
        }
    }
    // count = Convert.ToString(count);
    return count;
}

int num_i=GetNumber("Vvedite kol-vo strok: ");
int num_j=GetNumber("Vvedite kol-vo stolbtsov: ");

int [,] d_mass = Create_duo_mass(num_i,num_j, 1, 11);
int count_diagonal = PrintMass(d_mass);
Console.WriteLine();
Console.WriteLine($"Summa diagonali: {count_diagonal}");
