namespace TheatricalPlayersRefactoringKata.Domain.Interface.impl;

public class ComedyCalculationStrategy : IPlayCalculationStrategy
{
    public decimal CalculatePerformanceCost(int lines, int audience)
    {
        var baseCost = Math.Clamp(lines, 1000, 4000) * 10;
        if (audience > 20) baseCost += 10000 + 500 * (audience - 20);
        baseCost += 300 * audience;
        return baseCost / 100m;
    }

    public int CalculateCredits(int audience)
        => Math.Max(audience - 30, 0) + (int)Math.Floor(audience / 5m);
}