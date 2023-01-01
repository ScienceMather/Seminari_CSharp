// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


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

int[,] del_min_row_col(int[,] mass)
{
    int min = mass[0, 0];
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] < min)
            {
                min = mass[i, j];
                min_i = i;
                min_j = j;
            }
            // Console.Write(mass[i, j] + "  ");
        }
    }
    Console.WriteLine();

    Console.WriteLine("min " + min +" "+ min_i +" "+min_j);
    int[,] slice_mass = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];
    int counti=0;
    

    for (int i = 0; i < slice_mass.GetLength(0)+1; i++)
    {
        // if (min_i==i) starti=1;
        if (i == min_i)
        {
            continue;
        }
        else
        {
            int countj=0;
            for (int j = 0; j < slice_mass.GetLength(1)+1; j++)
            {
                // if (min_j==j) startj=1;                
                if (j == min_j)
                {
                    continue;
                }
                else
                {
                    slice_mass[counti, countj] = mass[i, j];
                    countj+=1;
                }
                // sdvigj=0;
            }
            counti+=1;
        }
    }
    return slice_mass;
}


int num_i = GetNumber("Vvedite kol-vo strok: ");
int num_j = GetNumber("Vvedite kol-vo stolbtsov: ");


int[,] d_mass = Create_duo_mass(num_i, num_j, 1, 11);
PrintMass(d_mass);
int[,] fl_row = del_min_row_col(d_mass);
PrintMass(fl_row);
