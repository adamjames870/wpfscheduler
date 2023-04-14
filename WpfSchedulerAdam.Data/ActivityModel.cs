namespace WpfSchedulerAdam.Data;

public class ActivityModel
{
    public int ActivityId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string Title { get; set; }
    public int LocationId { get; set; }

    public ActivityModel()
    {

    }
}