namespace ortalama_hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2, not3;
            double ort;
            not1 = Convert.ToInt32(textBox2.Text);
            not2 = Convert.ToInt32(textBox3.Text);
            not3 = Convert.ToInt32(textBox4.Text);
            ort = (double)(not1 + not2 + not3) / 3;
            textBox1.Text=ort.ToString();
        }
        
    }
}