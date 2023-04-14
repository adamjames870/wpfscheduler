using System;
using System.Collections.ObjectModel;
using WpfSchedulerAdam.Data;
using WpfSchedulerAdam.Models;

namespace WpfSchedulerAdam.ViewModels;

public class RangePanelViewModel : BaseViewModel
{
    private readonly ObservableCollection<IndividualActivityViewModel> _activities;
    private readonly RangePanelModel _rangePanelModel;

    public RangePanelViewModel(RangePanelModel rangePanelModel, 
        ObservableCollection<ActivityModel> activities)
    {
        _rangePanelModel = rangePanelModel;
        
        _activities = new ObservableCollection<IndividualActivityViewModel>();
        foreach (var activity in activities)
        {
            _activities.Add(new IndividualActivityViewModel(activity, _rangePanelModel));
        }
    }
    
    public ObservableCollection<IndividualActivityViewModel> Activities => _activities;
    public string PanelDate => _rangePanelModel.Date.ToString("dd-MMM");
    public string PanelLocation => _rangePanelModel.Location;
    public int RowCount => _rangePanelModel.RowsDisplay.HoursToDisplay * _rangePanelModel.RowsDisplay.RowsPerHour;
    public int ColumnIndex => _rangePanelModel.SortIndex;    
    
}