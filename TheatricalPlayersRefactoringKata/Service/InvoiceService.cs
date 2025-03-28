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
    
    public List<Invoice> GetAll()
    {
        return _config.Invoices.ToList();
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

    public Invoice Save(int customerId)
    {
        var customer = _config.Customers.Find(customerId);
        if (customer == null)
            throw new ArgumentException("Customer not found.");
        

        var invoice = new Invoice
        {
            customerId = customerId,
            issueDate = DateTime.UtcNow
        };
        
                
        _config.Invoices.Add(invoice);
        _config.SaveChanges();
       return invoice;
    }
    public void AddPerformanceToInvoice(int invoiceId, int performanceId)
    {
        Performance performance =  _config.Performances.Find(performanceId);
        if (performanceId == null) throw new KeyNotFoundException("Peerformance not found.");
        
        Invoice invoice = _config.Invoices.Find(invoiceId);
        if (invoice == null) throw new KeyNotFoundException("Invoice not found.");
        
        
        Customer customer = _config.Customers.Find(invoice.customerId);
        
        performance.time = DateTime.SpecifyKind(performance.time, DateTimeKind.Utc);
        invoice.issueDate = DateTime.SpecifyKind(invoice.issueDate, DateTimeKind.Utc);

        customer.creditBalance += performance.creditsEarned;
        invoice.performances.Add(performance);
        customer.invoices.Add(invoice);
        
        _config.Customers.Update(customer);
        _config.SaveChanges();
        _config.Invoices.Update(invoice);
        _config.SaveChanges();
    }
    
}