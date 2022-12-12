int chislo = new Random().Next(10,100);
Console.WriteLine(chislo);
int numa = chislo%10;
int numb = chislo/10;
double max = numa;
if (numa<numb) max =numb;
Console.WriteLine(max);