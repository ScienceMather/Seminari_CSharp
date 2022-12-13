
string EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    string number = Console.ReadLine();
    return number;
}

string FindQuad(string num_chet)
{
    string result ="";
    
    if (num_chet == "1") result = "x>0, y>0";
    if (num_chet == "2") result = "x<0, y>0";
    if (num_chet == "3") result = "x<0, y<0";
    if (num_chet == "4") result = "x>0, y<0";
    return result;
}

string num_chet = EnterData ("Vvedite nomer chetverti: ");

string FindNum = FindQuad(num_chet);
Console.WriteLine($"Coordinati kvadrata nahodyatsya v {FindNum} intervale");
