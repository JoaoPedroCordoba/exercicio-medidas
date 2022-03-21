double  cm, m, km;

Console.WriteLine("Digite aqui os Metros(m), por favor");
m = Convert.ToDouble(Console.ReadLine());

cm = m * 100;
km = m / 1000;

Console.WriteLine($"Centimetros:{cm}cm");
Console.WriteLine($"Metros:{m}m");
Console.WriteLine($"Quilometros:{km}km");