using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for optionsPage.xaml
    /// </summary>
    public partial class optionsPage : Window
    {
        public optionsPage()
        {
            InitializeComponent();

        }
       
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new InfoForm();
            newWindow.ShowDialog();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
        private void ViewUser_Click(object sender, RoutedEventArgs e)
        {
            var viewWindowOption = new viewAllUser();
            viewWindowOption.ShowDialog();

        }
    }
}
