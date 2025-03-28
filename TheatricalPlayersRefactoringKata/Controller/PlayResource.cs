using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Service;

namespace TheatricalPlayersRefactoringKata.Controller;

[ApiController]
[Route("/api/play")]
public class PlayResource
{
    private readonly PlayService _playService = new PlayService();
    
    [HttpGet("/getPlayById/{id}")]
    public Play? GetById(int id)
    {
        return _playService.GetById(id);
    }
    
    [HttpGet("/getAllPLay")]
    public List<Play> GetAll()
    {
        return _playService.GetAll();
    } 
    
    [HttpPost("/createPLay")]
    public Play Post(PlayDto playDto)
    {
        return _playService.Save(playDto);
    }
    
    [HttpPut("/updatePLay/{id}")]
    public  ActionResult<Play> Update(int id, PlayDto play)
    {
        _playService.Update(play);
        return _playService.GetById(id);
    }

    [HttpDelete("/deletePLay/{id}")]
    public void Delete(int id)
    {
        _playService.Delete(id);
    }
}