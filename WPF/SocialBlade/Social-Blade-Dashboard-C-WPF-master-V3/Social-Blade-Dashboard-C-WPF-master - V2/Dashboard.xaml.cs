using BusinessLayer;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Social_Blade_Dashboard
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection LastHourSeries { get; set; }
        public SeriesCollection LastHourSeries1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        public Func<ChartPoint, string> PointLabel { get; set; }

        private string cardValue;

        public string CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        private string cardText;

        public string CardTextChart
        {
            get { return cardText; }
            set { cardText = value; }
        }



        public Dashboard()



        {
            InitializeComponent();




            SeriesCollection = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {25,52,61,89},
                    StackMode = StackMode.Values,
                    DataLabels = true
                },
                 new StackedColumnSeries
                {
                    Values = new ChartValues<double> {-15,-75,-16,-49},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };
            LastHourSeries = new SeriesCollection
            {
                new LineSeries
                {
                    AreaLimit = -10,
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(3),
                        new ObservableValue(1),
                        new ObservableValue(9),
                        new ObservableValue(4),
                        new ObservableValue(5),
                        new ObservableValue(3),
                        new ObservableValue(1),
                        new ObservableValue(2),
                        new ObservableValue(3),
                        new ObservableValue(7),
                    }
                }
            };
            LastHourSeries1 = new SeriesCollection
            {
                new LineSeries
                {
                    AreaLimit = -10,
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(13),
                        new ObservableValue(11),
                        new ObservableValue(9),
                        new ObservableValue(14),
                        new ObservableValue(5),
                        new ObservableValue(3),
                        new ObservableValue(12),
                        new ObservableValue(2),
                        new ObservableValue(3),
                        new ObservableValue(7),
                    }
                }
            };
            Labels = new[] { "Feb 7", "Feb 8", "Feb 9", "Feb 10" };
            Formatter = value => value.ToString();
            DataContext = this;
            string imgCartoon = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString()}\\Images\\vdf.png";
            string imgavatar = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString()}\\Images\\avatar1.jpg";
           // ImgCartoon.Source = new BitmapImage(new Uri(imgCartoon));
            //avatar1.Source = new BitmapImage(new Uri(imgavatar));
            //avatar2.Source = new BitmapImage(new Uri(imgavatar));


            //#####################################################################################################################################################################################
            // Inicio do projeto Bruno Dashboard VDF Bruno Faria



            this.DataInicioDatePicker.SelectedDate = DateTime.Today.AddMonths(-12);
            this.DataFimDatePicker.SelectedDate = DateTime.Today;

            this.DataInicioDatePicker.SelectedDateChanged += Data_SelectedDateChanged;
            this.DataFimDatePicker.SelectedDateChanged += Data_SelectedDateChanged;

            this.cardValue = string.Empty;
            this.cardText = string.Empty;


            PointLabel = chartPoint => string.Format("{0}({1:p})", chartPoint.Y, chartPoint.Participation);

            this.RecarregarDados();

        }




        #region Metodos   

        private void RecarregarDados()
        {

            DateTime dataInicioEscolhida = (DateTime)DataInicioDatePicker.SelectedDate;
            DateTime dataFimEscolhida = (DateTime)DataFimDatePicker.SelectedDate;

            if (dataInicioEscolhida <= dataFimEscolhida)
            {
                this.projetoVdfs = ProjetoVdf.ObterListaSimples();
                this.projetoVdfsfiltrado = new ProjetoVdfCollection();

                if (this.projetoVdfs != null)

                {
                    foreach (ProjetoVdf item in this.projetoVdfs)
                    {
                        bool adicionar = false;

                        if (item.NomePV == this.valorFiltroNomePV || this.valorFiltroNomePV == string.Empty)

                        {
                            if (item.DataDaProposta >= dataInicioEscolhida && item.DataDaProposta <= dataFimEscolhida)
                            {
                                adicionar = true;
                            }

                        }

                        if (adicionar == true)
                        {

                            this.projetoVdfsfiltrado.Add(item);
                        }

                    }

                }

                this.PreencherDados();
                this.ContarProjetosInProgress();
                this.ContarProjetosOnHold();
                this.ContarProjetosInfoPend();
                this.ContarProjetosSucasePend();
                this.ContarProjetosFechados();
                this.ContarProjetosPropostaApresentada();
                this.PreencherDadosChart();
            }

        }

        private ProjetoVdfCollection projetoVdfs;

        private ProjetoVdfCollection projetoVdfsfiltrado;

        private string valorFiltroNomePV = string.Empty;

        private void PreencherDados()
        {
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in this.projetoVdfsfiltrado)
            {
                totalValue++;
            }

            Cartao card = new Cartao("Total", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.Summation);
            this.totalCard.DataContext = card;
        }

        private void PreencherDadosChart()
        {
            this.pipChart.Series.Clear();
            this.AdicionarSeries("Total", (Cartao)this.totalCard.DataContext);
            this.AdicionarSeries("InProgress", (Cartao)this.inProgressCard.DataContext);
            this.AdicionarSeries("OnHold", (Cartao)this.onHoldCard.DataContext);
            this.AdicionarSeries("InfoPend", (Cartao)this.infoPendCard.DataContext);
            this.AdicionarSeries("SubCasePend", (Cartao)this.subecasePendCard.DataContext);
            this.AdicionarSeries("ClosePend", (Cartao)this.closePendCard.DataContext);
            this.AdicionarSeries("ProposalPend", (Cartao)this.proposalCard.DataContext);
  
        }

        private void AdicionarSeries(string titulo, Cartao card)
        {
            PieSeries pieSeries = new PieSeries();

       
                pieSeries.LabelPoint = point => point.Participation.ToString("P");
            pieSeries.Title = titulo;
            pieSeries.DataLabels = true;

            ChartValues<int> values = new ChartValues<int>();



            int valor = 0;

            if (int.TryParse(card.CardValue, out valor))
            {
                if (valor > 0)
                {
                  

                    values.Add(valor);
                    pieSeries.Values = values;

                    this.pipChart.Series.Add(pieSeries);
                }

            }
        }

        private void AdicionarSeries1(int titulo, Cartao card)
        {
          

           

        }




        private void ContarProjetosInProgress()
        {
            //Totais Globais nº projetos em progresso ?
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in this.projetoVdfsfiltrado)
            {

                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.Inprogress)
                {
                    totalValue++;
                }
                Cartao card = new Cartao("Em progresso", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.ProgressAlert);
                this.inProgressCard.DataContext = card;

            }

        }

        private void ContarProjetosOnHold()
        {
            //Totais Globais nº projetos em progresso ?
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in projetoVdfsfiltrado)
            {

                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.OnHold)
                {
                    totalValue++;
                }
                Cartao card = new Cartao("Em Espera", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.CarBrakeHold);
                this.onHoldCard.DataContext = card;

            }

        }

        private void ContarProjetosInfoPend()
        {
            //Totais Globais nº projetos em progresso ?
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in projetoVdfsfiltrado)
            {

                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.InformationPend)
                {
                    totalValue++;
                }
                Cartao card = new Cartao("Pendente", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.AccountPending);
                this.infoPendCard.DataContext = card;

            }

        }

        private void ContarProjetosSucasePend()
        {
            //Totais Globais nº projetos em progresso ?
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in projetoVdfsfiltrado)
            {

                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.SubCasePend)
                {
                    totalValue++;
                }
                Cartao card = new Cartao("Sub-Pedido", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.Dependency);
                this.subecasePendCard.DataContext = card;

            }

        }
        private void ContarProjetosFechados()
        {
            //Totais Globais nº projetos em progresso ?
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in projetoVdfsfiltrado)
            {

                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.ClosePend)
                {
                    totalValue++;
                }
                Cartao card = new Cartao("Fechado", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.Close);
                this.closePendCard.DataContext = card;

            }

        }

        private void ContarProjetosPropostaApresentada()
        {
            //Totais Globais nº projetos em progresso ?
            int totalValue = 0;


            foreach (ProjetoVdf projetoVdf in projetoVdfsfiltrado)
            {

                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.Proposal)
                {
                    totalValue++;
                }
                Cartao card = new Cartao("Em Proposta", totalValue.ToString(), MaterialDesignThemes.Wpf.PackIconKind.Deal);
                this.proposalCard.DataContext = card;

            }

        }



        #endregion Metodos

        #region eventos
        private void pipChart_Loaded(object sender, RoutedEventArgs e)
        {
            this.RecarregarDados();

        }
        private void cartesianChart_Loaded(object sender, RoutedEventArgs e)
        {
            this.RecarregarDados();
        }


        private void nomePV_PreVendaChange(object sender, EventArgs e)
        {
            //MessageBox.Show(this.FiltroNomePV.NomePV);
            this.valorFiltroNomePV = this.FiltroNomePV.NomePV;

            this.RecarregarDados();
        }


        private void Data_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            this.RecarregarDados();
        }

        #endregion eventos

       
    }

}

