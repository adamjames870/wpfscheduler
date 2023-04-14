using System.Collections.ObjectModel;

namespace WpfSchedulerAdam.Data;

public class DataFactory
{

    private readonly MakeSampleData _makeSampleData;

    public DataFactory()
    {
        _makeSampleData = new MakeSampleData();
    }
    
    public ObservableCollection<ActivityModel> GetActivities()
    {
        return _makeSampleData.GetActivityModelCollection();
    }
}