using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.DTOs;

public class PerformanceDto
{
    public int invoiceId { get; set; }
    
    public int playId { get; set; }
    public int audience { get; set; }
    public DateTime time { get; set; }

    public Performance performanceParse(PerformanceDto performanceDto)
    {
        Performance performance = new Performance();
        performance.InvoiceId = performanceDto.invoiceId;
        performance.playId = performanceDto.playId;
        performance.audience = performanceDto.audience;
        performance.time = performanceDto.time;
        return performance;
    }
}