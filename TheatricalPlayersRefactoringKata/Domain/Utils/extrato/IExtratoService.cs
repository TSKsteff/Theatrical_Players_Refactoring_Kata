namespace TheatricalPlayersRefactoringKata.Domain.Utils.extrato;

public interface IExtratoService
{
     ExtratoCliente gerarDadosExtrato(int customerId); 
     byte[] gerarExtratoPdf(int customerId);
}