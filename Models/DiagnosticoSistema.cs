namespace sistema_rotina_inteligente.Models;

public class DiagnosticoSistema : RotinaBase
{
    private Random random = new();

    public int EspacoUtlizado { get; private set; }
    public DiagnosticoSistema(string nome) : base(nome) { }

    public override void Executar()
    {
        EspacoUtlizado = random.Next(0, 100);

        ExibirCabecalho();

        Console.WriteLine();

        Thread.Sleep(1000);

        Console.WriteLine($"Nome da máquina: {Environment.MachineName}");
        Console.WriteLine($"Usuário: {Environment.UserName}");
        Console.WriteLine($"Sistema operacional: {Environment.OSVersion}");
        Console.WriteLine($"Data e hora: {DateTime.Now}");

        RegistrarExecucao();

        Console.WriteLine($"\n-- Pressione qualquer tecla para continuar --");
        Console.ReadKey();

        Console.Clear();
    }

    public override string ObterDescricao() => "Execute para ver diagnóstico do sistema";
}
