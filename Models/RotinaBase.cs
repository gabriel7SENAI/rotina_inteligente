using sistema_rotina_inteligente.Interfaces;

namespace sistema_rotina_inteligente.Models;

public abstract class RotinaBase : IRotina
{
    public string Nome { get; }
    public DateTime DataExecucao { get; set; }

    public List<LogExecucao> Logs { get; } = new();

    protected RotinaBase(string nome)
    {
        Nome = nome;
    }

    public void RegistrarExecucao()
    {
        Logs.Add(new LogExecucao(Nome));
    }

    public abstract void Executar();
    public virtual void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("=== === === === === === === ===");
        Console.WriteLine(Nome);
        Console.WriteLine("=== === === === === === === ===");
    }
    public abstract string ObterDescricao();
}