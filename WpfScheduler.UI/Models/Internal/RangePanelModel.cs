using System;

namespace WpfSchedulerAdam.Models.Internal;

public class RangePanelModel
{
    public int SortIndex { get; set; }
    public RowsDisplayConfiguration RowsDisplay { get; set; }
    public DateOnly Date { get; set; }
    public string Location { get; set; }
    
    public RangePanelModel()
    {
        
    }
}