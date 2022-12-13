
int EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double FindQuad(int Ax,int Ay,int Bx,int By)
{
    double result =(Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)));
    // int res =int.Parse(result);
    return result;
}

int Num_Ax = EnterData  ("Vvedite coordinaty x: ");
int Num_Ay = EnterData  ("Vvedite coordinaty y: ");
int Num_Bx = EnterData  ("Vvedite coordinaty x: ");
int Num_By = EnterData  ("Vvedite coordinaty y: ");


double FindNum = Math.Round(FindQuad(Num_Ax,Num_Ay,Num_Bx,Num_By),2);
Console.WriteLine($"Rasstoyanie mezjdy tochkami ravno {FindNum}");
