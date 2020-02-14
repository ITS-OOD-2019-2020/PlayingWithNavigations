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
    /// Interaction logic for PageFunction1.xaml
    /// </summary>
    public partial class PageFunction1 : PageFunction<String>
    {
        public PageFunction1()
        {
            InitializeComponent();
        }

        public PageFunction1(string initialData):this()
        {
            this.dataItem1TextBox.Text = initialData;
        }

        void okButton_Click(object sender, RoutedEventArgs e)
        {
            // Accept when Ok button is clicked
            OnReturn(new ReturnEventArgs<string>(this.dataItem1TextBox.Text));
        }

        void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cancel 
            OnReturn(null);
        }
    }
}
