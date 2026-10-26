namespace Section5_2
{
    public class AlarmClock : IAlarm, IClock
    {
        #region IAlarm

        /// <inheritdoc/>
        public void Alarm()
        {
            Console.WriteLine("アラームを鳴らす");
        }

        /// <inheritdoc/>
        public void SetAlarm()
        {
            Console.WriteLine("アラームをセットする");
        }

        /// <inheritdoc/>
        public void StopAlarm()
        {
            Console.WriteLine("アラームを止める");
        }

        #endregion

        #region  IClock
        
        /// <inheritdoc/>
        public void AdjustTime()
        {
            Console.WriteLine("時刻を修正する");
        }

        /// <inheritdoc/>
        public void ShowTime()
        {
            Console.WriteLine("時刻を知る");
        }
        
        #endregion
    }
}