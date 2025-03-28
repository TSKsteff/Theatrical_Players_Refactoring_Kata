using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.DTOs;

public class PerformanceDto
{
    public int invoiceId { get; set; }
    
    public Invoice invoice { get; set; }
    public int playId { get; set; }
    public Play play { get; set; }
    public int audience { get; set; }
    public int creditsEarned { get; set; }

    public Performance performanceParse(PerformanceDto performanceDto)
    {
        Performance performance = new Performance();
        performance.InvoiceId = performanceDto.invoiceId;
        performance.invoice = performanceDto.invoice;
        performance.playId = performanceDto.playId;
        performance.play = performanceDto.play;
        performance.audience = performanceDto.audience;
        performance.creditsEarned = performanceDto.creditsEarned;
        return performance;
    }
}