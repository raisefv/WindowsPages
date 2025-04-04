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

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (LoginTextBox.Text == "admin" && PasswordBox.Password == "admin")
        {
            if (_targetWindow == "Employee")
            {
                var employeeWindow = new EmployeeWindow();
                employeeWindow.Show();
            }
            else if (_targetWindow == "Admin")
            {
                var adminWindow = new AdminWindow();
                adminWindow.Show();
            }
            Close();
        }else
        {
            MessageBox.Show("Неверный логин или пароль!");
            LoginTextBox.Clear();
            PasswordBox.Clear();
        }
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
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