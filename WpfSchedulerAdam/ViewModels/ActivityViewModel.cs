using System;
using System.Windows;
using WpfSchedulerAdam.Data;

namespace WpfSchedulerAdam.ViewModels;

public class ActivityViewModel : BaseViewModel
{
    
    private readonly ActivityModel _activityModel;
    
    public ActivityViewModel(ActivityModel activityModel)
    {
        _activityModel = activityModel;
    }
    
    public int ActivityId => _activityModel.ActivityId;
    
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
    
    public int RowIndex => StartTime.Hour - 8;
    public int RowSpan => Duration.Hours;
    
    public override string ToString()
    {
        return Title;
    }

}