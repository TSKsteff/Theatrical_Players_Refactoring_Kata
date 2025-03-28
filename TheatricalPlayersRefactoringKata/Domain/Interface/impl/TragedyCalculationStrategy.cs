namespace TheatricalPlayersRefactoringKata.Domain.Interface.impl;

public class TragedyCalculationStrategy : IPlayCalculationStrategy
{
    public decimal CalculatePerformanceCost(int lines, int audience)
    {
        var baseCost = Math.Clamp(lines, 1000, 4000) * 10;
        if (audience > 30) baseCost += 1000 * (audience - 30);
        return baseCost / 100m;
    }

    public int CalculateCredits(int audience) 
        => Math.Max(audience - 30, 0);
}