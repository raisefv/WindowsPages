using System.Windows;
using System.Windows.Controls;

namespace Windows.Views;

public partial class AdminWindow : Window
{
    private readonly AdminPage1 _page1;
    private readonly AdminPage2 _page2;

    public AdminWindow()
    {
        InitializeComponent();
        _page1 = new AdminPage1();
        _page2 = new AdminPage2();
        MainFrame.Navigate(_page1);
    }
    
    private void AdminPage1_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_page1);
    }

    private void AdminPage2_Click(object sender, RoutedEventArgs e)
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