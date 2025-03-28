
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Repository;

public interface IInvoiceRepository
{
    public Invoice? GetById(int id);
    public List<Invoice> GetAll(); 
    public Invoice Save(int costumer, List<PerformanceDto> listPerformanceDto);
    public void Update(int id, InvoiceDto invoiceDto);
    public void Delete(int id);
    public Invoice AddPerformanceToInvoice(int invoiceId, int playId, int audience); 

}