
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


void PrintMass(int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i%2!=0 && j%2!=0)
                mass[i,j]=mass[i,j]*mass[i,j];
            Console.Write(mass[i,j] + "  ");
        }
    }
}

int num_i=GetNumber("Vvedite kol-vo strok: ");
int num_j=GetNumber("Vvedite kol-vo stolbtsov: ");

int [,] d_mass = Create_duo_mass(num_i,num_j, 0, 6);
PrintMass(d_mass);



// int [,] Create_duo_mass (int strok,int stolb, int f1_num ,int f2_num)
// {
//     int [,] rand_mass=new int[strok,stolb];
//     for (int i = 0; i < strok; i++)
//     {
//         for (int j = 0; j < stolb; j++)
//         {
//             if (i%2==0 && j%2==0)
//                 rand_mass[i,j]=rand_mass[i,j]*rand_mass[i,j];
//         }
//     }
//     return rand_mass;
// }
