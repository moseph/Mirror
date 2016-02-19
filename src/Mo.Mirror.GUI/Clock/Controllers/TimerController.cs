﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Mo.Mirror.GUI.Clock.Controllers
{
    static class TimerController
    {
        public static void RegisterModel(BaseModel model)
        {
            var timer = new DispatcherTimer();
            timer.Interval = model.Inteval;
            timer.Tick += model.TimerTick;
            timer.Start();
        }
    }
}
