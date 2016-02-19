using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo.Mirror.GUI.Clock
{
    class ClockModel : BaseModel
    {
        DateTime currentTime;

        public DateTime CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                if (currentTime != value)
                {
                    currentTime = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override TimeSpan Inteval => TimeSpan.FromSeconds(1);

        public override void Update()
        {
            CurrentTime = DateTime.Now;
        }

    }
}
