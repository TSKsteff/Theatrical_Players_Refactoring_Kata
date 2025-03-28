using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Domain.Model;

[Table("customer")]
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    [Column("credit_balance")]public int creditBalance { get; set; }
    
    public List<Invoice> invoices { get; set; }
}