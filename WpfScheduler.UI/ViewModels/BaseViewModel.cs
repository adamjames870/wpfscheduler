using System.ComponentModel;

namespace WpfSchedulerAdam.ViewModels;

public class BaseViewModel : INotifyPropertyChanged    
{
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected virtual void RaisePropertyChanged(string propertyName, object? oldValue = null)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}