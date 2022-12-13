
int EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindQuad(int x,int y)
{
    int result =0;
    if (x>0 && y>0) result = 1;
    if (x<0 && y>0) result = 2;
    if (x<0 && y<0) result = 3;
    if (x>0 && y<0) result = 4;
    return result;
}

int x = EnterData ("Vvedite koordinaty X: ");
int y = EnterData ("Vvedite koordinaty Y: ");

int FindNum = FindQuad(x,y);
Console.WriteLine($"Vashi Coordinati nahodyatsya v {FindNum} kvadrate");
