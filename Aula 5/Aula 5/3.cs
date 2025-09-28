Console.Write("Descrição do produto: ");
string descricao = Console.ReadLine();

Console.WriteLine("Digite a quantdade do que vc quer:");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço do que vc quer:");
double preco = double.Parse(Console.ReadLine());


double total = quantidade * preco;

double desconto = 0;

if (quantidade <= 5)
{
    desconto = total * 0.02;
}
else if (quantidade <= 10)
{
    desconto = total * 0.03;
}
else
{
    desconto = total * 0.05;
}

double totalPagar = total - desconto;

Console.WriteLine($"\nDescrição do produto: {descricao}");
Console.WriteLine($"Total sem desconto: R$ {total:F2}");
Console.WriteLine($"Valor do desconto: R$ {desconto:F2}");
Console.WriteLine($"Total a pagar: R$ {totalPagar:F2}");


