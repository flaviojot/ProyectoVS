namespace Demos1
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

        private void button1_Click(object sender, EventArgs e)
        {

            int numero1 = 15;
            int numero2 = 5;
            int total = numero1 + numero2;

            textBox1.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = 15;
            int numero2 = 5;
            int total = numero1 - numero2;

            textBox2.Text = total.ToString();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = 15;
            int numero2 = 5;
            int total = numero1 * numero2;

            textBox3.Text = total.ToString();

        }
    }
}
