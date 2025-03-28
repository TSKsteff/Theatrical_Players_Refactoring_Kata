using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatricalPlayersRefactoringKata.Domain.enums;
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
    public PlayType playType { get; set; }
    
   
    public Play(){}
    
    private readonly IPlayCalculationStrategy _calculationStrategy;

    public Play(IPlayCalculationStrategy calculationStrategy)
    {
        _calculationStrategy = calculationStrategy;
    }

    public decimal CalculatePerformanceCost(int audience)
        => _calculationStrategy.CalculatePerformanceCost(lines, audience);

    public int CalculateCredits(int audience)
        => _calculationStrategy.CalculateCredits(audience);

}