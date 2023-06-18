namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Form fm;
            fm = new Form();
            fm.Text = "Hello";
            fm.Width = 250; fm.Height = 100;
            

            string[,] str = new string[4, 3]{
            { "“Œ‹","Tokyo","‚Æ‚¤‚«‚å‚¤"},
            { "–¼ŒÃ‰®","Nagoya","‚È‚²‚â"},
            { "‘åã","Osaka","‚¨‚¨‚³‚©"},
            { "•Ÿ‰ª","Hukuoka","‚Ó‚­‚¨‚©"}
            };
            Label lb = new Label();
            lb.Width = fm.Width; lb.Height = fm.Height;
            /*string[] str = new string [3] { "‰”•M", "Á‚µƒSƒ€", "ƒyƒ“" }; 
            foreach (string str2 in str) {
             lb.Text += str2+"\n";
            }*/

            // PictureBox[] pictureBox = new PictureBox[5];
            //for (int i = 0; i < pictureBox.Length; i++) {
            // pictureBox[i] = new PictureBox();
            //pictureBox[i].Image = Image.FromFile("c:\\car.bmp");
            //pictureBox[i].Top = i*pictureBox[i].Height;
            // pictureBox[i].Parent = fm;
            //  }

            lb.Parent = fm;
            Application.Run(fm);


        }
    }
}