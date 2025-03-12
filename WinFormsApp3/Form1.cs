using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int countA = (int)numericUpDown1.Value;
            int countB = (int)numericUpDown2.Value;

            HashSet<int> setA = GenerateSet(countA);
            HashSet<int> setB = GenerateSet(countB);

            box1.Items.Clear();
            box3.Items.Clear();
            box4.Items.Clear();
            box2.Items.Clear();
            box5.Items.Clear();
            box6.Items.Clear();

            foreach (var item in setA) box1.Items.Add(item.ToString());
            foreach (var item in setB) box2.Items.Add(item.ToString());
            foreach (var item in setA.Union(setB)) box3.Items.Add(item.ToString());
            foreach (var item in setA.Intersect(setB)) box4.Items.Add(item.ToString());
            foreach (var item in setA.Except(setB)) box5.Items.Add(item.ToString());
            foreach (var item in setB.Except(setA)) box6.Items.Add(item.ToString());
        }
        private HashSet<int> GenerateSet(int count)
        {
            HashSet<int> set = new HashSet<int>();
            while (set.Count < count)
            {
                set.Add(random.Next(0, 10000));
            }
            return set;
        }
    }
}
