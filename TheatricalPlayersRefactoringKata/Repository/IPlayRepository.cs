
using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Repository;

public interface IPlayRepository
{
    public Play? GetById(int id);
    public List<Play> GetAll(); 
    public Play Save(PlayDto obj);
    public Play Update(PlayDto playDto);
    public void Delete(int id);
    
}