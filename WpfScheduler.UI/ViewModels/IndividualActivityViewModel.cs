using System;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using WpfSchedulerAdam.Data;
using WpfSchedulerAdam.Models;
using WpfSchedulerAdam.Views.Controls;

namespace WpfSchedulerAdam.ViewModels;

public class IndividualActivityViewModel : BaseViewModel
{

    public ICommand MouseUpCommand { get; private set; }
    
    private readonly RangePanelModel _rangePanelModel;
    private readonly ActivityModel _activityModel;
    
    public IndividualActivityViewModel(ActivityModel activityModel, RangePanelModel rangePanelModel)
    {
        _activityModel = activityModel;
        _rangePanelModel = rangePanelModel;
        
        MouseUpCommand = new RelayCommand<MouseButtonEventArgs>(MouseUpEvent);
        
        
    }

    private void MouseUpEvent(MouseButtonEventArgs? args)
    {
        if (args == null) return;
        var activityView = (IndividualActivityView)args.Source;
        var activity = (IndividualActivityViewModel)activityView.DataContext; 
        MessageBox.Show($"MouseUpEvent: {activity.Title}");
    }

    public int ctivityId => _activityModel.ActivityId;
    
    public string Title
    {
        get => _activityModel.Title;
        set
        {
            _activityModel.Title = value;
            RaisePropertyChanged(nameof(Title));
        }
    }

    public DateOnly Date => _activityModel.Date;
    public TimeOnly StartTime => _activityModel.StartTime;
    public TimeOnly EndTime => _activityModel.EndTime;

    public TimeSpan Duration => EndTime - StartTime;

    public int RowIndex => (StartTime.Hour - _rangePanelModel.RowsDisplay.StartHour) * _rangePanelModel.RowsDisplay.RowsPerHour;
    public int RowSpan => Duration.Hours * _rangePanelModel.RowsDisplay.RowsPerHour;
    
    public override string ToString()
    {
        return Title;
    }

}