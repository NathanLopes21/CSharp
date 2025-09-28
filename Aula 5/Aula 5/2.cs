
Console.WriteLine("Quantidade em Kg do Morango do Amor");
double morango = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade em Kg da Maça do Odio");
double maca  = double.Parse(Console.ReadLine());

double precoMorango = (morango <= 5) ? 2.50 : 2.20;
double precoMaca = (maca <= 5) ? 1.80 : 1.50;

double totalMorango = morango * precoMorango;
double totalMaca = maca * precoMaca;
double totalKg = morango + maca;
double valortotal = totalMorango + totalMaca;

if (totalKg > 8 || valortotal > 25.00)
{
    valortotal *= 0.90; 
}

Console.WriteLine($"Valor total a pagar é: R$ {valortotal:F2}");