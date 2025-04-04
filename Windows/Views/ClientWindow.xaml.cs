using System.Windows;
using System.Windows.Controls;

namespace Windows.Views;

public partial class ClientWindow : Window
{
    private readonly ClientPage1 _page1;
    private readonly ClientPage2 _page2;

    public ClientWindow()
    {
        InitializeComponent();
        _page1 = new ClientPage1();
        _page2 = new ClientPage2();
        MainFrame.Navigate(_page1);
    }
    
    private void ClientPage1_Click(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_page1);
    }

    private void ClientPage2_Click(object sender, RoutedEventArgs e)
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