using System;

namespace WpfSchedulerAdam.Models;

public class GridDisplayConfiguration
{
    public ColsDisplayConfiguration ColsDisplay { get; set; }
    public RowsDisplayConfiguration RowsDisplay { get; set; }
    public DateOnly StartDate;
    
}