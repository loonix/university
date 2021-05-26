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
        public int totalCountDownloads { get; set; }
        public int totalCountApps { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.totalDownloads = new ChartValues<int> { };
            this.setDates();
            this.ObterDownload();
            //this.GetGenderSeriesCollection();
            this.GetTotals();
            this.monthlyChartData.FillData(this.downloads);
        }

        private void setDates(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            this.DateFrom = dateFrom ?? DateTime.Today;
            this.DateTo = dateTo ?? DateTime.Today.AddDays(1);
        }

        //private void GetGenderSeriesCollection()
        //{
        //    GenderSeries = new SeriesCollection
        //    {
        //        new PieSeries
        //        {
        //            Title = "Male",
        //            Values = new ChartValues<ObservableValue> { new ObservableValue(8) },
        //            DataLabels = true
        //        },
        //        new PieSeries
        //        {
        //            Title = "Female",
        //            Values = new ChartValues<ObservableValue> { new ObservableValue(6) },
        //            DataLabels = true
        //        },
        //    };
        //}

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

        private void Calendar1_SelectedDatesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
