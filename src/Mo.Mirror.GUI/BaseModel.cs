using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo.Mirror.GUI
{
    abstract class BaseModel : PropertyChangedBase
    {
        public abstract TimeSpan Inteval { get; }

        public abstract void Update();

        internal void TimerTick(object sender, object e)
        {
            Update();
        }
    }
}
