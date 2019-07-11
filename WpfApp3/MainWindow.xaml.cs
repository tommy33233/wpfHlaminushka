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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Name="Name1", Age=100},
                new Employee(){Name="Name2", Age=101},
            };

            cmb4.ItemsSource = employees;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            cmb1.SelectedValue = tbInput1.Text;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            foreach (ComboBoxItem item in cmb2.Items)
                if (item.Content.ToString() == tbInput2.Text)
                {
                    cmb2.SelectedValue = item;
                    break;
                }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            foreach (object item in cmb3.Items)
                if (item.ToString() == tbInput3.Text)
                {
                    cmb3.SelectedValue = item;
                    break;
                }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            cmb4.SelectedValue = tbInput4.Text;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

