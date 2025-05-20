using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Entities
{

    public class AlarmClock
    {
        public delegate void AlarmSound();
        public event AlarmSound OnAlarmSounded;

        public void Start()
        {
            Thread.Sleep(1000);
            if(OnAlarmSounded != null)
            {
                Console.WriteLine("Alarm ringin");
                Thread.Sleep(3000);
                OnAlarmSounded?.Invoke();
            }
        }
    }
}
