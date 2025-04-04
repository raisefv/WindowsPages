using System.Windows;
using Windows.Views;

namespace Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ClientButton_Click(object sender, RoutedEventArgs e)
    {
        var clientWindow = new Views.ClientWindow();
        clientWindow.ShowDialog();
    }

    private void EmployeeButton_Click(object sender, RoutedEventArgs e)
    {
        var authWindow = new AuthWindow("Employee");
        authWindow.Show();
    }

    private void AdminButton_Click(object sender, RoutedEventArgs e)
    {
        var authWindow = new AuthWindow("Admin");
        authWindow.Show();
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