namespace Section5_2
{
    public interface IAlarm
    {
        /// <summary>
        /// アラームをセットする
        /// </summary>
        public void SetAlarm();

        /// <summary>
        /// アラームを鳴らす
        /// </summary>
        public void Alarm();

        /// <summary>
        /// アラームを止める
        /// </summary>
        public void StopAlarm();
    }
}
