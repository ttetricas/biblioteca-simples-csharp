string resposta = "s";

while (resposta == "s")
{
    string livro;

    do
    {
        Console.Write("Digite o nome do livro: ");
        livro = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(livro))
        {
            Console.WriteLine("Por favor, digite um nome válido.");
        }
    } while (string.IsNullOrWhiteSpace(livro));

    Console.WriteLine("Livro cadastrado: " + livro);

    do
    {
        Console.Write("Quer cadastrar outro livro? (s/n): ");
        resposta = Console.ReadLine().ToLower();
        if (resposta != "s" && resposta != "n")
        {
            Console.WriteLine("Por favor, responda só com 's' ou 'n'.");
        }
    } while (resposta != "s" && resposta != "n");
}
