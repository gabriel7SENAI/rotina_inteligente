namespace sistema_rotina_inteligente.Models;

public class BackupRotina : RotinaBase
{
    private Random random = new();

    public int QuantidadeDeArquivos { get; set; }

    public BackupRotina(string nome) : base(nome) { }

    public override void Executar()
    {
        QuantidadeDeArquivos = random.Next(14, 1578);

        ExibirCabecalho();

        Console.WriteLine();

        Console.Write($"Pasta de origem: ");
        string origem = Console.ReadLine();

        Console.Write($"Pasta de destino: ");
        string destino = Console.ReadLine();

        Thread.Sleep(2000);

        Console.WriteLine($"Quantidade de arquivos a serem transferidos: {QuantidadeDeArquivos}\n");

        Console.Write($" - Transferindo arquivos: {origem} -> {destino}\n");
        Thread.Sleep(1000);
        Console.WriteLine($"Backup feito.");

        Console.WriteLine($"\n-- Pressione qualquer tecla para continuar --");
        Console.ReadKey();

        Console.Clear();
    }

    public override string ObterDescricao() => "Execute para fazer backup de arquivos";
}
