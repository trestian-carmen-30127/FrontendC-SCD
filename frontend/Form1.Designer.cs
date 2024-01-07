namespace frontend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Employees";
            // 
            // button1
            // 
            button1.Location = new Point(33, 191);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 2;
            button1.Text = "Load Employees";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(33, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 144);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(33, 226);
            button2.Name = "button2";
            button2.Size = new Size(244, 30);
            button2.TabIndex = 4;
            button2.Text = "Load Employees by Department";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 57);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 6;
            label2.Text = "Insert department ID";
            // 
            // button3
            // 
            button3.Location = new Point(391, 308);
            button3.Name = "button3";
            button3.Size = new Size(155, 29);
            button3.TabIndex = 7;
            button3.Text = "Delete department";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(391, 217);
            button4.Name = "button4";
            button4.Size = new Size(155, 29);
            button4.TabIndex = 8;
            button4.Text = "Create department";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(391, 264);
            button5.Name = "button5";
            button5.Size = new Size(155, 29);
            button5.TabIndex = 9;
            button5.Text = "Update department";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(421, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 111);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 12;
            label3.Text = "Insert description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 162);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 13;
            label4.Text = "Insert parent id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
    }
}