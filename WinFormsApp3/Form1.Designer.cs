namespace WinFormsApp3
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
            box1 = new ListView();
            box2 = new ListView();
            box3 = new ListView();
            box4 = new ListView();
            box5 = new ListView();
            box6 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // box1
            // 
            box1.Location = new Point(43, 108);
            box1.Name = "box1";
            box1.Size = new Size(58, 259);
            box1.TabIndex = 1;
            box1.UseCompatibleStateImageBehavior = false;
            // 
            // box2
            // 
            box2.Location = new Point(183, 108);
            box2.Name = "box2";
            box2.Size = new Size(48, 259);
            box2.TabIndex = 4;
            box2.UseCompatibleStateImageBehavior = false;
            // 
            // box3
            // 
            box3.Location = new Point(316, 108);
            box3.Name = "box3";
            box3.Size = new Size(68, 259);
            box3.TabIndex = 5;
            box3.UseCompatibleStateImageBehavior = false;
            // 
            // box4
            // 
            box4.Location = new Point(426, 108);
            box4.Name = "box4";
            box4.Size = new Size(68, 259);
            box4.TabIndex = 6;
            box4.UseCompatibleStateImageBehavior = false;
            // 
            // box5
            // 
            box5.Location = new Point(541, 108);
            box5.Name = "box5";
            box5.Size = new Size(68, 259);
            box5.TabIndex = 7;
            box5.UseCompatibleStateImageBehavior = false;
            // 
            // box6
            // 
            box6.Location = new Point(669, 108);
            box6.Name = "box6";
            box6.Size = new Size(68, 259);
            box6.TabIndex = 8;
            box6.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 75);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 10;
            label1.Text = "A halmaz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 75);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 11;
            label2.Text = "B halmaz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 75);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 12;
            label3.Text = "A unio halmaz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 75);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "A metszet B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 75);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 14;
            label5.Text = "A - B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(704, 75);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 15;
            label6.Text = "B - A";
            // 
            // button1
            // 
            button1.Location = new Point(301, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Nyomj rá!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(14, 392);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(152, 392);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(box6);
            Controls.Add(box5);
            Controls.Add(box4);
            Controls.Add(box3);
            Controls.Add(box2);
            Controls.Add(box1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView box1;
        private ListView box2;
        private ListView box3;
        private ListView box4;
        private ListView box5;
        private ListView box6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}
