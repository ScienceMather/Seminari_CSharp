int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}

bool Len_Triangle(int aa,int bb,int cc)
{
    bool result=false;
    if (aa<bb+cc && bb<aa+cc && cc<bb+aa) result=true;
    return result;
}

int a = GetNumber("Vvedite chislo a: ");
int b = GetNumber("Vvedite chislo b: ");
int c = GetNumber("Vvedite chislo c: ");
if (Len_Triangle(a,b,c)) Console.Write($"Treugolnic so storonami {a} {b} {c} sushestvuet");
else Console.Write($"Treugolnic so storonami {a} {b} {c} ne sushestvuet");

