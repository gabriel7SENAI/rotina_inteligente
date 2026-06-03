namespace sistema_rotina_inteligente.Models;

public class LimpezaTemp : RotinaBase
{
    private Random random = new();

    protected ControleRotinas logs;
    public int ArquivosRemovidos { get; private set; }

    public LimpezaTemp(string nome) : base(nome) { }

    public override void Executar()
    {
        ArquivosRemovidos = random.Next(0, 350);

        ExibirCabecalho();

        Console.WriteLine();
        Console.WriteLine($"Executando Limpeza de arquivos temporários...");

        Thread.Sleep(3000);

        Console.WriteLine($"Quantidade de arquivos temporários removidos: {ArquivosRemovidos}");

        RegistrarExecucao();

        Console.WriteLine($"\n-- Pressione qualquer tecla para continuar --");
        Console.ReadKey();

        Console.Clear();
    }
    public override string ObterDescricao() => "Execute para limpar arquivos temporários";
}
