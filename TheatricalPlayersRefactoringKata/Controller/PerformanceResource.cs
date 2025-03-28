using Microsoft.AspNetCore.Mvc;
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Repository;
using TheatricalPlayersRefactoringKata.Service;

namespace TheatricalPlayersRefactoringKata.Controller;
[ApiController]
[Route("/api/performance")]
public class PerformanceResource
{
    private readonly PerformanceService _performamceService = new PerformanceService();
    
    [HttpGet("/getPerformanceById/{id}")]
    public Performance GetById(int id)
    {
        return _performamceService.GetById(id);
    }
    
    [HttpGet("/getAllPerformance")]
    public List<Performance> GetAll()
    {
        return _performamceService.GetAll();
    }
    
    [HttpDelete("/deletePerformance")]
    public void Delete(int id)
    {
        _performamceService.Delete(id);
    }

    [HttpPost("/createPerformance")]
    public Performance Post([FromBody]PerformanceDto performanceDto)
    {
        Console.WriteLine(performanceDto.audience);
        return _performamceService.Save(performanceDto);
    }
    
}