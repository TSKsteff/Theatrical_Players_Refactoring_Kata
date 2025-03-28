using TheatricalPlayersRefactoringKata.Domain.DTOs;
using TheatricalPlayersRefactoringKata.Domain.Model;
using TheatricalPlayersRefactoringKata.Domain.Utils;
using TheatricalPlayersRefactoringKata.Info;
using TheatricalPlayersRefactoringKata.Repository;

namespace TheatricalPlayersRefactoringKata.Service;

public class PlayService : IPlayRepository
{
    private readonly DbConfig _config = new DbConfig();

    public Play? GetById(int id)
    {
        return _config.Play.Find(id);
    }

    public List<Play> GetAll()
    {
        return _config.Play.ToList();
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
    
    public Play Save(PlayDto playDto)
    {
        var playType = _config.PlayTypes.Find(playDto.playTypeId);
        if (playType == null)
            throw new Exception("Type not found found");

        var play = new Play
        {
            title = playDto.title,
            lines = playDto.lines,
            playTypeId = playDto.playTypeId
        };
        
       _config.Play.Add(play);
       _config.SaveChanges();
       return play;
    }

    public Play Update(int id, PlayDto playDto)
    {
            var play = _config.Play.Find(id);
            if (play == null)
                throw new Exception("Play not found found");
            
            Play newPlay = playDto.playParse(playDto);
            
            _config.Play.Update(newPlay);
            _config.SaveChanges();
            
            return GetById(play.id) ?? throw new KeyNotFoundException();
    }
   
}