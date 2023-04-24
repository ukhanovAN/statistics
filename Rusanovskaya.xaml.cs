using ScottPlot;
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
    /// Логика взаимодействия для Rusanovskaya.xaml
    /// </summary>
    public partial class Rusanovskaya : Window
    {
        public Rusanovskaya()
        {
            InitializeComponent();
        }
        private void buttton_One_Click(object sender, RoutedEventArgs e)
        {

            WpfPlot1.Plot.Clear();
            DataCourse course = new DataCourse();
            course.CoutOne();
            double[] x = course.dateTimes.Select(x => x.ToOADate()).ToArray();
            WpfPlot1.Plot.AddScatter(x, course.courseOne);
            WpfPlot1.Plot.XAxis.DateTimeFormat(true);
            WpfPlot1.Refresh();
        }

        private void buttton_Two_Click(object sender, RoutedEventArgs e)
        {

            DataCourse course = new DataCourse();
            course.CoutTwo();
            WpfPlot1.Plot.Clear();
            double[] x = course.dateTimes.Select(x => x.ToOADate()).ToArray();
            WpfPlot1.Plot.AddScatter(x, course.courseTwo);
            WpfPlot1.Plot.XAxis.DateTimeFormat(true);
            WpfPlot1.Refresh();
        }
    }
    }
