
namespace KelimeOgren
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIngilizce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTurkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKelime = new System.Windows.Forms.Label();
            this.labelCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBakilan = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGecilen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDogru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // textBoxIngilizce
            // 
            this.textBoxIngilizce.Location = new System.Drawing.Point(96, 12);
            this.textBoxIngilizce.Name = "textBoxIngilizce";
            this.textBoxIngilizce.Size = new System.Drawing.Size(134, 27);
            this.textBoxIngilizce.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Türkçe:";
            // 
            // textBoxTurkce
            // 
            this.textBoxTurkce.Location = new System.Drawing.Point(96, 45);
            this.textBoxTurkce.Name = "textBoxTurkce";
            this.textBoxTurkce.Size = new System.Drawing.Size(134, 27);
            this.textBoxTurkce.TabIndex = 1;
            this.textBoxTurkce.TextChanged += new System.EventHandler(this.textBoxTurkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Süre:";
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.Location = new System.Drawing.Point(180, 152);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(28, 20);
            this.labelSure.TabIndex = 2;
            this.labelSure.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Kelime:";
            // 
            // labelKelime
            // 
            this.labelKelime.AutoSize = true;
            this.labelKelime.Location = new System.Drawing.Point(221, 186);
            this.labelKelime.Name = "labelKelime";
            this.labelKelime.Size = new System.Drawing.Size(18, 20);
            this.labelKelime.TabIndex = 2;
            this.labelKelime.Text = "0";
            // 
            // labelCevap
            // 
            this.labelCevap.AutoSize = true;
            this.labelCevap.Location = new System.Drawing.Point(128, 120);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(83, 20);
            this.labelCevap.TabIndex = 3;
            this.labelCevap.Text = "labelCevap";
            this.labelCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cevabı Gör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bakılan Cevap:";
            // 
            // labelBakilan
            // 
            this.labelBakilan.AutoSize = true;
            this.labelBakilan.Location = new System.Drawing.Point(221, 215);
            this.labelBakilan.Name = "labelBakilan";
            this.labelBakilan.Size = new System.Drawing.Size(18, 20);
            this.labelBakilan.TabIndex = 2;
            this.labelBakilan.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sonraki Soru";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Geçilen Soru:";
            // 
            // labelGecilen
            // 
            this.labelGecilen.AutoSize = true;
            this.labelGecilen.Location = new System.Drawing.Point(221, 241);
            this.labelGecilen.Name = "labelGecilen";
            this.labelGecilen.Size = new System.Drawing.Size(18, 20);
            this.labelGecilen.TabIndex = 2;
            this.labelGecilen.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Doğru Cevap:";
            // 
            // labelDogru
            // 
            this.labelDogru.AutoSize = true;
            this.labelDogru.Location = new System.Drawing.Point(221, 271);
            this.labelDogru.Name = "labelDogru";
            this.labelDogru.Size = new System.Drawing.Size(18, 20);
            this.labelDogru.TabIndex = 2;
            this.labelDogru.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(329, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCevap);
            this.Controls.Add(this.labelDogru);
            this.Controls.Add(this.labelGecilen);
            this.Controls.Add(this.labelBakilan);
            this.Controls.Add(this.labelKelime);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIngilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIngilizce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTurkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKelime;
        private System.Windows.Forms.Label labelCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBakilan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGecilen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDogru;
    }
}

