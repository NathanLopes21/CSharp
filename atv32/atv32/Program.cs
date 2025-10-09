/*Console.WriteLine("Digite o numero inicial:");
int inicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero final:");
int final = int.Parse(Console.ReadLine());

Console.WriteLine("\nOs numeros dos intevalos são:");

if(inicial <= final)
{
    for (int i = inicial; i <= final; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = inicial; i >= final; i--)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------------------------------------");

Console.WriteLine("\nNumero pares são:");

for (int i = inicial; i <= final; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/




/*double matematica;

do
{
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Escolhe uma opção");

    matematica = double.Parse(Console.ReadLine());

    if (matematica == 0)
    {
        Console.WriteLine("Calculadora encerrado");
        break;
    }

    if (matematica < 1 || matematica > 4)
    {
        Console.WriteLine("Numero Errado");
        continue;
    }
    Console.WriteLine("Digite o primeiro numero:");
    double nume1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o primeiro numero:");
    double nume2 = double.Parse(Console.ReadLine());

    if (matematica == 4 && nume2 == 0)
    {
        Console.WriteLine("Erro!! não é possivel divisao por zero");
        continue;
    }

    double resul = 0;

    if (matematica == 1)
        resul = nume1 + nume2;

    else if (matematica == 2)
        resul = nume1 - nume2;

    else if (matematica == 3)
        resul = nume1 * nume2;

    else if (matematica == 4)
        resul = nume1 / nume2;

    Console.WriteLine("Resultado:" + resul);

} while (true);*/






/*List<string> nome = new List<string>();

while (true)
{
    Console.WriteLine("Digite um nome ou Digite SAIR para encerrar::");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "sair")
        break;

    nome.Add(entrada);
}

nome.Sort();

Console.WriteLine("Nomes integrados:");
foreach (string nomes in nome)
    Console.WriteLine(nome);

Console.WriteLine("\nTotal de nomes: " + nome.Count);*/



/*ExibirMenu();

Console.Write("Digite seu nome: ");
string nomes = Console.ReadLine();
SaudarUsuario(nomes);

Console.Write("Digite o primeiro número: ");
int nume1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int nume2 = int.Parse(Console.ReadLine());

int soma = Somar(nume1, nume2);
Console.WriteLine($"A soma dos números é: {soma}");

Console.Write("Digite um número para verificar se é par ou ímpar: ");
int numVerificar = int.Parse(Console.ReadLine());

if (EhPar(numVerificar))
{
    Console.WriteLine($"{numVerificar} é par.");
}
else
{
    Console.WriteLine($"{numVerificar} é ímpar.");
}
    

   
    static void ExibirMenu()
{
    Console.WriteLine("********* MENU **********");
    Console.WriteLine("1. Saudação personalizada");
    Console.WriteLine("2. Soma de dois números");
    Console.WriteLine("3. Verificar par ou ímpar");
    Console.WriteLine();
}


static void SaudarUsuario(string nome)
{
    Console.WriteLine($"Opaaa, {nome} Seja bem vindo(a) meu fii!");
}


static int Somar(int a, int b)
{
    return a + b;
}


static bool EhPar(int numero)
{
    return numero % 2 == 0;*/
}

