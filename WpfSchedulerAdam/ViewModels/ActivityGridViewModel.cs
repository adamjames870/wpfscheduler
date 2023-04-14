using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfSchedulerAdam.Data;

namespace WpfSchedulerAdam.ViewModels;

public class ActivityGridViewModel : BaseViewModel
{
    
    private readonly DateOnly _startDate;
    private readonly IEnumerable<ActivityModel> _allActivities;
    private readonly ObservableCollection<RangePanelViewModel> _rangePanelViewModels;
    private readonly CalendarDisplayModel _calendarDisplayModel;

    private readonly int _datesToDisplay = 3;
    private readonly int _locationsToDisplay = 4;

    public ActivityGridViewModel(DateOnly startDate, IEnumerable<ActivityModel> activities)
    {
        _startDate = startDate;
        _allActivities = activities;
        
        _calendarDisplayModel = new CalendarDisplayModel()
        {
            HoursToDisplay = 16,
            StartHour = 8,
            RowsPerHour = 1,
        };
        
        _rangePanelViewModels = new ObservableCollection<RangePanelViewModel>();

        var activityModels = _allActivities.ToList();
        var dates = activityModels
            .Where(act => act.Date >= _startDate)
            .GroupBy(act => act.Date)
            .Select(date => date.First())
            .OrderBy(act => act.Date)
            .Select(act => act.Date)
            .Take(_datesToDisplay)
            .ToList();

        var locations = activityModels
            .GroupBy(act => act.LocationId)
            .Select(location => location.First())
            .OrderBy(act => act.LocationId)
            .Select(act => act.LocationId)
            .Take(_locationsToDisplay)
            .ToList();

        int i = 0;
        
        foreach (var date in dates)
        {
            foreach (var loc in locations)
            {

                var rangePanelModel = new RangePanelModel()
                {
                    SortIndex = i,
                    CalendarDisplay = _calendarDisplayModel,
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
    public int ColumnsToDisplay => _datesToDisplay * _locationsToDisplay;

}