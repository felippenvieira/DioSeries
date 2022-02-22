using DioSeries;

SerieRepository repositories = new SerieRepository();

static void Main(string[] args)
{
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
            case "4";
                DeleteSerie();
                break;
            case "5";
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
