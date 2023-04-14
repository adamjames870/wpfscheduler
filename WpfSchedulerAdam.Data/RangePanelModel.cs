namespace WpfSchedulerAdam.Data;

public class RangePanelModel
{
    public int SortIndex { get; set; }
    public CalendarDisplayModel CalendarDisplay { get; set; }
    public DateOnly Date { get; set; }
    public string Location { get; set; }
    
    public RangePanelModel()
    {
        
    }
}