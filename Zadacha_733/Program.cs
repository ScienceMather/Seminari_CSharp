// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза





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


// int[] Convert_one_mass(int[,] mass)
// {
//     int len_cucle=mass.GetLength(0) * mass.GetLength(1);
//     int[] Convert_mass = new int[len_cucle];
//     for (int k = 0; k < len_cucle; k++)
//     {
//         for (int i = 0; i < mass.GetLength(0); i++)
//         {
//             for (int j = i; j < mass.GetLength(1); j++)
//             {
//                 Convert_mass[k]=mass[i,j];
//             }
//         }
//     }
//     return Convert_mass;
// }

int [] PrintElemCount(int[,] mass)
{
    int [] countmass=new int[10];
    for (int k = 0; k < mass.GetLength(0)*mass.GetLength(1); k++)
    {
        for (int i = 0; i <  mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (mass[i,j]==j) countmass[k]+=1;
            }
        }
    }
    return countmass;
}

int num_i = GetNumber("Vvedite kol-vo strok: ");
int num_j = GetNumber("Vvedite kol-vo stolbtsov: ");
int[,] d_mass = Create_duo_mass(num_i, num_j, 1, 11);
PrintElemCount(d_mass);


// сделал задачу только для двух мерногоб массива попробовать сделать для универсалтной программы
// задачу не сделал
// сделать нормальный сортированный вывод