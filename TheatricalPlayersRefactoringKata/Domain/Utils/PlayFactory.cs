using TheatricalPlayersRefactoringKata.Domain.enums;
using TheatricalPlayersRefactoringKata.Domain.Interface;
using TheatricalPlayersRefactoringKata.Domain.Interface.impl;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.Utils;

public class PlayFactory
{
    public static Play CreatePlay(string title, int lines, PlayType playType)
    {
        IPlayCalculationStrategy strategy = playType.name switch
        {
            "Tragedy" => new TragedyCalculationStrategy(),
            "Comedy" => new ComedyCalculationStrategy(),
            "Historical" => new HistoricalCalculationStrategy()
        };

        return new Play(strategy)
        {
            title = title,
            lines = lines,
            playTypeId = playType.id,
            playType = playType
        };
    }
}