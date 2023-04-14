using System.Collections.ObjectModel;
using TimeOnly = System.TimeOnly;

namespace WpfSchedulerAdam.Data;

public class MakeSampleData
{
    private ActivityModel _activityDay1MainShow;
    private ActivityModel _activityDay1LoungeShow;
    private ActivityModel _activityDay1ShopOpening;
    private ActivityModel _activityDay1SpaOpening;
    private ActivityModel _activityDay2MainShow;
    private ActivityModel _activityDay2LoungeShow;
    private ActivityModel _activityDay2ShopOpening;
    private ActivityModel _activityDay2SpaOpening;
    private ActivityModel _activityDay3MainShow;
    private ActivityModel _activityDay3LoungeShow;
    private ActivityModel _activityDay3ShopOpening;
    private ActivityModel _activityDay3SpaOpening;

    private readonly ObservableCollection<ActivityModel> _activityModels;

    public MakeSampleData()
    {
        CreateActivityModels();
        _activityModels = new ObservableCollection<ActivityModel>();
        AddActivityModels();
    }

    public ObservableCollection<ActivityModel> GetActivityModelCollection()
    {
        return _activityModels;
    }

    private void CreateActivityModels()
    {
        _activityDay1LoungeShow = new ActivityModel()
        {
            ActivityId = 1,
            Title = "Lounge Show 1",
            Date = DateOnly.FromDateTime(DateTime.Today),
            StartTime = new TimeOnly(20, 0, 0),
            EndTime = new TimeOnly(20, 45, 0),
            LocationId = 2,
        };
        _activityDay1MainShow = new ActivityModel()
        {
            ActivityId = 2,
            Title = "Main Show 1",
            Date = DateOnly.FromDateTime(DateTime.Today),
            StartTime = new TimeOnly(21, 0, 0),
            EndTime = new TimeOnly(21, 45, 0),
            LocationId = 1,
        };
        _activityDay1ShopOpening = new ActivityModel()
        {
            ActivityId = 3,
            Title = "Shop Opening 1",
            Date = DateOnly.FromDateTime(DateTime.Today),
            StartTime = new TimeOnly(10, 0, 0),
            EndTime = new TimeOnly(18, 0, 0),
            LocationId = 3,
        };
        _activityDay1SpaOpening = new ActivityModel()
        {
            ActivityId = 4,
            Title = "Spa Opening 1",
            Date = DateOnly.FromDateTime(DateTime.Today),
            StartTime = new TimeOnly(08, 0, 0),
            EndTime = new TimeOnly(18, 0, 0),
            LocationId = 4,
        };
        _activityDay2LoungeShow = new ActivityModel()
        {
            ActivityId = 5,
            Title = "Lounge Show 2",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(1)),
            StartTime = new TimeOnly(20, 0, 0),
            EndTime = new TimeOnly(20, 45, 0),
            LocationId = 2,
        };
        _activityDay2MainShow = new ActivityModel()
        {
            ActivityId = 6,
            Title = "Main Show 2",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(1)),
            StartTime = new TimeOnly(21, 0, 0),
            EndTime = new TimeOnly(21, 45, 0),
            LocationId = 1,
        };
        _activityDay2ShopOpening = new ActivityModel()
        {
            ActivityId = 7,
            Title = "Shop Opening 2",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(1)),
            StartTime = new TimeOnly(10, 0, 0),
            EndTime = new TimeOnly(18, 0, 0),
            LocationId = 3,
        };
        _activityDay2SpaOpening = new ActivityModel()
        {
            ActivityId = 8,
            Title = "Spa Opening 2",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(1)),
            StartTime = new TimeOnly(08, 0, 0),
            EndTime = new TimeOnly(18, 0, 0),
            LocationId = 4,
        };
        _activityDay3LoungeShow = new ActivityModel()
        {
            ActivityId = 9,
            Title = "Lounge Show 3",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(2)),
            StartTime = new TimeOnly(20, 0, 0),
            EndTime = new TimeOnly(20, 45, 0),
            LocationId = 2,
        };
        _activityDay3MainShow = new ActivityModel()
        {
            ActivityId = 10,
            Title = "Main Show 3",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(2)),
            StartTime = new TimeOnly(21, 0, 0),
            EndTime = new TimeOnly(21, 45, 0),
            LocationId = 1,
        };
        _activityDay3ShopOpening = new ActivityModel()
        {
            ActivityId = 11,
            Title = "Shop Opening 3",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(2)),
            StartTime = new TimeOnly(10, 0, 0),
            EndTime = new TimeOnly(18, 0, 0),
            LocationId = 3,
        };
        _activityDay3SpaOpening = new ActivityModel()
        {
            ActivityId = 12,
            Title = "Spa Opening 3",
            Date = DateOnly.FromDateTime(DateTime.Today.AddDays(2)),
            StartTime = new TimeOnly(08, 0, 0),
            EndTime = new TimeOnly(18, 0, 0),
            LocationId = 4,
        };
    }

    private void AddActivityModels()
    {
        _activityModels.Add(_activityDay1MainShow);
        _activityModels.Add(_activityDay1LoungeShow);
        _activityModels.Add(_activityDay1ShopOpening);
        _activityModels.Add(_activityDay1SpaOpening);
        _activityModels.Add(_activityDay2MainShow);
        _activityModels.Add(_activityDay2LoungeShow);
        _activityModels.Add(_activityDay2ShopOpening);
        _activityModels.Add(_activityDay2SpaOpening);
        _activityModels.Add(_activityDay3MainShow);
        _activityModels.Add(_activityDay3LoungeShow);
        _activityModels.Add(_activityDay3ShopOpening);
        _activityModels.Add(_activityDay3SpaOpening);
    }

}