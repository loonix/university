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
        public ChartValues<int> totalDownloads { get; set; }
        public DownloadCollection downloads { get; set; }
        public DownloadCollection allDownloads { get; set; }
        public int totalCountDownloads { get; set; }
        public int totalCountApps { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.totalDownloads = new ChartValues<int> { };
            this.ObterDownloads();
            this.GetTotals();
            this.setDates();
            this.GetGenderSeriesCollection();
            this.monthlyChartData.FillData(this.downloads);
        }

        private void setDates(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            this.DataInicio.SelectedDate = dateFrom ?? DateTime.Today.AddMonths(-1);
            this.DataFim.SelectedDate = dateTo ?? DateTime.Today;

            List<Download> downloadsFiltered = (
                from d in this.allDownloads
                where (d.Timestamp >= this.DataInicio.SelectedDate) && (d.Timestamp <= this.DataFim.SelectedDate)
                select d).ToList();


            //this.downloads = this.allDownloads.Where(d => (d.Timestamp >= this.DataInicio.SelectedDate) && (d.Timestamp <= this.DataFim.SelectedDate)).ToList();
            this.monthlyChartData.FillData(downloadsFiltered);
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
            this.totalCountDownloads = this.downloads?.Count() ?? 0;
            this.totalCountApps = this.downloads?.Select(x => x.AppName).Distinct().Count() ?? 0;

            ContadorContext contadorTotalDownloads = new ContadorContext("TOTAL DOWNLOADS", this.totalCountDownloads.ToString());
            this.contadorTotal.DataContext = contadorTotalDownloads;

            ContadorContext contadorTotalApps = new ContadorContext("TOTAL APPS", this.totalCountApps.ToString());
            this.contadorAppTotal.DataContext = contadorTotalApps;

        }

        private void ObterDownloads()
        {
            DownloadCollection downloadCollection = Download.ObterListaDownloads();
            if (downloadCollection != null)
            {
                this.allDownloads = downloadCollection;
            }
        }

        private void SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            setDates(this.DataInicio.SelectedDate);
            setDates(this.DataFim.SelectedDate);
        }
     
    }
}
