namespace Hodisalar
{
    public class MessageService
    {
        public void VideoShifrlandiXabarUchun(object source, VideoniShifrlaEventArgs args)
        {
            Console.WriteLine("MessageService: Xabar jo'natilyapti - " + args.Video.Nomi);
        }
    }
}