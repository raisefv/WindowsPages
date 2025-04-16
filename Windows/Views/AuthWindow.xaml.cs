using System.Windows;

namespace Windows.Views;

public partial class AuthWindow : Window
{
    private string _targetWindow;
    
    public AuthWindow(string targetWindow)
    {
        InitializeComponent();
        _targetWindow = targetWindow;
    }
    
    string _AdminUsername = "admin";
    string _AdminPassword = "admin";
    string _EmploUsername = "emplo";
    string _EmploPassword = "emplo";
    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (LoginTextBox.Text == _AdminUsername && PasswordBox.Password == _AdminPassword && _targetWindow == "Admin")
        {
            var adminWindow = new AdminWindow();
            adminWindow.Show();
        }
        else if (LoginTextBox.Text == _EmploUsername && PasswordBox.Password == _EmploPassword && _targetWindow == "Employee")
        {
            var employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль!");
            LoginTextBox.Clear();
            PasswordBox.Clear();
        }
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