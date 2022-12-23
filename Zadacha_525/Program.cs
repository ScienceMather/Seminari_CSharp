int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


int[] Fibonacci(int dec)
{
    int [] mass=new int[dec];
    mass[0] =0;
    mass[1] =1;
    for (int i = 2; i < dec; i++)
    { 
        int fibo_num= mass[i-2]+mass[i-1];
        mass[i]=fibo_num;
    }
    return mass;
}

int num = GetNumber("Vvedite kol-vo chislo: ");
int[] fibo=Fibonacci(num);
Console.WriteLine($"Chisla Fibonacci do {num} chisla: [{string.Join(",",fibo)}]");
