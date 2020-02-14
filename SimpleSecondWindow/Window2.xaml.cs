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
using System.Windows.Shapes;

namespace SimpleSecondWindow
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            string name = tbxName.Text;
            decimal salary = Convert.ToDecimal(tbxSalary.Text);

            Employee newEmployee = new Employee() { ID = id, Name = name, Salary = salary };

            MainWindow main = Owner as MainWindow;
            main.employees.Add(newEmployee);
            this.Close();

        }
    }
}
