using System;
using System.Data;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0") 
            {
                textBox.Text = "0";
                return;
            }
            
            textBox.Text += "0";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
                return;
            }

            textBox.Text += "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
                return;
            }

            textBox.Text += "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
                return;
            }

            textBox.Text += "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
                return;
            }

            textBox.Text += "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
                return;
            }

            textBox.Text += "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
                return;
            }

            textBox.Text += "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
                return;
            }

            textBox.Text += "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
                return;
            }

            textBox.Text += "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
                return;
            }

            textBox.Text += "9";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox.Text += '.';
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string removed = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                textBox.Text = removed;

                if (removed == "") 
                {
                    textBox.Text = "0";
                }
            }
            catch (Exception) {
                textBox.Text = "0";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBox.Text, null);
                textBox.Text = Convert.ToString(result);
            }
            catch (Exception) 
            {
                textBox.Text = "Invalid input";
            }
        }
    }
}
