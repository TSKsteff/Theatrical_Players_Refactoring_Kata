
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Domain.Utils;
using TheatricalPlayersRefactoringKata.Info;
using TheatricalPlayersRefactoringKata.Repository;

namespace TheatricalPlayersRefactoringKata.Service;

public class PerformanceService : IPerformamceRepository
{
    private readonly DbConfig _config = new DbConfig();


    public Performance? GetById(int id)
    {
        return _config.Performances.Find(id);
    }

    public void Delete(int id)
    {
        var play = _config.Play.Find(id);
        if (play != null)
        {
            _config.Play.Remove(play);
            _config.SaveChanges();
        }
    }
    
    public List<Performance> GetAll()
    {
        return _config.Performances.ToList();
    }
    
    public Performance Save(PerformanceDto performanceDto)
    {
        Play play = _config.Play.Find(performanceDto.playId);
        if (play == null) throw new KeyNotFoundException("Play not found.");
        
        var invoice = _config.Invoices.Find(performanceDto.invoiceId);
        if (invoice == null) throw new KeyNotFoundException("Invoice not Found.");
      
        var performance = new Performance
        {
            InvoiceId = performanceDto.invoiceId,
            playId = performanceDto.playId,
            audience = performanceDto.audience,
            time = performanceDto.time
        };
        PlayType playType = _config.PlayTypes.Find(play.playTypeId);
        PlayFactory.CreatePlay(performance, performanceDto.audience, play.lines, playType);
        
        _config.Performances.Add(performance);
        _config.SaveChanges();
        
        return performance;
    }

  
}