
using TheatricalPlayersRefactoringKata.Domain.Interface;
using TheatricalPlayersRefactoringKata.Domain.Interface.impl;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.Utils;

public class PlayFactory
{
    public static void CreatePlay(Performance performance,int audience, int lines, PlayType playType)
    {
        switch(playType.name)
        {
            case "Tragedy": 
                TragedyCalculationStrategy tragedyCalculationStrategy = new TragedyCalculationStrategy();
                performance.creditsEarned = tragedyCalculationStrategy.CalculateCredits(audience);
                performance.calPerformance = tragedyCalculationStrategy.CalculatePerformanceCost(lines, audience);
                break;
            case "Comedy": 
                ComedyCalculationStrategy comedyCalculationStrategy = new ComedyCalculationStrategy();
                performance.creditsEarned = comedyCalculationStrategy.CalculateCredits(audience);
                performance.calPerformance = comedyCalculationStrategy.CalculatePerformanceCost(lines, audience);
                break;
            case "Historical": 
                HistoricalCalculationStrategy historicalCalculationStrategy = new HistoricalCalculationStrategy();
                performance.creditsEarned = historicalCalculationStrategy.CalculateCredits(audience);
                performance.calPerformance = historicalCalculationStrategy.CalculatePerformanceCost(lines, audience);
                break;
        };
        
    }
}