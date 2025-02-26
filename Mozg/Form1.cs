namespace Mozg
{
    public partial class Form1 : Form
    {
        private int valtMagas = 10, valtSzeles = 10, maxWidth = 1200,
            maxHeight = 900, minWidth = 0, minHeight = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private double opValtoz = 0.2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            if ((Location.X + Height) <= maxHeight)
            {
                Height += valtMagas;

            }
            if ((Location.X + Height) <= maxWidth)
            {

                Width += valtSzeles;
            }



        }



        private void btnCsok_Click(object sender, EventArgs e)
        {
            if (Width >= Width - valtSzeles)
            {
                Width -= valtSzeles;
            }

            Width -= Width - valtMagas >= minWidth ? valtSzeles : 0;
            Height -= Height - valtMagas >= minHeight ? valtMagas : 0;
        }

        private void btnFelul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, 0);
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Location.Y - valtMagas <= 0 ? 0 : Location.Y - valtMagas);
        }

        private void btnKozep_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Location.Y + valtMagas <= 0 ? 0 : Location.Y + valtMagas);
        }

        private void btnAlul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Screen.GetWorkingArea(this).Height - Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBalszel_Click(object sender, EventArgs e)
        {
            Location = new Point(0, Location.Y);
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X - valtSzeles < 0 ? 0 : Location.X - valtSzeles, Location.Y);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X + Width + valtSzeles >= Screen.GetWorkingArea(this).Width
                ? Screen.GetWorkingArea(this).Width - valtSzeles : Location.X + valtSzeles, Location.Y);
        }

        private void btnJobbsz_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, Location.Y);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Opacity += opValtoz;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Opacity -= opValtoz;
        }
    }
}
