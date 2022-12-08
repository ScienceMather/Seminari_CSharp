Console.Clear();

Console.Write("Vvedite_chislo: ");
int chislo_nedeli=int.Parse(Console.ReadLine());
string Nazvanie_dnya ="";

if (chislo_nedeli==1) Nazvanie_dnya="ponedelnik";
if (chislo_nedeli==2) Nazvanie_dnya="vtornik";
if (chislo_nedeli==3) Nazvanie_dnya="sreda";
if (chislo_nedeli==4) Nazvanie_dnya="chetverg";
if (chislo_nedeli==5) Nazvanie_dnya="pyatnica";
if (chislo_nedeli==6) Nazvanie_dnya="subota";
if (chislo_nedeli==7) Nazvanie_dnya="voskresenie";

Console.Write(Nazvanie_dnya);
