using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.DTOs;

public class InvoiceDto
{
    public int customerId { get; set; }
    public DateTime issueDate { get; set; }
    public List<Performance> performances { get; set; } = new List<Performance>();
    
    public Invoice invoiceParse(InvoiceDto invoiceDto)
    {
        Invoice invoice = new Invoice();
        invoice.issueDate = invoiceDto.issueDate;
        invoice.customerId = invoiceDto.customerId;
        invoice.performances = invoiceDto.performances;
        return invoice;
    }
}