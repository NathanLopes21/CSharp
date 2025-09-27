
/*Console.WriteLine("Digite sue nome:");
string nome = Console.ReadLine();

int idade = 0;
bool idadeValida = false;

while (!idadeValida)
{
    Console.WriteLine("Digite sua idade");
    string entrada = Console.ReadLine();

    try
    {
        idade = int.Parse(entrada);
        idadeValida = true;

    }
    catch (OverflowException)
    {
        Console.WriteLine("Valor invalido, digite novamente");
    }
    Console.WriteLine($"Oi, {nome}, voce tem {idade} anos");
    Console.ReadLine();
}
*/

/*Console.WriteLine("Digite o primeiro n°:");
float n1 = float.Parse (Console.ReadLine ());

Console.WriteLine("Digite o segundo n°:");
float n2 = float.Parse (Console.ReadLine ());

float soma = n1 + n2;
Console.WriteLine($"A soma do {n1} + {n2} = {soma}");

Console.ReadLine();*/

/*Console.WriteLine("digite sua idade");
int id = int.Parse(Console.ReadLine());

if (id >= 18)
{
    Console.WriteLine("Maior de idade");

}
else
{
    Console.WriteLine("Menor de idade");
}*/

/*for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/

Console.WriteLine("Digite um numero:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"\n tabuada do {n1}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n1} x {i} = {n1 * i}");
}






