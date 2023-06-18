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
           


            PictureBox[] pictureBox = new PictureBox[5];
            for (int i = 0; i < pictureBox.Length; i++) {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Image = Image.FromFile("c:\\car.bmp");
                pictureBox[i].Top = i*pictureBox[i].Height;
                pictureBox[i].Parent = fm;
            }
            Application.Run(fm);


        }
    }
}