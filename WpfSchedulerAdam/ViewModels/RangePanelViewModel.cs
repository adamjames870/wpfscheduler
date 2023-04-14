using System;
using System.Collections.ObjectModel;
using WpfSchedulerAdam.Data;

namespace WpfSchedulerAdam.ViewModels;

public class RangePanelViewModel : BaseViewModel
{
    private readonly ObservableCollection<ActivityViewModel> _activities;
    private readonly DateOnly _panelDate;
    private string _panelLocation;
    
    public RangePanelViewModel(DateOnly panelDate, string panelLocation, 
        ObservableCollection<ActivityModel> activities)
    {
        _panelDate = panelDate;
        _panelLocation = panelLocation;
        
        _activities = new ObservableCollection<ActivityViewModel>();
        foreach (var activity in activities)
        {
            _activities.Add(new ActivityViewModel(activity));
        }
    }
    
    public ObservableCollection<ActivityViewModel> Activities => _activities;
    public DateOnly PanelDate => _panelDate;
    public string PanelLocation => _panelLocation;
    
}