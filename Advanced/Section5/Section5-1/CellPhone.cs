namespace Section5_1
{
    public class CellPhone : IPhone, IMailer, IComputer
    {
        #region  IPhone

        /// <inheritdoc/>
        public void CallPhone()
        {
            Console.WriteLine("電話を掛ける");
        }

        /// <inheritdoc/>
        public void ReceivePhone()
        {
            Console.WriteLine("電話を受ける");
        }

        #endregion

        #region  IMailer

        /// <inheritdoc/>
        public void ReceiveMail()
        {
            Console.WriteLine("メールを受信する");
        }

        /// <inheritdoc/>
        public void SendMail()
        {
            Console.WriteLine("メールを送る");
        }

        #endregion

        #region  IComputer

        /// <inheritdoc/>
        public void PlayGame()
        {
            Console.WriteLine("ゲームをする");
        }

        /// <inheritdoc/>
        public void BrowseWeb()
        {
            Console.WriteLine("ウェブを閲覧する");
        }

        #endregion
    }
}