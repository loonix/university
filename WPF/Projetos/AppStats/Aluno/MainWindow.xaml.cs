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
        public ChartValues<int> totalDownloads { get; set; }
        public DownloadCollection allDownloads { get; set; }
        public int totalCountDownloads { get; set; }
        public int totalCountApps { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataInicio.SelectedDate =  DateTime.Today.AddYears(-1);
            this.DataFim.SelectedDate =  DateTime.Today;
            this.DataInicio.SelectedDateChanged += SelectedDateChanged;
            this.DataFim.SelectedDateChanged += SelectedDateChanged;
            Init();
        }

        private void Init()
        {
            this.totalDownloads = new ChartValues<int> { };
            this.ObterDownloads();
            this.refreshData();
        }

        private void refreshData()
        {
            DateTime? dataInicio = this.DataInicio.SelectedDate;
            DateTime? dataFim = this.DataFim.SelectedDate;
            List<Download> downloadsFiltered = new List<Download>();
            if (dataInicio.HasValue && dataFim.HasValue && dataInicio <= dataFim)
            {
            downloadsFiltered = (
                from d in this.allDownloads
                where (d.Timestamp >= dataInicio.Value) && (d.Timestamp <= dataFim.Value)
                select d).ToList();
            }
            monthlyChartData.FillData(downloadsFiltered);
            GetTotals(downloadsFiltered);
            pieChartData.FillData(downloadsFiltered);
            DataContext = this;
        }

    

       

        private void GetTotals(List<Download> downloadsFiltered)
        {
            this.totalCountDownloads = downloadsFiltered?.Count() ?? 0;
            this.totalCountApps = downloadsFiltered?.Select(x => x.AppName).Distinct().Count() ?? 0;

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
            refreshData();
        }
     
    }
}
