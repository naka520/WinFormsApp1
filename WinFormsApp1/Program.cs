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


            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("C:\\car.bmp");
            pictureBox.Parent = fm;
            Application.Run(fm);


        }
    }
}