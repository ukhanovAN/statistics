using ScottPlot.Drawing.Colormaps;
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

namespace gitt
{
    /// <summary>
    /// Логика взаимодействия для Karkina.xaml
    /// </summary>
    public partial class Karkina : Window
    {
        public Karkina()
        {
            InitializeComponent();
            SalarySource salarySource = new SalarySource();
            List<SalarySource> list = new List<SalarySource>();
            list = salarySource.FillList();
            dataGrid_Table.ItemsSource = list;
            dataGrid_Table.IsEnabled = false;
        }

        private void buttton_One_Click(object sender, RoutedEventArgs e)
        {

            WpfPlot1.Plot.Clear();
            DataSalary salary = new DataSalary();
            salary.ShowGraph();
            WpfPlot1.Plot.AddScatter(salary.datesYear, salary.salaryOne);
            WpfPlot1.Refresh();
        }

        private void buttton_Two_Click(object sender, RoutedEventArgs e)
        {
            DataSalary salary = new DataSalary();
            textBlock_one.Text += "Тееекст";
            textBlock_two.Text += "Текст";
        }
    }
}
