﻿using System;
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
    /// MenuDataPage_F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuDataPage_F : Page
    {
        public MenuDataPage_F()
        {
            InitializeComponent();
            MenuChartFrame.NavigationService.Navigate(new Kiosk.data.MenuDataPage(0, 11));
        }

        public void UpdateData(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int nowIndex = (cb.SelectedIndex + 1) * 11;
            if(MenuChartFrame != null)
                MenuChartFrame.NavigationService.Navigate(new Kiosk.data.MenuDataPage(nowIndex - 11, nowIndex));
        }
    }
}
