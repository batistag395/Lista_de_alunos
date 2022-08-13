List<string> nomes = new List<string>();

string nomeParaAdd = " ";

while (nomeParaAdd.Length != null)
{
    nomeParaAdd = Console.ReadLine();
    if (nomeParaAdd.Length == 0)
    {
        break; ;
    }
    else
    {
        nomes.Add(nomeParaAdd);
    }
}
Console.WriteLine($"Voce cadastrou {nomes.Count} nomes");
Console.WriteLine("Lista de nomes:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("Deseja remover alguem da lista? (s/n)");
char escolha = char.Parse(Console.ReadLine());

if (escolha == 's' || escolha == 'S')
{

    nomeParaAdd = Console.ReadLine();

    while (nomeParaAdd.Length > 0)
    {
        if (nomes.Contains(nomeParaAdd))
        {
            Console.WriteLine("Removido com sucesso");
            nomes.Remove(nomeParaAdd);
        }
        else if (!nomes.Contains(nomeParaAdd))
        {
            Console.WriteLine("O nome nao consta na lista, verifique se digitou corretamente!");
            nomeParaAdd = Console.ReadLine();
            if (nomes.Contains(nomeParaAdd))
            {
                Console.WriteLine("Removido com sucesso");
                nomes.Remove(nomeParaAdd);
                break;
            }
        }
        else
        {
            Console.WriteLine("Removido sem sucesso");
        }
    }

}

Console.WriteLine($"Voce cadastrou {nomes.Count} nomes");
Console.WriteLine("Lista de nomes:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}