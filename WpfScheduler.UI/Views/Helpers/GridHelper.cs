using System.Windows;
using System.Windows.Controls;

namespace WpfSchedulerAdam.Views.Helpers;

public class GridHelper
{
    public static readonly DependencyProperty RowCountProperty =
        DependencyProperty.RegisterAttached(
            "RowCount", typeof(int), typeof(GridHelper),
            new PropertyMetadata(-1, RowCountChanged));

    public static readonly DependencyProperty ColumnCountProperty =
        DependencyProperty.RegisterAttached(
            "ColumnCount", typeof(int), typeof(GridHelper),
            new PropertyMetadata(-1, ColumnCountChanged));
        
    public static int GetRowCount(DependencyObject obj)
    {
        return (int)obj.GetValue(RowCountProperty);
    }
    
    public static int GetColumnCount(DependencyObject obj)
    {
        return (int)obj.GetValue(ColumnCountProperty);
    }
    
    public static void SetRowCount(DependencyObject obj, int value)
    {
        obj.SetValue(RowCountProperty, value);
    }
    
    public static void SetColumnCount(DependencyObject obj, int value)
    {
        obj.SetValue(ColumnCountProperty, value);
    }

    public static void RowCountChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
    {
        if (obj is not Grid grid || (int)e.NewValue < 0) return;
        grid.RowDefinitions.Clear();
        for (var i = 0; i < (int)e.NewValue; i++)
        {
            var def = new RowDefinition() {Height = new GridLength(1, GridUnitType.Star)};
            grid.RowDefinitions.Add(def);
        }
    }

    public static void ColumnCountChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
    {
        if (obj is not Grid grid || (int)e.NewValue < 0) return;
        grid.ColumnDefinitions.Clear();
        for (var i = 0; i < (int)e.NewValue; i++)
        {
            var def = new ColumnDefinition() {Width = new GridLength(1, GridUnitType.Star)};
            grid.ColumnDefinitions.Add(def);
        }
    }
    
}
