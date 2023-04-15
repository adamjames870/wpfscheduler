using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfSchedulerAdam.Models;

namespace WpfSchedulerAdam.ViewModels;

public class TimeColumnViewModel : BaseViewModel
{
    private ObservableCollection<TimeColInfo> _times;
    private RowsDisplayConfiguration _rowsDisplayConfiguration;

    public TimeColumnViewModel(RowsDisplayConfiguration rowsDisplayConfiguration)
    {
        _rowsDisplayConfiguration = rowsDisplayConfiguration;
        var timeLabel = _rowsDisplayConfiguration.StartHour;
        _times = new ObservableCollection<TimeColInfo>();
        for (int i = 0; i < RowCount; i++)
        {
            var x = new TimeColInfo();
            x.RowIndex = i;
            if ( (i % _rowsDisplayConfiguration.RowsPerHour) == 0)
            {
                x.TimeLabel=$"{timeLabel:00}:00";
                timeLabel++;
            }
            else
            {
                x.TimeLabel = " ";
            }
            _times.Add(x);
        }
    }
    
    public ObservableCollection<TimeColInfo> Times => _times;
    public int RowCount => _rowsDisplayConfiguration.HoursToDisplay * _rowsDisplayConfiguration.RowsPerHour;

    public class TimeColInfo
    {
        public int RowIndex { get; set; }
        public string TimeLabel { get; set; }
    }
    
}

