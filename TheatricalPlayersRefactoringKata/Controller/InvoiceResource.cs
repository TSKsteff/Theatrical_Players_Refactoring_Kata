using Microsoft.AspNetCore.Mvc;
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Service;

namespace TheatricalPlayersRefactoringKata.Controller;

[ApiController]
[Route("/api/invoice")]
public class InvoiceResource
{
    private readonly InvoiceService _invoiceService = new InvoiceService();
    
    [HttpGet("/getInvoiceById/{id}")]
    public Invoice? GetById(int id)
    {
        return _invoiceService.GetById(id);
    }
    
    [HttpGet("/getAllInvoice")]
    public List<Invoice> GetAll()
    {
        return _invoiceService.GetAll();
    }
    
    [HttpDelete("/deleteInvoice/{id}")]
    public void Delete(int id)
    {
        _invoiceService.Delete(id);
    }

    [HttpPost("/createInvoice")]
    public Invoice createInvoice(int customerId, List<PerformanceDto> performanceDtos)
    {
        return _invoiceService.Save(customerId, performanceDtos);
    }
    
}