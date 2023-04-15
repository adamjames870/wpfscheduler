namespace WpfSchedulerAdam.Models;

public class ColsDisplayConfiguration
{
    public int DatesToDisplay { get; set; }
    public int LocationsToDisplay { get; set; }

    public int ColsToDisplay()
    {
        return DatesToDisplay * LocationsToDisplay;
    }
}