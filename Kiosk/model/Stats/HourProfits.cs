using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.model.Stats
{
    class HourProfits : BindableBase
    {
        private int _sumHourProfits;

        public int sumHourProfits
        {
            get { return _sumHourProfits; }
            set { SetProperty(ref _sumHourProfits, value); }
        }
    }
}
