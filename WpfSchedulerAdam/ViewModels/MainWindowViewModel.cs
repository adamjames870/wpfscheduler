using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using WpfSchedulerAdam.Data;

namespace WpfSchedulerAdam.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private readonly ActivityGridViewModel _activityGridViewModel;

    public MainWindowViewModel()
    {
        var dataFactory = new DataFactory();
        var activities = dataFactory.GetActivities();
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        _activityGridViewModel = new ActivityGridViewModel(startDate, activities);
    }
    
    public ActivityGridViewModel ActivityGridViewModel => _activityGridViewModel;
    
}