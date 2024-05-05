using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.WindowManagment;

namespace ToDoList
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e) => WindowActions.MoveWindow(this);

        private void CloseWindow(object sender, RoutedEventArgs e) => WindowActions.CloseWindow(this);

        private void MinimizeWindow(object sender, RoutedEventArgs e) => WindowActions.MinimizeWindow(this);
    }
}