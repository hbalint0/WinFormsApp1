﻿namespace WinFormsApp1
{
    partial class MainForm
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
            kattint = new Button();
            SuspendLayout();
            // 
            // kattint
            // 
            kattint.Location = new Point(261, 160);
            kattint.Name = "kattint";
            kattint.Size = new Size(174, 58);
            kattint.TabIndex = 0;
            kattint.Text = "Kattints rám!";
            kattint.UseVisualStyleBackColor = true;
            kattint.Click += kattint_Click;
            kattint.MouseLeave += kattint_MouseLeave;
            kattint.MouseHover += kattint_MouseHover;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kattint);
            Name = "MainForm";
            Text = "Teszt";
            ResumeLayout(false);
        }

        #endregion

        private Button kattint;
    }
}
