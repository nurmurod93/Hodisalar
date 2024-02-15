namespace Hodisalar
{
    public class VideoniShifrlaEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // // 1) Delegatni e'lon qilish
        // public delegate void VideoniBaytgaOgiruvchi(object source, VideoniShifrlaEventArgs args);

        // // 2) Event(hodisa)ni e'lon qilish
        // public event VideoniBaytgaOgiruvchi VideoniOgir;

        public event EventHandler<VideoniShifrlaEventArgs> VideoniOgir;

        /*
            // EventHandler
            public delegate void VideoniBaytgaOgiruvchi(object source, EventArgs args);
            public event VideoniBaytgaOgiruvchi VideoniOgir;

            public event EventHandler VideoniOgir;
        */

        /*
            // EventHandler<TEventArgs>
            public delegate void VideoniBaytgaOgiruvchi(object source, VideoniShifrlaEventArgs args);
            public event VideoniBaytgaOgiruvchi VideoniOgir;

            public event EventHandler<VideoniShifrlaEventArgs> VideoniOgir;
        */
        public void Shifrla(Video video)
        {
            Console.WriteLine("Videoni bayt formatga o'girdi.");
            Thread.Sleep(3000);

            BaytgaOgiribShifrlanganda(video);
        }

        // 3) Hodisani ro'y berishi
        protected virtual void BaytgaOgiribShifrlanganda(Video video)
        {
            if (VideoniOgir != null)
                VideoniOgir(this, new VideoniShifrlaEventArgs() { Video = video });
        }
    }
}