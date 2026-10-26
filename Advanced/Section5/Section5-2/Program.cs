namespace Section5_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var alarmClock = new AlarmClock();

            alarmClock.SetAlarm();
            alarmClock.Alarm();
            alarmClock.StopAlarm();
            alarmClock.AdjustTime();
            alarmClock.ShowTime();
        }
    }
}
