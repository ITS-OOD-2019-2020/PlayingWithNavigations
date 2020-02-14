using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SimpleSecondWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Employee e1 = new Employee() { Name = "Tom Jones", ID = 1, Salary = 25000m };
            Employee e2 = new Employee() { Name = "Mary Jones", ID = 2, Salary = 35000m };
            Employee e3 = new Employee() { Name = "Sarah Jones", ID = 3, Salary = 45000m };

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);

            lbxDetails.ItemsSource = employees;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Owner = this;
            window2.ShowDialog();
        }
    }
}
