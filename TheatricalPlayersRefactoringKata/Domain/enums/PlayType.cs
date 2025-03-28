using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatricalPlayersRefactoringKata.Domain.enums;

[Table("play_type")]
public class PlayType
{
    [Key]
    public int id { get; set; } 
    [Required]
    public string name { get; set; } 
}