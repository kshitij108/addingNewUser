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
    /// Interaction logic for InfoForm.xaml
    /// </summary>
    public partial class InfoForm : Window
    {
        public InfoForm()
        {
            InitializeComponent();
            TbFirstName.Focus();
           
        }
/*
    private void ComboBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (warningConditionCheckBox.IsChecked == true)
        {
            // Warn about this situation
            var window = new MyDialog { Owner = GetWindow(this) };

            // Confirm to proceed
            if (window.ShowDialog() != true) {
                e.Handled = true;
            } 
            else {
                comboBox.IsDropDownOpen = true;
            }
        }
    }
  */   
    private void ButtonOkClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }
   
        private void AddButton(object sender, RoutedEventArgs e)
        {
            var F = new MainWindow();
            F.ShowDialog();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var newWindowHome = new MainWindow();
            newWindowHome.ShowDialog();

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
	    {
	        (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
          
        }
        //private void First_Option(object sender, RoutedEventArgs e)
        //{

        //    birthMonthDefault.Visibility = Visibility.Visible;
        //    birthMonth.Visibility = Visibility.Hidden;
        //    birthDate.Visibility = Visibility.Hidden;
        //    pswdLable.Visibility = Visibility.Hidden;
        //    pswdTextbox.Visibility = Visibility.Hidden;
           
        //}
        //private void Second_Option(object sender, RoutedEventArgs e)
        //{

        //    birthMonthDefault.Visibility = Visibility.Hidden;
        //    birthMonth.Visibility = Visibility.Hidden;
        //    birthDate.Visibility = Visibility.Hidden;
        //    pswdLable.Visibility = Visibility.Visible;
        //    pswdTextbox.Visibility = Visibility.Visible;
           
            
        //}
        //private void Third_Option(object sender, RoutedEventArgs e)
        //{

        //    birthMonthDefault.Visibility = Visibility.Hidden;
        //    birthMonth.Visibility = Visibility.Visible;
        //    birthDate.Visibility = Visibility.Visible;
        //    pswdLable.Visibility = Visibility.Hidden;
        //    pswdTextbox.Visibility = Visibility.Hidden;
            
        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AddUSerValue(object sender, RoutedEventArgs e)
        {
            test();
        }

        public void test()
        {

            //if (TbFirstName.Text == dbstring)
            //{
            //}
            String str = "";
            str = TbFirstName.Text + "  " + TbLastName.Text;
            if (pswType.SelectedIndex == -1)
            {
                str = "Please select the password and then add the user!";

            }
            if (pswType.SelectedIndex == 0)
            {
                str = str + " " + birthMonthDefault.Text;

            }
            if (pswType.SelectedIndex == 1)
            {
                str = str + " " + pswdTextbox.Text;

            }
            if (pswType.SelectedIndex == 2)
            {
                str = str + " " + birthMonth.Text + birthDate.Text;

            }

            //MessageBox showmsg;
            MessageBox.Show(str);
        
        }

        private void pswType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            if (pswType.SelectedIndex == 0)
            {
                birthMonthDefault.Visibility = Visibility.Visible;
                birthMonth.Visibility = Visibility.Hidden;
                birthDate.Visibility = Visibility.Hidden;
                pswdLable.Visibility = Visibility.Hidden;
                pswdTextbox.Visibility = Visibility.Hidden;
            }
            if (pswType.SelectedIndex == 1)
            {
                birthMonthDefault.Visibility = Visibility.Hidden;
                birthMonth.Visibility = Visibility.Hidden;
                birthDate.Visibility = Visibility.Hidden;
                pswdLable.Visibility = Visibility.Visible;
                pswdTextbox.Visibility = Visibility.Visible;
            }
            if (pswType.SelectedIndex == 2)
            {
                birthMonthDefault.Visibility = Visibility.Hidden;
                birthMonth.Visibility = Visibility.Visible;
                birthDate.Visibility = Visibility.Visible;
                pswdLable.Visibility = Visibility.Hidden;
                pswdTextbox.Visibility = Visibility.Hidden;
            }
        }

       
      
    }
}
