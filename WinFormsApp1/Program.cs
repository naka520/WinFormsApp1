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
            Label lb = new Label();
            lb.Width = fm.Width; lb.Height=fm.Height;
            string[] str = new string [3] { "âîïM", "è¡ÇµÉSÉÄ", "ÉyÉì" }; 
            foreach (string str2 in str) {
             lb.Text += str2+"\n";
            }

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