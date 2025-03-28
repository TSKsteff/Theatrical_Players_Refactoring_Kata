using Microsoft.AspNetCore.Mvc;
using TheatricalPlayersRefactoringKata.Domain.Utils.extrato;

namespace TheatricalPlayersRefactoringKata.Controller;

[ApiController]
[Route("api/clientes/extrato")]
public class ExtratoController : ControllerBase
{
    private readonly ExtratoService _extratoService = new ExtratoService();

    [HttpGet("/pdf/{customerId}")]
    public IActionResult GetPdf(int customerId)
    {
        var pdf = _extratoService.gerarExtratoPdf(customerId);
        return File(pdf, "application/pdf", $"extrato_{customerId}.pdf");
    }

    [HttpGet("/dados/{customerId}")]
    public ActionResult<ExtratoCliente> GetDados(int customerId)
    {
        return _extratoService.gerarDadosExtrato(customerId);
    }
}