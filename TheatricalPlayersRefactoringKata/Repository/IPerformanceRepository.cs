
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Repository;

public interface IPerformamceRepository
{
    public Performance? GetById(int id);
    public List<Performance> GetAll(); 
    public Performance Save(int id, int playId, int audience);
    public void Delete(int id);
    
}