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
    /// SeatDataPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SeatDataPage : Page
    {
        private int tableNum = 1;
        private bool ViewMode = true;
        private SolidColorBrush red = new SolidColorBrush(Colors.Red);
        private SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow);

        public SeatDataPage(int tableNumber, bool mode)//mode = true : Menu, false : Category
        {
            InitializeComponent();

            this.tableNum = tableNumber;
            this.ViewMode = mode;

            ChartFrame.NavigationService.Navigate(new Kiosk.data.MenuDataPage_F(tableNumber));
        }

        private void Table_Click(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            //TableData item = (TableData)listBox.SelectedItem;
            
        }

        private void BTN_MenuClicked(object sender, RoutedEventArgs e)
        {
            if (this.ViewMode != true)
            {
                ChartFrame.NavigationService.Navigate(new Kiosk.data.MenuDataPage_F(this.tableNum));
                this.ViewMode = true;
            }
        }

        private void BTN_CategoryClicked(object sender, RoutedEventArgs e)
        {
            if (this.ViewMode != false)
            {
                ChartFrame.NavigationService.Navigate(new Kiosk.data.CategoryDataPage(this.tableNum));
                this.ViewMode = false;
            }
        }
    }
}
