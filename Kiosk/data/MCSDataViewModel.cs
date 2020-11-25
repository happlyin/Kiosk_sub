using Kiosk.model.Stats;
using Kiosk.remote;
using LiveCharts;
using LiveCharts.Wpf;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.data
{
    class MCSDataViewModel : BindableBase //(Menu, Category, Seat)DataPage ViewModel
    {
        private List<MenuCategoryData> _data = new List<MenuCategoryData>();

        public List<MenuCategoryData> data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }

        private int viewMode;

        public void SetData(int modeNumber)
        {
            StatsDataRemote remote = new StatsDataRemote();
            if(modeNumber == 1)
                this.data = remote.GetMenuData(0, 9);
            else
                this.data = remote.GetCategoryData(0, 9);
            this.viewMode = modeNumber;

        }

        public double[] GetSumCount()
        {
            List<double> buffer = new List<double>();
            for (int i = 0; i < data.Count; i++)
            {
                buffer.Add(Convert.ToDouble(data.ElementAt(i).count));
            }
            return buffer.ToArray();
        }

        public double[] GetSumProfits()
        {
            List<double> buffer = new List<double>();
            for (int i = 0; i < data.Count; i++)
            {
                buffer.Add(Convert.ToDouble(data.ElementAt(i).sumProfits));
            }
            return buffer.ToArray();
        }

        public string[] GetNames()
        {
            List<string> buffer = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                buffer.Add(data.ElementAt(i).name);
            }
            return buffer.ToArray();
        }
    }
}
