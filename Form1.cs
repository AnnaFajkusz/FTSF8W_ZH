namespace FTSF8W_ZH
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Biztosan ki akar lépni?", "Megerõsít", buttons);
            if (result != DialogResult.Yes)
            { e.Cancel = true; }
            else { Application.Exit(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { 
                UserControl control1 = new UserControl();
                panel1.Controls.Add(control1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            { 
                Form2 form2 = new Form2(); form2.ShowDialog(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                UserControl control2 = new UserControl();
                panel1.Controls.Add(control2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                UserControl control3 = new UserControl();
                panel1.Controls.Add(control3);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                Form3 form3 = new Form3(); form3.ShowDialog(); 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                Form4 form4 = new Form4(); form4.ShowDialog();
            }
        }
    }

}
