using Events.Entities;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();
            Person person = new Person { FullName = "OskarNiggofsky"};

            alarmClock.OnAlarmSounded += person.WakeUp;
            AlarmClock.Start();
        }
    }
}
