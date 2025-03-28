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
    public Invoice invoice { get; set; }
    
    [ForeignKey(nameof(playId))] 
    [Column("play_id")]
    public int playId { get; set; }
    public Play play { get; set; }
    public int audience { get; set; }
    public int creditsEarned { get; set; }
 
}