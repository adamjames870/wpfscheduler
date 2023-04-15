using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using WpfSchedulerAdam.Data;
using WpfSchedulerAdam.Models;

namespace WpfSchedulerAdam.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private readonly ActivityGridViewModel _activityGridViewModel;
    private readonly TimeColumnViewModel _timeColumnViewModel;

    private int _datesToDisplay = 3;
    private int _locationsToDisplay = 4;

    public MainWindowViewModel()
    {
        var dataFactory = new DataFactory();
        var activities = dataFactory.GetActivities();
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        
        var rowsDisplayConfiguration = new RowsDisplayConfiguration()
        {
            HoursToDisplay = 16,
            StartHour = 8,
            RowsPerHour = 1,
        };
        
        var colsDisplayConfiguration = new ColsDisplayConfiguration()
        {
            DatesToDisplay = 3,
            LocationsToDisplay = 4,
        };
        
        var gridDisplayConfiguration = new GridDisplayConfiguration()
        {
            StartDate = startDate,
            RowsDisplay = rowsDisplayConfiguration,
            ColsDisplay = colsDisplayConfiguration,
        };
        
        _activityGridViewModel = new ActivityGridViewModel(gridDisplayConfiguration, activities);
        _timeColumnViewModel = new TimeColumnViewModel(rowsDisplayConfiguration);
    }
    
    public ActivityGridViewModel ActivityGridViewModel => _activityGridViewModel;
    public TimeColumnViewModel TimeColumnViewModel => _timeColumnViewModel;
    
    public int DatesToDisplay
    {
        get => _datesToDisplay;
        set
        {
            _datesToDisplay = value;
            RaisePropertyChanged(nameof(DatesToDisplay));
        }
    }
    
    public int LocationsToDisplay
    {
        get => _locationsToDisplay;
        set
        {
            _locationsToDisplay = value;
            RaisePropertyChanged(nameof(LocationsToDisplay));
        }
    }
    
}