﻿using System;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            Page2 page = new Page2();

            NavigationService ns = this.NavigationService;

            ns.Navigate(page);
        }

        private void btnNextPage2_Click(object sender, RoutedEventArgs e)
        {
            Page2 page = new Page2("I've been passed this text");

            NavigationService ns = this.NavigationService;

            ns.Navigate(page);
        }

        private void btnNextPage3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }

        private void btnNextPage4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;

            if (ns.CanGoForward)
                ns.GoForward();
            else
                MessageBox.Show("Can't go forward");
        }
    }
}
