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
    private readonly DateOnly _startDate;
    private readonly IEnumerable<ActivityModel> _allActivities;
    private ObservableCollection<RangePanelViewModel> _rangePanelViewModels;

    public MainWindowViewModel(DateOnly startDate, IEnumerable<ActivityModel> activities)
    {
        _startDate = startDate;
        _allActivities = activities;
        
        _rangePanelViewModels = new ObservableCollection<RangePanelViewModel>();
        
        var dates = _allActivities
            .Where(act => act.Date >= _startDate)
            .GroupBy(act => act.Date)
            .Select(date => date.First())
            .Select(act => act.Date)
            .ToList();

        var locations = _allActivities
            .GroupBy(act => act.LocationId)
            .Select(location => location.First())
            .Select(act => act.LocationId)
            .ToList();

        foreach (var date in dates)
        {
            foreach (var loc in locations)
            {

                var panelActivitiesCollection = new ObservableCollection<ActivityModel>(
                    _allActivities
                        .Where(act => act.Date == date && act.LocationId == loc));
                
                var viewModel = new RangePanelViewModel(date, loc.ToString(), panelActivitiesCollection);
                _rangePanelViewModels.Add(viewModel);

            }
        }
        
    }
    
    public ObservableCollection<RangePanelViewModel> RangePanels => _rangePanelViewModels;

}