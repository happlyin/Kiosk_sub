using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.model.Stats
{
    class DayProfits : BindableBase
    {
        private int _sumProfits;
        private List<HourProfits> _hoursProfits;

        public int sumProfits
        {
            get { return _sumProfits; }
            set { SetProperty(ref _sumProfits, value); }
        }

        public List<HourProfits> hoursProfits
        {
            get { return _hoursProfits; }
            set { SetProperty(ref _hoursProfits, value); }
        }
    }
}
