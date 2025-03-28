namespace TheatricalPlayersRefactoringKata.Domain.Interface.impl;

public class HistoricalCalculationStrategy : IPlayCalculationStrategy
{
    public decimal CalculatePerformanceCost(int lines, int audience)
    {
        var baseCost = Math.Clamp(lines, 1000, 4000) * 12;
        if (audience > 25) baseCost += 800 * (audience - 25);
        return baseCost / 100m;
    }

    public int CalculateCredits(int audience)
        => Math.Max(audience - 25, 0) + (int)Math.Floor(audience / 4m);
}