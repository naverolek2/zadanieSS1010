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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ip2 = new System.Windows.Forms.NumericUpDown();
            this.ip4 = new System.Windows.Forms.NumericUpDown();
            this.ip3 = new System.Windows.Forms.NumericUpDown();
            this.ip1 = new System.Windows.Forms.NumericUpDown();
            this.czyPoprawny = new System.Windows.Forms.Label();
            this.klasaIP = new System.Windows.Forms.Label();
            this.typAdresu = new System.Windows.Forms.Label();
            this.maska1 = new System.Windows.Forms.NumericUpDown();
            this.test123 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maska1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(123, 104);
            this.ip2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(44, 23);
            this.ip2.TabIndex = 14;
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(228, 104);
            this.ip4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(47, 23);
            this.ip4.TabIndex = 15;
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(173, 104);
            this.ip3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(49, 23);
            this.ip3.TabIndex = 16;
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(67, 104);
            this.ip1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(50, 23);
            this.ip1.TabIndex = 13;
            this.ip1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // czyPoprawny
            // 
            this.czyPoprawny.AutoSize = true;
            this.czyPoprawny.Location = new System.Drawing.Point(67, 141);
            this.czyPoprawny.Name = "czyPoprawny";
            this.czyPoprawny.Size = new System.Drawing.Size(141, 15);
            this.czyPoprawny.TabIndex = 17;
            this.czyPoprawny.Text = "adres ip jest niepoprawny";
            this.czyPoprawny.Visible = false;
            this.czyPoprawny.Click += new System.EventHandler(this.czyPoprawny_Click);
            // 
            // klasaIP
            // 
            this.klasaIP.AutoSize = true;
            this.klasaIP.Location = new System.Drawing.Point(67, 166);
            this.klasaIP.Name = "klasaIP";
            this.klasaIP.Size = new System.Drawing.Size(109, 15);
            this.klasaIP.TabIndex = 22;
            this.klasaIP.Text = "adres ip jest klasy A";
            this.klasaIP.Visible = false;
            // 
            // typAdresu
            // 
            this.typAdresu.AutoSize = true;
            this.typAdresu.Location = new System.Drawing.Point(67, 192);
            this.typAdresu.Name = "typAdresu";
            this.typAdresu.Size = new System.Drawing.Size(242, 15);
            this.typAdresu.TabIndex = 23;
            this.typAdresu.Text = "Podany adres jest adresem rozgłoszeniowym";
            this.typAdresu.Visible = false;
            // 
            // maska1
            // 
            this.maska1.Location = new System.Drawing.Point(300, 104);
            this.maska1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maska1.Name = "maska1";
            this.maska1.Size = new System.Drawing.Size(75, 23);
            this.maska1.TabIndex = 18;
            // 
            // test123
            // 
            this.test123.AutoSize = true;
            this.test123.Location = new System.Drawing.Point(198, 304);
            this.test123.Name = "test123";
            this.test123.Size = new System.Drawing.Size(38, 15);
            this.test123.TabIndex = 24;
            this.test123.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test123);
            this.Controls.Add(this.typAdresu);
            this.Controls.Add(this.klasaIP);
            this.Controls.Add(this.maska1);
            this.Controls.Add(this.czyPoprawny);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maska1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private NumericUpDown ip2;
        private NumericUpDown ip4;
        private NumericUpDown ip3;
        private NumericUpDown ip1;
        private Label czyPoprawny;
        private Label klasaIP;
        private Label typAdresu;
        private NumericUpDown maska1;
        private Label test123;
    }
}