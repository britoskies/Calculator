namespace calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(98, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(91, 22);
            this.title.TabIndex = 0;
            this.title.Text = "Calculator";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_equal);
            this.panel1.Controls.Add(this.btn_zero);
            this.panel1.Controls.Add(this.btn_dot);
            this.panel1.Controls.Add(this.btn_minus);
            this.panel1.Controls.Add(this.btn_nine);
            this.panel1.Controls.Add(this.btn_eight);
            this.panel1.Controls.Add(this.btn_seven);
            this.panel1.Controls.Add(this.btn_plus);
            this.panel1.Controls.Add(this.btn_six);
            this.panel1.Controls.Add(this.btn_five);
            this.panel1.Controls.Add(this.btn_four);
            this.panel1.Controls.Add(this.btn_mult);
            this.panel1.Controls.Add(this.btn_three);
            this.panel1.Controls.Add(this.btn_two);
            this.panel1.Controls.Add(this.btn_one);
            this.panel1.Controls.Add(this.btn_div);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.btn_c);
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 416);
            this.panel1.TabIndex = 3;
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(-1, -1);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(75, 70);
            this.btn_c.TabIndex = 0;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(72, -1);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(148, 70);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "DEL";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(217, -1);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 70);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(217, 67);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 70);
            this.btn_mult.TabIndex = 8;
            this.btn_mult.Text = "X";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(145, 67);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(75, 70);
            this.btn_three.TabIndex = 7;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(72, 67);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 70);
            this.btn_two.TabIndex = 6;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(-1, 67);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(75, 70);
            this.btn_one.TabIndex = 5;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(217, 135);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 70);
            this.btn_plus.TabIndex = 12;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_six
            // 
            this.btn_six.Location = new System.Drawing.Point(145, 135);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(75, 70);
            this.btn_six.TabIndex = 11;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_five
            // 
            this.btn_five.Location = new System.Drawing.Point(72, 135);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(75, 70);
            this.btn_five.TabIndex = 10;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(-1, 135);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(75, 70);
            this.btn_four.TabIndex = 9;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(217, 202);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 70);
            this.btn_minus.TabIndex = 16;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(145, 202);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(75, 70);
            this.btn_nine.TabIndex = 15;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Location = new System.Drawing.Point(72, 202);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(75, 70);
            this.btn_eight.TabIndex = 14;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Location = new System.Drawing.Point(-1, 202);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(75, 70);
            this.btn_seven.TabIndex = 13;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(217, 268);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 70);
            this.btn_equal.TabIndex = 20;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(72, 268);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(148, 70);
            this.btn_zero.TabIndex = 19;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(-1, 268);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(75, 70);
            this.btn_dot.TabIndex = 17;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 112);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(273, 27);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.WordWrap = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 517);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.TextBox textBox;
    }
}

