namespace sistema_rotina_inteligente.Models;

public class MonitorMemoria : RotinaBase
{
    private Random random = new();

    public int MemoriaUsada { get; private set; }
    public MonitorMemoria(string nome) : base(nome) { }

    public override void Executar()
    {
        MemoriaUsada = random.Next(0, 100);

        ExibirCabecalho();

        Console.WriteLine();
        Console.WriteLine($"Iniciando monitor de memória...");

        Thread.Sleep(3000);

        Console.WriteLine($"Quantidade de memória utilizada: {MemoriaUsada}%");

        RegistrarExecucao();

        if (MemoriaUsada > 80)
        {
            Console.WriteLine($"Alto uso de memória, recomenda-se limpeza no sistema");
        }

        Console.WriteLine($"\n-- Pressione qualquer tecla para continuar --");
        Console.ReadKey();

        Console.Clear();
    }

    public override string ObterDescricao() => "Execute para monitorar uso de memória";
}
