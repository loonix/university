using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CamadaNegocio;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace AppStatistics
{
    /// <summary>
    /// Interaction logic for MonthlyChart.xaml
    /// </summary>
    public partial class MonthlyChart : UserControl
    {
        public string[] Labels { get; set; }
        public SeriesCollection MonthlyChartSeries { get; set; }
        private List<Download> Downloads { get; set; }

        public MonthlyChart()
        {
            InitializeComponent();
        }

        public void FillData(List<Download> downloads)
        {
            this.Downloads = downloads;
            this.GetMonthlyChart();
        }

        private void GetMonthlyChart()
        {
            MonthlyChartSeries = new SeriesCollection();
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Nov", "Dec" };

            List<IEnumerable<Download>> months = new List<IEnumerable<Download>>();

            if(this.Downloads == null) {

                DataContext = this;
                return; 
            }

            for (int i = 1; i < 12; i++)
            {
                IEnumerable<Download> month = this.Downloads.Where(dnl => dnl.Timestamp.Month == i).ToList();
                months.Add(month);
            }

            LineSeries lineSeries = new LineSeries();
            lineSeries.Title = "Count";
            lineSeries.Stroke = Brushes.Gray;
            lineSeries.Fill = Brushes.LightBlue;
            lineSeries.Configuration = new CartesianMapper<Point>();

            ChartValues<int> charvals = new ChartValues<int>();

            for (int i = 0; i < 11; i++)
            {
                charvals.Add(this.Downloads.Count(dnl => dnl.Timestamp.Month == i + 1));
            }

            lineSeries.Values = charvals;
            MonthlyChartSeries.Add(lineSeries);

            DataContext = this;
        }
    }
}
