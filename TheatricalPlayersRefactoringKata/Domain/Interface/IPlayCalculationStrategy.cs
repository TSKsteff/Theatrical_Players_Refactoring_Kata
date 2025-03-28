namespace TheatricalPlayersRefactoringKata.Domain.Interface;

public interface IPlayCalculationStrategy
{
    decimal CalculatePerformanceCost(int lines, int audience);
    int CalculateCredits(int audience);
}