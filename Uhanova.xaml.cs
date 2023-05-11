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
    /// Логика взаимодействия для Uhanova.xaml
    /// </summary>
    public partial class Uhanova : Window
    {
        public Uhanova()
        {
            InitializeComponent();
            VVPSource source = new VVPSource();
            List<VVPSource> vvnp = new List<VVPSource>();
            vvnp = source.FillList();
            dataGrid_Table.ItemsSource = vvnp;
            dataGrid_Table.IsEnabled = false;
        }

        private void buttton_One_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Clear();
            DataVVP vvp = new DataVVP();
            vvp.InputVVP();
            //double[] x = vvp.years.Select(x => Convert.ToDouble(x)).ToArray();
            WpfPlot1.Plot.AddScatter(vvp.years, vvp.vvp);
            //WpfPlot1.Plot.XAxis.DateTimeFormat(true);
            WpfPlot1.Refresh();
            textBlock_one.Text = vvp.PercentVVP();

        }

        private void buttton_Two_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Clear();
            DataVVP vnp = new DataVVP();
            vnp.InputVNP();
            // double[] x = vnp.years.Select(x => Convert.ToDouble(x)).ToArray();
            WpfPlot1.Plot.AddScatter(vnp.years, vnp.vnp);
            //WpfPlot1.Plot.XAxis.DateTimeFormat(true);
            WpfPlot1.Refresh();
            textBlock_one.Text = vnp.PercentVNP();

        }
    }
}

