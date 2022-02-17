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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(96, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(80, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Calculator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
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
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 277);
            this.panel1.TabIndex = 3;
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_equal.Location = new System.Drawing.Point(186, 217);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(80, 57);
            this.btn_equal.TabIndex = 20;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zero.FlatAppearance.BorderSize = 0;
            this.btn_zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.Color.White;
            this.btn_zero.Location = new System.Drawing.Point(54, 218);
            this.btn_zero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(134, 57);
            this.btn_zero.TabIndex = 19;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dot.FlatAppearance.BorderSize = 0;
            this.btn_dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.ForeColor = System.Drawing.Color.White;
            this.btn_dot.Location = new System.Drawing.Point(-1, 218);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(56, 57);
            this.btn_dot.TabIndex = 17;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_minus.Location = new System.Drawing.Point(186, 163);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(80, 57);
            this.btn_minus.TabIndex = 16;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nine.FlatAppearance.BorderSize = 0;
            this.btn_nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nine.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.ForeColor = System.Drawing.Color.White;
            this.btn_nine.Location = new System.Drawing.Point(123, 164);
            this.btn_nine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(64, 57);
            this.btn_nine.TabIndex = 15;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = false;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eight.FlatAppearance.BorderSize = 0;
            this.btn_eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eight.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.ForeColor = System.Drawing.Color.White;
            this.btn_eight.Location = new System.Drawing.Point(63, 164);
            this.btn_eight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(60, 57);
            this.btn_eight.TabIndex = 14;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = false;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_seven.FlatAppearance.BorderSize = 0;
            this.btn_seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seven.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.ForeColor = System.Drawing.Color.White;
            this.btn_seven.Location = new System.Drawing.Point(-1, 164);
            this.btn_seven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(64, 57);
            this.btn_seven.TabIndex = 13;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = false;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_plus.Location = new System.Drawing.Point(186, 109);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(80, 57);
            this.btn_plus.TabIndex = 12;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_six
            // 
            this.btn_six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_six.FlatAppearance.BorderSize = 0;
            this.btn_six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_six.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.ForeColor = System.Drawing.Color.White;
            this.btn_six.Location = new System.Drawing.Point(123, 110);
            this.btn_six.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(64, 57);
            this.btn_six.TabIndex = 11;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = false;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_five.FlatAppearance.BorderSize = 0;
            this.btn_five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_five.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.ForeColor = System.Drawing.Color.White;
            this.btn_five.Location = new System.Drawing.Point(63, 110);
            this.btn_five.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(60, 57);
            this.btn_five.TabIndex = 10;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_four
            // 
            this.btn_four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_four.FlatAppearance.BorderSize = 0;
            this.btn_four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_four.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.ForeColor = System.Drawing.Color.White;
            this.btn_four.Location = new System.Drawing.Point(-1, 110);
            this.btn_four.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(64, 57);
            this.btn_four.TabIndex = 9;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = false;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mult.FlatAppearance.BorderSize = 0;
            this.btn_mult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_mult.Location = new System.Drawing.Point(186, 53);
            this.btn_mult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(80, 57);
            this.btn_mult.TabIndex = 8;
            this.btn_mult.Text = "X";
            this.btn_mult.UseVisualStyleBackColor = false;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_three
            // 
            this.btn_three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_three.FlatAppearance.BorderSize = 0;
            this.btn_three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_three.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.ForeColor = System.Drawing.Color.White;
            this.btn_three.Location = new System.Drawing.Point(123, 54);
            this.btn_three.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(64, 57);
            this.btn_three.TabIndex = 7;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = false;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_two
            // 
            this.btn_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_two.FlatAppearance.BorderSize = 0;
            this.btn_two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_two.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.ForeColor = System.Drawing.Color.White;
            this.btn_two.Location = new System.Drawing.Point(63, 54);
            this.btn_two.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(60, 57);
            this.btn_two.TabIndex = 6;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = false;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one.FlatAppearance.BorderSize = 0;
            this.btn_one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.ForeColor = System.Drawing.Color.White;
            this.btn_one.Location = new System.Drawing.Point(-1, 54);
            this.btn_one.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(64, 57);
            this.btn_one.TabIndex = 5;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_div.FlatAppearance.BorderSize = 0;
            this.btn_div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_div.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_div.Location = new System.Drawing.Point(186, -2);
            this.btn_div.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(80, 57);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(106)))), ((int)(((byte)(43)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(54, -1);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(134, 57);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "DEL";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_c.FlatAppearance.BorderSize = 0;
            this.btn_c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(158)))), ((int)(((byte)(250)))));
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(106)))), ((int)(((byte)(43)))));
            this.btn_c.Location = new System.Drawing.Point(-1, -1);
            this.btn_c.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(56, 57);
            this.btn_c.TabIndex = 0;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(11, 91);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(244, 32);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(131)))), ((int)(((byte)(198)))));
            this.panel2.Location = new System.Drawing.Point(-1, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 2);
            this.panel2.TabIndex = 5;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(266, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BS Calculator";
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
        private System.Windows.Forms.Panel panel2;
    }
}

