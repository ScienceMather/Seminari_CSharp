int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}

int[] Add_Mass(int len)
{
    int [] mass=new int[len];
    for (int i = 0; i < mass.Length; i++)
    {
         mass[i] = new Random().Next(0,11);
    }
    return  mass;
}

int[] Copy_Mass(int [] cop_mass)
{
    int [] mass=new int[cop_mass.Length];
    for (int i = 0; i < cop_mass.Length; i++)
    { 
        mass[i]= cop_mass[i];
    }
    return mass;
}


int num_mass = GetNumber("Vvedite dliny massiva: ");
int [] furst_mass=Add_Mass(num_mass);
int[] Copi_mass=Copy_Mass(furst_mass);
Console.WriteLine($"Obichnii massiv: [{string.Join(",",furst_mass)}]");
Console.WriteLine($"Copirovannii massiv: [{string.Join(",",Copi_mass)}]");
