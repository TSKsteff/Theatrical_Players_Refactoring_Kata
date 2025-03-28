using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatricalPlayersRefactoringKata.Domain.Model;

[Table("performance")]
public class Performance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    
    [ForeignKey(nameof(InvoiceId))] 
    [Column("invoice_id")]
    public int InvoiceId { get; set; }
    
    [ForeignKey(nameof(playId))] 
    [Column("play_id")]
    public int playId { get; set; }
    public DateTime time { get; set; }
    public int audience { get; set; }
    [Column("credits_earned")]public int creditsEarned { get; set; }
    [Column("cal_performance")]public decimal calPerformance { get; set; }
    
 
}