namespace Section5_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cellPhone = new CellPhone();

            cellPhone.CallPhone();
            cellPhone.ReceivePhone();
            cellPhone.SendMail();
            cellPhone.ReceiveMail();
            cellPhone.PlayGame();
            cellPhone.BrowseWeb();
        }
    }
}
