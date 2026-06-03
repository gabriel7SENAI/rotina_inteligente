namespace sistema_rotina_inteligente.Models;

public class LogExecucao
{
    public string NomeRotina { get; set; }
    public DateTime DataExecucao { get; private set; }

    public LogExecucao(string nomeRotina)
    {
        NomeRotina = nomeRotina;
        DataExecucao = DateTime.Now;
    }
}
