using System;
using System.Windows;
using WpfSchedulerAdam.Data;
using WpfSchedulerAdam.ViewModels;

namespace WpfSchedulerAdam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var dataFactory = new DataFactory();
            var activities = dataFactory.GetActivities();
            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var mainWindowViewModel = new MainWindowViewModel(startDate, activities);
            
            DataContext = mainWindowViewModel;
            InitializeComponent();
        }
    }
}