using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WpfSchedulerAdam.Data;

namespace WpfSchedulerAdam.ViewModels;

public class MainWindowViewModel : BaseViewModel
{

    private readonly ObservableCollection<ActivityViewModel> _activities;
    private DateOnly _panelDate { get; }

    public MainWindowViewModel(ObservableCollection<ActivityModel> activities)
    {
        _panelDate = DateOnly.FromDateTime(DateTime.Now);
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