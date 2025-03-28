using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatricalPlayersRefactoringKata.Domain.Interface;

namespace TheatricalPlayersRefactoringKata.Domain.Model;

[Table("play")]
public class Play 
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    public string title { get; set; }
    public int lines { get; set; }

    [ForeignKey(nameof(playTypeId))]
    [Column("play_type_id")]
    public int playTypeId { get; set; }

    public List<Performance> performances { get; set; } = new List<Performance>(); 
    

}