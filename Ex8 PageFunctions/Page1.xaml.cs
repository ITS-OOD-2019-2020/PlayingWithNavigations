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

namespace Ex8_PageFunctions
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        void pageFunctionHyperlink_Click(object sender, RoutedEventArgs e)
        {

            // Instantiate and navigate to page function
            PageFunction1 CalledPageFunction = new PageFunction1("Initial Data Item Value");
            CalledPageFunction.Return += pageFunction_Return;
            this.NavigationService.Navigate(CalledPageFunction);
        }
        void pageFunction_Return(object sender, ReturnEventArgs<string> e)
        {
            this.pageFunctionResultsTextBlock.Visibility = Visibility.Visible;

            // Display result
            this.pageFunctionResultsTextBlock.Text = (e != null ? "Accepted" : "Canceled");

            // If page function returned, display result and data
            if (e != null)
            {
                this.pageFunctionResultsTextBlock.Text += "\n" + e.Result;
            }
        }
    }
}
