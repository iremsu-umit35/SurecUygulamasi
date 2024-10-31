namespace SurecUygulamasi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            label1 = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            progressBar2 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            label5 = new Label();
            progressBar5 = new ProgressBar();
            Timer2 = new System.Windows.Forms.Timer(components);
            Timer3 = new System.Windows.Forms.Timer(components);
            Timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-3, 83);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(942, 46);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 56);
            label1.Name = "label1";
            label1.Size = new Size(246, 24);
            label1.TabIndex = 1;
            label1.Text = "Un ve yumurta karıştılıyor...";
            label1.Click += label1_Click;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            Timer1.Tick += timer1_Tick;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(-3, 83);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(942, 46);
            progressBar2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Name = "label2";
            label2.Size = new Size(246, 24);
            label2.TabIndex = 1;
            label2.Text = "Un ve yumurta karıştılıyor...";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 138);
            label3.Name = "label3";
            label3.Size = new Size(218, 24);
            label3.TabIndex = 3;
            label3.Text = "Çırpma işlemi yapılıyor...";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(-3, 165);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(942, 46);
            progressBar3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 231);
            label4.Name = "label4";
            label4.Size = new Size(321, 24);
            label4.TabIndex = 5;
            label4.Text = "Mazemeler ekleniyor ve karıştılıyor...";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(-3, 258);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(942, 46);
            progressBar4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 326);
            label5.Name = "label5";
            label5.Size = new Size(157, 24);
            label5.TabIndex = 7;
            label5.Text = "Pasta pişiriliyor...";
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(-3, 353);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(942, 46);
            progressBar5.TabIndex = 6;
            // 
            // Timer2
            // 
            Timer2.Interval = 1000;
            Timer2.Tick += Timer2_Tick;
            // 
            // Timer3
            // 
            Timer3.Interval = 1000;
            Timer3.Tick += Timer3_Tick;
            // 
            // Timer4
            // 
            Timer4.Interval = 1000;
            Timer4.Tick += Timer4_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(943, 442);
            Controls.Add(label5);
            Controls.Add(progressBar5);
            Controls.Add(label4);
            Controls.Add(progressBar4);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(label2);
            Controls.Add(progressBar2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Corbel", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer Timer1;
        private ProgressBar progressBar2;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private Label label5;
        private ProgressBar progressBar5;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.Timer Timer4;
    }
}
