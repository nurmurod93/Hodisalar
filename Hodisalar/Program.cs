namespace Hodisalar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video()
            {
                Nomi = "Falonchi",
                Formati = ".mp4",
                Sifati = "1080p",
                Hajmi = 144
            };

            var videoEncoder = new VideoEncoder(); // publisher - noshir/nashriyotchi
            var mailService = new MailService(); // subscriber - obunachi
            var messageService = new MessageService(); // subscriber - obunachi

            videoEncoder.VideoniOgir += mailService.VideoShifrlandiPochtaUchun;
            videoEncoder.VideoniOgir += messageService.VideoShifrlandiXabarUchun;

            videoEncoder.Shifrla(video);
        }
    }
}