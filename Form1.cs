namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool plus = false, minus = false, equals = false, taghsim = false, percent = false, zarb = false;
        double result1, result2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            zarb = true;
        }

        private void numbers(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += ((Button)sender).Text.ToString();
            }
            else
            {
                textBox1.Text = ((Button)sender).Text.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text += ".";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            plus = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 + result2;
                textBox1.Text = my_result.ToString();
                plus = false;
            }
            else if (minus == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 - result2;
                textBox1.Text = my_result.ToString();
                minus = false;
            }
            else if (zarb == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 * result2;
                textBox1.Text = my_result.ToString();
                zarb = false;
            }
            else if (taghsim == true)
            {
                result2 = Convert.ToDouble(textBox1.Text);
                double my_result = result1 / result2;
                textBox1.Text = my_result.ToString();
                taghsim = false;
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            minus = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            result1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            taghsim = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result1 = 0;
            result2 = 0;
            textBox1.Text = "0";
            taghsim = false;
            zarb = false;
            minus = false;
            plus = false;
        }
    }
}