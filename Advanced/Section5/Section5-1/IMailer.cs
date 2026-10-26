namespace Section5_1
{
    public interface IMailer
    {
        /// <summary>
        /// メールを送信する
        /// </summary>
        public void SendMail();

        /// <summary>
        /// メールを受信する
        /// </summary>
        public void ReceiveMail();
    }
}
