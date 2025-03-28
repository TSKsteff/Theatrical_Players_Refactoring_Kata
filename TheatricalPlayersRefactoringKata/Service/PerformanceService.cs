
using TheatricalPlayersRefactoringKata.Domain.Model;
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

    public Performance Save(int invoiceId, int playId, int audience)
    {
        var play = _config.Play.Find(playId);
        if (play == null) throw new KeyNotFoundException("Play not found.");
        
        var invoice = _config.Invoices.Find(invoiceId);
        if (invoice == null) throw new KeyNotFoundException("Invoice not Found.");
      
        var performance = new Performance
        {
            InvoiceId = invoiceId,
            playId = playId,
            audience = audience,
            creditsEarned = play.CalculateCredits(audience)
        };
        
        _config.Performances.Add(performance);
        _config.SaveChanges();
        
        return performance;
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
}