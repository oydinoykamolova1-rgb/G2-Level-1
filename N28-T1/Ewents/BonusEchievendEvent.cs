namespace N28_T1.Ewents;

public class BonusEchievendEvent
{
    public int UserId { get; set; }

    public decimal OldBonus { get; set; }

    public decimal NewBonus { get; set; }

    public decimal Threshold { get; set; }  

    public DateTime OccuredAt { get; set; } = DateTime.UtcNow;
}
