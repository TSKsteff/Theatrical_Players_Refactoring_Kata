using TheatricalPlayersRefactoringKata.Domain.enums;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.DTOs;

public class PlayDto
{
    public string title { get; set; }
    public int lines { get; set; }
    public int type { get; set; }
    public int playTypeId { get; set; }

    public Play playParse(PlayDto playDto)
    {
        Play play = new Play();
        play.title = playDto.title;
        play.lines = playDto.lines;
        play.playTypeId = playDto.playTypeId;
        return play;
    }
    
}