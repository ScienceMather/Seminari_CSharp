
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}



int [,] Create_duo_mass (int strok,int stolb)
{
    int [,] rand_mass=new int[strok,stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            rand_mass[i,j]=i+j;
        }
    }
    return rand_mass;
}

void PrintMass(int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i,j] + "  ");
        }
    }
}

int num_i=GetNumber("Vvedite kol-vo strok: ");
int num_j=GetNumber("Vvedite kol-vo stolbtsov: ");

int [,] d_mass = Create_duo_mass(num_i,num_j);
PrintMass(d_mass);
