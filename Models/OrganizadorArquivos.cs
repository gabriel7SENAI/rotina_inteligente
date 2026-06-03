namespace sistema_rotina_inteligente.Models;

public class OrganizadorArquivos : RotinaBase
{
    public OrganizadorArquivos(string nome) : base(nome) { }

    public override void Executar()
    {
        ExibirCabecalho();

        Console.WriteLine();
        Console.WriteLine($"Organizando arquivos...");

        Thread.Sleep(3000);

        Console.WriteLine($"Arquivos organizados:\n");
        Console.WriteLine($" - Imagens em user/image");
        Console.WriteLine($" - Vídeos em user/video");
        Console.WriteLine($" - Documentos em user/doc");

        RegistrarExecucao();

        Console.WriteLine($"\n-- Pressione qualquer tecla para continuar --");
        Console.ReadKey();

        Console.Clear();
    }

    public override string ObterDescricao() => "Execute para organizar arquivos";
}
