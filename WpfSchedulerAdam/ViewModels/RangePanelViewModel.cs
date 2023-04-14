using System;
using System.Collections.ObjectModel;
using WpfSchedulerAdam.Data;

namespace WpfSchedulerAdam.ViewModels;

public class RangePanelViewModel : BaseViewModel
{
    private readonly ObservableCollection<ActivityViewModel> _activities;
    private DateOnly _panelDate { get; }
    
    public RangePanelViewModel(ObservableCollection<ActivityModel> activities, DateOnly panelDate)
    {
        _panelDate = panelDate;
        _activities = new ObservableCollection<ActivityViewModel>();
        foreach (var activity in activities)
        {
            if (activity.Date == _panelDate)  
                _activities.Add(new ActivityViewModel(activity));
        }
    }
    
    public ObservableCollection<ActivityViewModel> Activities => _activities;
    public DateOnly PanelDate => _panelDate;
    
}