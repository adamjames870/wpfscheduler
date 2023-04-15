using System;
using System.Windows;
using WpfSchedulerAdam.Data;
using WpfSchedulerAdam.Models;

namespace WpfSchedulerAdam.ViewModels;

public class IndividualActivityViewModel : BaseViewModel
{
    
    private readonly RangePanelModel _rangePanelModel;
    private readonly ActivityModel _activityModel;
    
    public IndividualActivityViewModel(ActivityModel activityModel, RangePanelModel rangePanelModel)
    {
        _activityModel = activityModel;
        _rangePanelModel = rangePanelModel;
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

    public int RowIndex => (StartTime.Hour - _rangePanelModel.RowsDisplay.StartHour) * _rangePanelModel.RowsDisplay.RowsPerHour;
    public int RowSpan => Duration.Hours * _rangePanelModel.RowsDisplay.RowsPerHour;
    
    public override string ToString()
    {
        return Title;
    }

}