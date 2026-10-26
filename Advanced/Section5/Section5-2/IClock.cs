namespace Section5_2
{
    public interface IClock
    {
        /// <summary>
        /// 時刻を修正する
        /// </summary>
        public void AdjustTime();

        /// <summary>
        /// 時刻を知る
        /// </summary>
        public void ShowTime();
    }
}
