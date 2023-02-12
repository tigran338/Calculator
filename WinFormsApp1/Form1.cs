namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool flag = false;
        char oper = 'a';
        double answer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)  
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 >= 0 && flag)
            {
                char s = textBox1.Text[textBox1.Text.Length - 1];
                if (s == '/' || s == '*' || s == '-' || s == '+')
                    textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag)
                return;

            flag = true;
            answer = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "/";
            oper = textBox1.Text[textBox1.Text.Length - 1];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (flag)
                return;

            flag = true;
            answer = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "*";
            oper = textBox1.Text[textBox1.Text.Length - 1];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag)
                return;

            flag = true;
            answer = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "-";
            oper = textBox1.Text[textBox1.Text.Length - 1];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag)
                return;

            flag = true;
            answer += Convert.ToDouble(textBox1.Text);
            textBox1.Text += "+";
            oper = textBox1.Text[textBox1.Text.Length - 1];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case '/': answer /= Convert.ToDouble(textBox1.Text); break;
                case '*': answer *= Convert.ToDouble(textBox1.Text); break;
                case '-': answer -= Convert.ToDouble(textBox1.Text); break;
                case '+': answer += Convert.ToDouble(textBox1.Text); break;
            }
            if (!flag)
                answer =Convert.ToDouble(Convert.ToString(textBox1.Text));
            oper = 'a';
            textBox1.Text = answer +"";
            answer = 0;
            flag = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            flag = false;
            textBox1.Text = "";
            answer = 0;
            oper = 'a';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "-";
            }
            else if (textBox1.Text.Length == 1)
            {
                if (textBox1.Text[0] == '-')
                    textBox1.Text = "";
            }
        }
    }
}