namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private bool iranyFel = true, iranyBalra = true;
        private int lepesFel = 20, lepesOldalt =30;
        public MainForm()
        {
            InitializeComponent();
        }

        private void kattint_Click(object sender, EventArgs e)
        {
            Point point = kattint.Location;
            if(this.iranyFel && (point.Y - lepesFel) <=0)
            {
                this.iranyFel=false;
            }
            if (iranyBalra && (point.X - lepesOldalt) <= 0)
            {
                iranyBalra = false;
            }

            if (!iranyFel && (point.Y - kattint.Height) + lepesFel < Height)
            {
                iranyFel=false;
               
            }

            if (iranyBalra && (point.X - kattint.Width) + lepesOldalt < Width)
            {
                iranyBalra=true;
                
            }
            point.X += iranyBalra ? -lepesOldalt : lepesOldalt;
            point.Y += iranyFel ? -lepesFel : lepesFel;

            kattint.Location = point;
        }
        private void kattint_MouseHover(object sender, EventArgs e)
        {
            kattint.BackColor = Color.Blue;
            
        }
        private void kattint_MouseLeave(object sender, EventArgs e)
        {
            kattint.BackColor = Color.White;
            kattint.Text = "Kattints rám!";
        }
       
    }
}
