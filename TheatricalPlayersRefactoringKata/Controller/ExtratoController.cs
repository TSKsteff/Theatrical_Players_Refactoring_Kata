using Microsoft.AspNetCore.Mvc;
using TheatricalPlayersRefactoringKata.Domain.Utils.extrato;

namespace TheatricalPlayersRefactoringKata.Controller;

[ApiController]
[Route("api/clientes/{customerId}/extrato")]
public class ExtratoController : ControllerBase
{
    private readonly IExtratoService _extratoService;

    public ExtratoController(IExtratoService extratoService)
    {
        _extratoService = extratoService;
    }

    [HttpGet("/pdf")]
    public IActionResult GetPdf(int customerId)
    {
        var pdf = _extratoService.gerarExtratoPdf(customerId);
        return File(pdf, "application/pdf", $"extrato_{customerId}.pdf");
    }

    [HttpGet("/dados")]
    public ActionResult<ExtratoCliente> GetDados(int customerId)
    {
        return _extratoService.gerarDadosExtrato(customerId);
    }
}