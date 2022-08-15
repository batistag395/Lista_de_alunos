List<string> nomes = new List<string>();

int count = 1;

string nomeParaAdd = string.Empty;

Console.WriteLine("Lista de Alunos");
Console.WriteLine("Digite a lista de alunos, e quando nao tiver mais alunos, aperte apenas enter");

while (nomeParaAdd.Length != null)
{
    nomeParaAdd = Console.ReadLine();
    if (nomeParaAdd.Length == 0)
    {
        break;
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
    Console.WriteLine("#" + count + " " + nome);
    count++;
}

Console.WriteLine("Deseja remover alguem da lista? (s/n)");
char escolha = char.Parse(Console.ReadLine());

while (escolha == 's' || escolha == 'S')
{
    Console.WriteLine("Digite o nome que deseja excluir da lista:");
    nomeParaAdd = Console.ReadLine();

    while (nomeParaAdd.Length > 0)
    {
        if (nomes.Contains(nomeParaAdd))
        {
            Console.WriteLine("Removido com sucesso");
            nomes.Remove(nomeParaAdd);
            break;
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
            break;
        }
    }
    Console.WriteLine("Deseja remover mais alguem da lista? (s/n)");
    escolha = char.Parse(Console.ReadLine());
}
count = 1;
Console.WriteLine($"Voce cadastrou {nomes.Count} nomes");
Console.WriteLine("Lista de nomes:");

foreach (string nome in nomes)
{
    Console.WriteLine("#" + count + " " + nome);
    count++;
}
