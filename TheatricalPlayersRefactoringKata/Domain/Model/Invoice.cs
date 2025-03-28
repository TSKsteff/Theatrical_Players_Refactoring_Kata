using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.Model;

[Table("invoice")]
public class Invoice
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [ForeignKey(nameof(customerId))] 
    [Column("customer_id")]
    public int customerId { get; set; }
    public Customer customer { get; set; }
    
    [Column("issue_date")] public DateTime issueDate { get; set; } = DateTime.UtcNow;
    public List<Performance> performances { get; set; } = new List<Performance>();

}