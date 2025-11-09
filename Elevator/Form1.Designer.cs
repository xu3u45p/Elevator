namespace Elevator
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
            panel1 = new Panel();
            panel9 = new Panel();
            label2 = new Label();
            panel8 = new Panel();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            panel5 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(114, 147);
            panel1.Margin = new Padding(10, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 280);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label2);
            panel9.Location = new Point(568, 147);
            panel9.Name = "panel9";
            panel9.Size = new Size(50, 50);
            panel9.TabIndex = 3;
            panel9.Paint += panel9_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 9;
            label2.Text = "7";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label1);
            panel8.Location = new Point(372, 147);
            panel8.Name = "panel8";
            panel8.Size = new Size(50, 50);
            panel8.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 8;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(372, 300);
            button1.Name = "button1";
            button1.Size = new Size(50, 42);
            button1.TabIndex = 4;
            button1.Text = "call";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(568, 300);
            button2.Name = "button2";
            button2.Size = new Size(50, 42);
            button2.TabIndex = 7;
            button2.Text = "call";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(634, 147);
            panel5.Margin = new Padding(10, 3, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 280);
            panel5.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(238, 170);
            panel7.Margin = new Padding(10, 3, 3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(96, 322);
            panel7.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(-3, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 81);
            label3.TabIndex = 9;
            label3.Text = "1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(6, 2);
            label4.Name = "label4";
            label4.Size = new Size(75, 24);
            label4.TabIndex = 10;
            label4.Text = "FLOOR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click_1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(453, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 109);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 592);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel9;
        private Panel panel8;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Panel panel7;
        private Label label3;
        private Label label4;
        private Panel panel2;
    }
}
