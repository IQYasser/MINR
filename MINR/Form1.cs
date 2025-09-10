namespace MINR
{
    public partial class Form1 : Form
    {
        double forsta_talet = 0;
        string raknesatt = "";
        double andra_talet = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) => textBox1.Text += "1";
        private void button2_Click(object sender, EventArgs e) => textBox1.Text += "2";
        private void button3_Click(object sender, EventArgs e) => textBox1.Text += "3";
        private void button5_Click(object sender, EventArgs e) => textBox1.Text += "4";
        private void button6_Click(object sender, EventArgs e) => textBox1.Text += "5";
        private void button7_Click(object sender, EventArgs e) => textBox1.Text += "6";
        private void button9_Click(object sender, EventArgs e) => textBox1.Text += "7";
        private void button10_Click(object sender, EventArgs e) => textBox1.Text += "8";
        private void button11_Click(object sender, EventArgs e) => textBox1.Text += "9";
        private void button13_Click(object sender, EventArgs e) => textBox1.Text += "0";

        private void button12_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "+";
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "-";
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "*";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "/";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            andra_talet = Convert.ToDouble(textBox1.Text);
            double resultat = 0;

            if (raknesatt == "+")
                resultat = forsta_talet + andra_talet;
            else if (raknesatt == "-")
                resultat = forsta_talet - andra_talet;
            else if (raknesatt == "*")
                resultat = forsta_talet * andra_talet;
            else if (raknesatt == "/")
            {
                if (andra_talet != 0)
                    resultat = forsta_talet / andra_talet;
                else
                {
                    MessageBox.Show("Kan inte dividera med 0!");
                    return;
                }
            }

            textBox1.Text = resultat.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            forsta_talet = 0;
            andra_talet = 0;
            raknesatt = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                andra_talet = Convert.ToDouble(textBox1.Text);

                if (raknesatt == "+" || raknesatt == "-")
                {
                    andra_talet = (forsta_talet * andra_talet) / 100.0;
                    textBox1.Text = andra_talet.ToString();
                }
                else if (raknesatt == "*" || raknesatt == "/")
                {
                    andra_talet = andra_talet / 100.0;
                    textBox1.Text = andra_talet.ToString();
                }
            }
        }
    }
}
