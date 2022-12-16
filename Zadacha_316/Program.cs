int [] mass = new int [8];
for (int i = 0; i < 8; i++)
{
    mass[i] = new Random().Next(0,2);
    // Console.Write($"{mass[i]} ");
}
Console.WriteLine($"[{string.Join(",",mass)}]");

