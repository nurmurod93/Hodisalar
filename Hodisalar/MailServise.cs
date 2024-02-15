namespace Hodisalar
{
    public class MailService
    {
        public void VideoShifrlandiPochtaUchun(object source, VideoniShifrlaEventArgs args)
        {
            Console.WriteLine("MailService: Pochta jo'natilyapti - " + args.Video.Nomi);
        }
    }
}