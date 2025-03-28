
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Repository;

public interface IPerformamceRepository
{
    public Performance? GetById(int id);
    public List<Performance> GetAll(); 
    public Performance Save(PerformanceDto performanceDto);
    public void Delete(int id);
    
}