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
            //F�gg�leges ir�ny v�ltoztat�sa
                this.iranyFel=false;
            }
            //V�zszintes ir�ny vizsg�l�sa
            if (iranyBalra && (point.X - lepesOldalt) <= 0)
            {
                //V�zszintes ir�ny v�ltoztat�sa
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
            point.X += iranyBalra ? -this.lepesOldalt : this.lepesOldalt;
            point.Y += iranyFel ? -this.lepesFel : this.lepesFel;

            kattint.Location = point;
        }
        private void kattint_MouseHover(object sender, EventArgs e)
        {
            kattint.BackColor = Color.Blue;
            
        }
        private void kattint_MouseLeave(object sender, EventArgs e)
        {
            kattint.BackColor = Color.White;
            kattint.Text = "Kattints r�m!";
        }
       
    }
}
