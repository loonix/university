using CamadaNegocio;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Windows.Controls;


namespace AppStatistics.UserControls
{
    /// <summary>
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : UserControl
    {
        public SeriesCollection GenderSeries { get; set; }
        private List<Download> Downloads { get; set; }

        public PieChart()
        {
            InitializeComponent();
        }

        public void FillData(List<Download> downloads)
        {
            this.Downloads = downloads;
            this.GetGenderSeriesCollection(downloads);
        }

        private void GetGenderSeriesCollection(List<Download> downloadsFiltered)
        {
            var totalMale = 0;
            var totalFemale = 0;
            var male = "Male";
            var female = "Female";

            foreach (var item in downloadsFiltered)
            {
                if (item.Gender == male) totalMale += 1;
                if (item.Gender == female) totalFemale += 1;
            }

            GenderSeries = new SeriesCollection
            {
                new PieSeries
                {
                    Title = male,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(totalMale) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = female,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(totalFemale) },
                    DataLabels = true
                },
            };
            this.genderChart.Series = this.GenderSeries;
            //DataContext = this;

        }
    }
}
