namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Tất cả";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fMuontrasach f = new fMuontrasach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fMuontrasach f = new fMuontrasach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fMuontrasach f = new fMuontrasach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}