using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.DTOs;

public class InvoiceDto
{
    public int customerId { get; set; }
   public Invoice invoiceParse(InvoiceDto invoiceDto)
    {
        Invoice invoice = new Invoice();
        invoice.customerId = invoiceDto.customerId;
        return invoice;
    }
}