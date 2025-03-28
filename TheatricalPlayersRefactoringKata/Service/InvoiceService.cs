using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Info;
using TheatricalPlayersRefactoringKata.Repository;

namespace TheatricalPlayersRefactoringKata.Service;

public class InvoiceService : IInvoiceRepository
{
    private readonly DbConfig _config = new DbConfig();
    private readonly PerformanceService _performanceService = new PerformanceService();


    public Invoice? GetById(int id)
    {
        return _config.Invoices.Find(id);
    }

    public Invoice Save(int customerId, List<PerformanceDto> listPerformanceDto)
    {
        var customer = _config.Customers.Find(customerId);
        if (customer == null)
        {
            throw new ArgumentException("Cliente não encontrado.");
        }

        var invoice = new Invoice
        {
            customerId = customerId,
            customer = customer,
            performances = listPerformanceDto.Select(p => p.performanceParse(p)).ToList(),
            issueDate = DateTime.UtcNow
        };
        
        int totalCreditos = listPerformanceDto.Sum(p => p.creditsEarned);
        
        customer.creditBalance += totalCreditos;
        
         _config.Invoices.Add(invoice);
         _config.SaveChanges();
        
       _config.Invoices.Add(invoice);
       _config.SaveChanges();
       
       _config.Customers.Update(customer);
       _config.SaveChanges();
       return invoice;
    }

    public void Delete(int id)
    {
        var invoice = _config.Invoices.Find(id);
        if (invoice != null)
        {
            _config.Invoices.Remove(invoice);
            _config.SaveChanges();
        }
    }

    public void Update(int id, InvoiceDto invoice)
    {
      throw new NotImplementedException();
    }
    
    public List<Invoice> GetAll()
    {
        return _config.Invoices.ToList();
    }

    public Invoice AddPerformanceToInvoice(int invoiceId, int playId, int audience)
    {
        var invoice =  _config.Invoices.Find(invoiceId);
        if (invoice == null) throw new KeyNotFoundException("Fatura não encontrada.");
        
        var performance = _performanceService.Save(invoiceId, playId, audience);
        
        invoice.performances.Add(performance);
        _config.SaveChanges();
        _config.Update(invoice);
        return GetById(invoiceId) ?? throw new KeyNotFoundException();
    }
}