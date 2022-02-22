using DioSeries;

SerieRepository repositories = new SerieRepository();


string userOption = GetUserOption();

while (userOption.ToUpper() != "X")
{
    switch (userOption)
    {
        case "1":
            ShowList();
            break;
        case "2":
            InsertSerie();
            break;
        case "3":
            UpdateSerie();
            break;
        case "4":
            DeleteSerie();
            break;
        case "5":
            ShowSerie();
            break;
        case "C":
            Console.Clear();
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    userOption = GetUserOption();
}

Console.WriteLine("Obrigado por utilizar nossos serviços.");
Console.WriteLine();

void ShowList()
{
    Console.WriteLine("Listar séries");

    var list = repositories.SeriesList();

    if (list.Count == 0)
    {
        Console.WriteLine("Nenhuma série cadastrada.");
        return;
    }

    foreach (var serie in list)
    {
        var deleted = serie.returnDeleted();

        Console.WriteLine("#ID {0}: - {1} {2}", serie.returnId(), serie.returnTitle(), (deleted ? "*Excluído*" : ""));
    }
}

void InsertSerie()
{
    Console.WriteLine("Inserir nova série");

    foreach (int i in Enum.GetValues(typeof(Genre)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int genreEntry = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string titleEntry = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int yearEntry = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string descriptionEntry = Console.ReadLine();

    Serie newSerie = new Serie(id: repositories.NextId(),
                                genre: (Genre)genreEntry,
                                title: titleEntry,
                                year: yearEntry,
                                description: descriptionEntry);

    repositories.Insert(newSerie);
}

void UpdateSerie()
{
    Console.Write("Digite o id da série: ");
    int serieIndex = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genre)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int genreEntry = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string titleEntry = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int yearEntry = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string descriptionEntry = Console.ReadLine();

    Serie updateSerie = new Serie(id: serieIndex,
                                genre: (Genre)genreEntry,
                                title: titleEntry,
                                year: yearEntry,
                                description: descriptionEntry);

    repositories.Update(serieIndex, updateSerie);
}

void ShowSerie()
{
    Console.Write("Digite o id da série: ");
    int serieIndex = int.Parse(Console.ReadLine());

    var serie = repositories.ReturnById(serieIndex);

    Console.WriteLine(serie);
}

void DeleteSerie()
{
    Console.Write("Digite o id da série: ");
    int serieIndex = int.Parse(Console.ReadLine());

    repositories.Delete(serieIndex);
}

static string GetUserOption()
{
    Console.WriteLine();
    Console.WriteLine("DIO Séries a seu dispor!");
    Console.WriteLine("Informe a opção desejada: ");

    Console.WriteLine("1 - Listar séries");
    Console.WriteLine("2 - Inserir nova série");
    Console.WriteLine("3 - Atualizar série");
    Console.WriteLine("4 - Excluir série");
    Console.WriteLine("5 - Visualizar série");
    Console.WriteLine("C - Limpar tela");
    Console.WriteLine("X - Sair");
    Console.WriteLine();

    string userOption = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return userOption;
}
