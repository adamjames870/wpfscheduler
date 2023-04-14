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
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
    }
}