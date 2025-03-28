using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Service;

namespace TheatricalPlayersRefactoringKata.Domain.Utils.extrato;

public class ExtratoService : IExtratoService
{
    
    private readonly CustomerService _customerService = new CustomerService() ;
    private readonly InvoiceService _invoiceService = new InvoiceService();
    private readonly IHtmlToPdfConverter _inHtmlToPdfConverter;
    private readonly string _templatePath = "C:/TheatricalPlayersRefactoringKata/TheatricalPlayersRefactoringKata/Resource";
    private readonly IHtmlToPdfConverter _pdfConverter;
    
    private byte[] GeneratePdf(ExtratoCliente extrato)
    {
        var data = new Dictionary<string, object>
        {
            { "cliente", extrato },
            { "dataFatura", extrato.dataFatura.ToString("dd/MM/yyyy") },
            { "emailCliente", extrato.emailCliente },
            { "nomeCliente", extrato.nomeCliente },
            { "faturas", extrato.faturas }
        };

        return _pdfConverter
            .PdfTemplatePath($"{_templatePath}/pdfTemplate.pdf")
            .CssTemplatePath($"{_templatePath}/StyleTemplate.css")
            .HtmlTemplate($"{_templatePath}/htmlTemplate.html", data)
            .Create();
    }


    public ExtratoCliente gerarDadosExtrato(int customerId)
    {
        var customer = _customerService.GetById(customerId);
        var invoices = _invoiceService.GetAll();
        invoices.ForEach(invoice => invoice.customerId = customer.id);

        return new ExtratoCliente
        {
            nomeCliente = customer.name,
            emailCliente = customer.email,
            dataFatura = DateTime.Now,
            faturas = invoices.ToList()
        };
    }
    
    public byte[] gerarExtratoPdf(int customerId)
    {
        var extrato = gerarDadosExtrato(customerId);
        return GeneratePdf(extrato);
    }
}