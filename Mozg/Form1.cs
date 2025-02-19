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

        private void Form1_Click(object sender, EventArgs e)
        {

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
    }
}
