using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kiosk.data
{
    /// <summary>
    /// MenuDataPae.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuDataPae : Page
    {
        private MCSDataViewModel viewModel;
        public MenuDataPae()
        {
            InitializeComponent();
            viewModel = new MCSDataViewModel();
            viewModel.SetData(1);

            SeriesCollection = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "판매 총 수량",
                    Values = new ChartValues<double> (viewModel.GetSumCount(0, 11))
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new RowSeries
            {
                Title = "판매 총 총액",
                Values = new ChartValues<double>(viewModel.GetSumProfits(0, 11))
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection[1].Values.Add(48d);

            Labels =  viewModel.GetNames(0, 11);
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public void UpdateData(object sender, SelectionChangedEventArgs e)
        {
            int nowIndex = (xComboBox.SelectedIndex + 1) * 11;
            
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
