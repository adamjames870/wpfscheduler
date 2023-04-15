using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WpfSchedulerAdam.Data;
using WpfSchedulerAdam.Models;

namespace WpfSchedulerAdam.ViewModels;

public class ActivityGridViewModel : BaseViewModel
{
    
    
    private readonly IEnumerable<ActivityModel> _allActivities;
    private readonly ObservableCollection<RangePanelViewModel> _rangePanelViewModels;
    private readonly GridDisplayConfiguration _gridDisplayConfiguration;
    
    public ActivityGridViewModel(GridDisplayConfiguration gridDisplayConfiguration, IEnumerable<ActivityModel> activities)
    {
        _gridDisplayConfiguration = gridDisplayConfiguration;
        _allActivities = activities;
        
        _rangePanelViewModels = new ObservableCollection<RangePanelViewModel>();

        var activityModels = _allActivities.ToList();
        var dates = activityModels
            .Where(act => act.Date >= _gridDisplayConfiguration.StartDate)
            .GroupBy(act => act.Date)
            .Select(date => date.First())
            .OrderBy(act => act.Date)
            .Select(act => act.Date)
            .Take(_gridDisplayConfiguration.ColsDisplay.DatesToDisplay)
            .ToList();

        var locations = activityModels
            .GroupBy(act => act.LocationId)
            .Select(location => location.First())
            .OrderBy(act => act.LocationId)
            .Select(act => act.LocationId)
            .Take(_gridDisplayConfiguration.ColsDisplay.LocationsToDisplay)
            .ToList();

        int i = 0;
        
        foreach (var date in dates)
        {
            foreach (var loc in locations)
            {

                var rangePanelModel = new RangePanelModel()
                {
                    SortIndex = i,
                    RowsDisplay = _gridDisplayConfiguration.RowsDisplay,
                    Date = date,
                    Location = loc.ToString(),
                };
                i++;
                
                var panelActivitiesCollection = new ObservableCollection<ActivityModel>(
                    activityModels
                        .Where(act => act.Date == date && act.LocationId == loc));
                
                var viewModel = new RangePanelViewModel(rangePanelModel, panelActivitiesCollection);
                _rangePanelViewModels.Add(viewModel);

            }
        }
        
    }

    public ObservableCollection<RangePanelViewModel> RangePanels => _rangePanelViewModels;
    public int ColumnsToDisplay => _gridDisplayConfiguration.ColsDisplay.ColsToDisplay();

}