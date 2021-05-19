using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using CamadaNegocio;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace AppStatistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection GenderSeries { get; set; }
        public SeriesCollection MonthlyChartSeries { get; set; }
        public ChartValues<int> totalDownloads { get; }
        public DownloadCollection downloads { get; set; }
        public int totalCountDownloads { get; set; }
        public int totalCountApps { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            this.DateFrom = DateTime.Today;
            this.DateTo = DateTime.Today.AddDays(1);

            totalDownloads = new ChartValues<int> { };


            ObterDownload();

            GetMonthlyChart();


            GetGenderSeriesCollection();


            GetTotals();

            DataContext = this;
        }

        private void GetMonthlyChart()
        {
            MonthlyChartSeries = new SeriesCollection();
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Nov", "Dec" };

            List<IEnumerable<Download>> months = new List<IEnumerable<Download>>();

            for (int i = 1; i < 12; i++)
            {
                IEnumerable<Download> month = this.downloads.Where(download => download.Timestamp.Month == i).ToList();
                months.Add(month);
            }
            LineSeries lineSeries = new LineSeries();
            lineSeries.Title = "Count";

            ChartValues<int> charvals = new ChartValues<int>();


            for (int i = 0; i < 11; i++)
            {
                charvals.Add(this.downloads.Count(download => download.Timestamp.Month == i + 1));
              
            }

            lineSeries.Values = charvals;
            MonthlyChartSeries.Add(lineSeries);

            YFormatter = value => value.ToString("C");

        }

        private void GetGenderSeriesCollection()
        {
            GenderSeries = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Male",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(8) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Female",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(6) },
                    DataLabels = true
                },
            };
        }

        private void GetTotals()
        {
            this.totalCountDownloads = this.downloads.Count();
            this.totalCountApps = this.downloads.Select(x => x.AppName).Distinct().Count();

            ContadorContext contadorTotalDownloads = new ContadorContext("TOTAL DOWNLOADS", this.totalCountDownloads.ToString());
            this.contadorTotal.DataContext = contadorTotalDownloads;

            ContadorContext contadorTotalApps = new ContadorContext("TOTAL APPS", this.totalCountApps.ToString());
            this.contadorAppTotal.DataContext = contadorTotalApps;
        }

        private void ObterDownload()
        {
            DownloadCollection downloadCollection = Download.ObterListaDownloads();
            if (downloadCollection != null)
            {
                this.downloads = downloadCollection;
            }
        }
    }
}
