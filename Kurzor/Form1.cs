namespace Kurzor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int n = e.X;
            int m = e.Y;

            lblszoveg.Text = ($"X: {n}, Y:{m}");
            lblszoveg.Top = m;
            lblszoveg.Left = n;
        }
    }
}
