using sistema_rotina_inteligente.Interfaces;
using sistema_rotina_inteligente.Models;

Console.Clear();

List<IRotina> rotinas = new()
{
    new LimpezaTemp("Limpeza de Arquivos Temporários"),
    new MonitorMemoria("Monitor de Memória"),
    new BackupRotina("Backup"),
    new OrganizadorArquivos("Organizador de Arquivos"),
    new DiagnosticoSistema("Diagnóstico do Sistema"),
};

ControleRotinas controleRotinas = new();

while (true)
{
    Console.Clear();

    Console.WriteLine("=== === === === === === === ===");
    Console.WriteLine("Sistema de Rotina Inteligente");
    Console.WriteLine("=== === === === === === === ===");

    Console.WriteLine($"1 - Executar Limpeza");
    Console.WriteLine($"2 - Monitorar Memória");
    Console.WriteLine($"3 - Fazer Backup");
    Console.WriteLine($"4 - Organizar Arquivos");
    Console.WriteLine($"5 - Diagnóstico do Sistema");
    Console.WriteLine($"6 - Executar Todas");
    Console.WriteLine($"7 - Mostrar Logs");
    Console.WriteLine($"0 - Sair");

    Console.Write($"Opção: ");
    int opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            rotinas[0].Executar();
            break;

        case 2:
            rotinas[1].Executar();
            break;

        case 3:
            rotinas[2].Executar();
            break;

        case 4:
            rotinas[3].Executar();
            break;

        case 5:
            rotinas[4].Executar();
            break;

        case 6:
            await controleRotinas.ExecutarTodas(rotinas);
            break;

        case 7:
            Console.Clear();
            Console.WriteLine("Logs:");
            foreach (var log in RotinaBase.Logs)
            {
                Console.WriteLine($"{log.NomeRotina} - {log.DataExecucao}");
                await Task.Delay(100);
            }

            Console.WriteLine("\n-- Pressione qualquer tecla para continuar --");
            Console.ReadKey();
            break;

        case 0:
            Console.WriteLine("Encerrando sistema...");
            Thread.Sleep(2000);
            Console.WriteLine("Sistema encerrado.");
            Thread.Sleep(500);
            return;

        default:
            Console.WriteLine("Comando inválido");
            await Task.Delay(1000);
            break;
    }
}