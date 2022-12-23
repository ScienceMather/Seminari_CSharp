int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}


string Convert_digit(int dec)
{
    string ans ="";
    int next=0;
    int ost=0;
    while (next!=1)
    {
        next=dec/2;
        ost =dec%2;
        dec=next;
        ans=Convert.ToString(ost)+ans;
    }
    ans="1"+ans;
    return ans;
    
}


int deca = GetNumber("Vvedite desyatichnoe chislo: ");
string  bin_num=Convert_digit(deca);
Console.WriteLine($"Dvoichnoe chislo {deca} ravno {bin_num}");
