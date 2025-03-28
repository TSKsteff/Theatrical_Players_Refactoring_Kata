
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Repository;

public interface IInvoiceRepository
{
    public Invoice? GetById(int id);
    public List<Invoice> GetAll(); 
    public Invoice Save(int costumer);
    public void Delete(int id);
    public void AddPerformanceToInvoice(int invoiceId, int performanceId); 

}