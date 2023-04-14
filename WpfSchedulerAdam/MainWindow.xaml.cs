using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
            var mainWindowViewModel = new MainWindowViewModel(dataFactory.GetActivities());
            DataContext = mainWindowViewModel;
            InitializeComponent();
        }
    }
}