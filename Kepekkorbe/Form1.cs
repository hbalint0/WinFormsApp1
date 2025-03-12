using Kepekkorbe.Properties;

namespace Kepekkorbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void picture9_Click(object sender, EventArgs e)
        {

            Image valami;
            valami = picture1.Image;
            picture1.Image = picture2.Image;
            picture2.Image = picture3.Image;
            picture3.Image = picture4.Image;
            picture4.Image = picture5.Image;
            picture5.Image = picture6.Image;
            picture6.Image = picture7.Image;
            picture7.Image = picture8.Image;
            picture8.Image = valami;

        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }

        private void picture10_Click(object sender, EventArgs e)
        {
            Image valami;
            valami = picture1.Image;
            picture1.Image = picture8.Image;
            picture8.Image = picture7.Image;
            picture7.Image = picture6.Image;
            picture6.Image = picture5.Image;
            picture5.Image = picture4.Image;
            picture4.Image = picture3.Image;
            picture3.Image = picture2.Image;
            picture2.Image = valami;
        }
    }
}
