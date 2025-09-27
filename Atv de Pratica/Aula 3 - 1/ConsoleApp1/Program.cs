// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
string entrada = Console.ReadLine();

if (int.TryParse(nome, out int id)) {
    Console.WriteLine(entrada);
}
else {
    Console.WriteLine("erro");
}

Console.WriteLine("Pressione enter para sair");
Console.ReadLine();





