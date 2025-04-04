using System.Windows;
using System.Windows.Controls;

namespace Windows.Views;

public partial class EmployeeWindow : Window
{
    private readonly EmployeePage1 _page1;
    private readonly EmployeePage2 _page2;

    public EmployeeWindow()
    {
        InitializeComponent();
        _page1 = new EmployeePage1();
        _page2 = new EmployeePage2();
        MainFrame.Navigate(_page1);
    }
    
    private void EmployeePage1_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_page1);
    }

    private void EmployeePage2_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_page2);
    }
    
    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (MessageBox.Show("Вы уверены, что хотите закрыть окно?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.No)
        {
            e.Cancel = true;
        }
    }
}