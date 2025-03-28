using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.Utils.extrato;

public class ExtratoCliente
{
    public string nomeCliente { get; set; }
    public string emailCliente { get; set; }
    public DateTime dataFatura { get; set; }
    public List<Invoice> faturas { get; set; }
}