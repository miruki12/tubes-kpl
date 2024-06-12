namespace tubes1
{
    partial class galang_dana
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(317, 336);
            button4.Name = "button4";
            button4.Size = new Size(167, 74);
            button4.TabIndex = 7;
            button4.Text = "kembali";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(317, 220);
            button3.Name = "button3";
            button3.Size = new Size(167, 89);
            button3.TabIndex = 6;
            button3.Text = "galang dana palestina";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 136);
            button2.Name = "button2";
            button2.Size = new Size(167, 78);
            button2.TabIndex = 5;
            button2.Text = "bencana gempa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.Location = new Point(317, 41);
            button1.Name = "button1";
            button1.Size = new Size(167, 75);
            button1.TabIndex = 4;
            button1.Text = "bencana banjir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // galang_dana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "galang_dana";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}