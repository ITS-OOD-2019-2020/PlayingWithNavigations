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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex3_Pages
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        public Page2(string message) : this()
        {
            tblkPageName.Text = message;
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
