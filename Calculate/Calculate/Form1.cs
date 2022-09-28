namespace Calculate
{
    public partial class Form1 : Form
    {
        double plus, min, mnoz, del, a;
        public Form1()
        {
            InitializeComponent();
            top_lable.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plus = Convert.ToDouble(top_lable.Text);
            top_lable.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (top_lable.Text.Length > 0)
                top_lable.Text = top_lable.Text.Substring(0, top_lable.Text.Length - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            min = Convert.ToDouble(top_lable.Text);
            top_lable.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            top_lable.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mnoz = Convert.ToDouble(top_lable.Text);
            top_lable.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button13.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            top_lable.Text += this.button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            del = Convert.ToDouble(top_lable.Text);
            top_lable.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(plus != 0)
            {
                a = Convert.ToDouble(top_lable.Text);
                top_lable.Text = Convert.ToString(plus + a);
            }
            if(min != 0)
            {
                a = Convert.ToDouble(top_lable.Text);
                top_lable.Text = Convert.ToString(min - a);
            }
            if (mnoz != 0)
            {
                a = Convert.ToDouble(top_lable.Text);
                top_lable.Text = Convert.ToString(mnoz * a);
            }
            if (del != 0)
            {
                a = Convert.ToDouble(top_lable.Text);
                top_lable.Text = Convert.ToString(del / a);
            }

        }
    }
}