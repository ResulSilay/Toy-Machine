namespace ToyMachine
{
    partial class Codes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Codes));
            this.txt_source = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_example_1 = new System.Windows.Forms.Button();
            this.btn_example_2 = new System.Windows.Forms.Button();
            this.btn_example_3 = new System.Windows.Forms.Button();
            this.btn_source_content = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_example_4 = new System.Windows.Forms.Button();
            this.btn_example_5 = new System.Windows.Forms.Button();
            this.btn_example_6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_source
            // 
            this.txt_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_source.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_source.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_source.Location = new System.Drawing.Point(12, 42);
            this.txt_source.Name = "txt_source";
            this.txt_source.ReadOnly = true;
            this.txt_source.Size = new System.Drawing.Size(595, 345);
            this.txt_source.TabIndex = 3;
            this.txt_source.Text = resources.GetString("txt_source.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(23, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Komutlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Örnekler";
            // 
            // btn_example_1
            // 
            this.btn_example_1.AccessibleDescription = "dongu\n load basla\n add 1\n store basla\n add toplam\n store toplam\n load basla\n mod " +
    "100\n ifzero yazdir\n goto dongu\n\nyazdir\n load toplam\n print\n\nbasla 0\nbitis 100\nto" +
    "plam 0";
            this.btn_example_1.AccessibleName = "";
            this.btn_example_1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_example_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_example_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_example_1.Location = new System.Drawing.Point(27, 557);
            this.btn_example_1.Name = "btn_example_1";
            this.btn_example_1.Size = new System.Drawing.Size(272, 34);
            this.btn_example_1.TabIndex = 61;
            this.btn_example_1.Text = "0-100 arası sayıların toplamı.";
            this.btn_example_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_example_1.UseVisualStyleBackColor = true;
            this.btn_example_1.Click += new System.EventHandler(this.btn_example_1_Click);
            // 
            // btn_example_2
            // 
            this.btn_example_2.AccessibleDescription = "dongu\n load basla\n add toplam\n store toplam\n load basla\n sub 1\n store basla\n\n ifz" +
    "ero yazdir\n goto dongu\n\nyazdir\n load toplam\n print\n\nbasla 100\ntoplam 0";
            this.btn_example_2.AccessibleName = "";
            this.btn_example_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_example_2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_example_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_example_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_example_2.Location = new System.Drawing.Point(320, 557);
            this.btn_example_2.Name = "btn_example_2";
            this.btn_example_2.Size = new System.Drawing.Size(272, 34);
            this.btn_example_2.TabIndex = 62;
            this.btn_example_2.Text = "100 - 0 arası sayıların toplamı.";
            this.btn_example_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_example_2.UseVisualStyleBackColor = true;
            this.btn_example_2.Click += new System.EventHandler(this.btn_example_2_Click);
            // 
            // btn_example_3
            // 
            this.btn_example_3.AccessibleDescription = "basla\n get\n ifneg basla\n\ndongu\n store gecici\n mul carpim\n store carpim\n load geci" +
    "ci\n sub 1\n ifzero bitis\n goto dongu\n\nbitis\n load carpim\n print\n\ncarpim 1\ngecici " +
    "0";
            this.btn_example_3.AccessibleName = "";
            this.btn_example_3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_example_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_example_3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_example_3.Location = new System.Drawing.Point(27, 602);
            this.btn_example_3.Name = "btn_example_3";
            this.btn_example_3.Size = new System.Drawing.Size(272, 34);
            this.btn_example_3.TabIndex = 63;
            this.btn_example_3.Tag = "";
            this.btn_example_3.Text = "Girilen sayının faktöriyelini hesapla.";
            this.btn_example_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_example_3.UseVisualStyleBackColor = true;
            this.btn_example_3.Click += new System.EventHandler(this.btn_example_3_Click);
            // 
            // btn_source_content
            // 
            this.btn_source_content.AccessibleDescription = "dongu\n load basla\n add 1\n store basla\n add toplam\n store toplam\n load basla\n mod " +
    "100\n ifzero yazdir\n goto dongu\n\nyazdir\n load toplam\n print\n\nbasla 0\nbitis 100\nto" +
    "plam 0";
            this.btn_source_content.AccessibleName = "";
            this.btn_source_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_source_content.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btn_source_content.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_source_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_source_content.ForeColor = System.Drawing.Color.Turquoise;
            this.btn_source_content.Location = new System.Drawing.Point(27, 427);
            this.btn_source_content.Name = "btn_source_content";
            this.btn_source_content.Size = new System.Drawing.Size(565, 80);
            this.btn_source_content.TabIndex = 64;
            this.btn_source_content.Text = resources.GetString("btn_source_content.Text");
            this.btn_source_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_source_content.UseVisualStyleBackColor = true;
            this.btn_source_content.Click += new System.EventHandler(this.btn_source_content_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(23, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Kaynak";
            // 
            // btn_example_4
            // 
            this.btn_example_4.AccessibleDescription = " load sayi1\n oct sayi1\n store sayi1\n print\n\n load sayi2\n bin sayi2\n store sayi2\n " +
    "print\n\nsayi1 15\nsayi2 26\n";
            this.btn_example_4.AccessibleName = "";
            this.btn_example_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_example_4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_example_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_example_4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_example_4.Location = new System.Drawing.Point(320, 602);
            this.btn_example_4.Name = "btn_example_4";
            this.btn_example_4.Size = new System.Drawing.Size(272, 34);
            this.btn_example_4.TabIndex = 66;
            this.btn_example_4.Tag = "";
            this.btn_example_4.Text = "Octal ve binary hesaplama.";
            this.btn_example_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_example_4.UseVisualStyleBackColor = true;
            this.btn_example_4.Click += new System.EventHandler(this.btn_example_4_Click);
            // 
            // btn_example_5
            // 
            this.btn_example_5.AccessibleDescription = " load sayi1\n and  5\n store sayi1\n print\n\n load sayi2\n or 3\n store sayi2\n print\n\ns" +
    "ayi1 4\nsayi2 8";
            this.btn_example_5.AccessibleName = "";
            this.btn_example_5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_example_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_example_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_example_5.Location = new System.Drawing.Point(27, 647);
            this.btn_example_5.Name = "btn_example_5";
            this.btn_example_5.Size = new System.Drawing.Size(272, 34);
            this.btn_example_5.TabIndex = 67;
            this.btn_example_5.Tag = "";
            this.btn_example_5.Text = " And ve Or komutları kullanımı.";
            this.btn_example_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_example_5.UseVisualStyleBackColor = true;
            this.btn_example_5.Click += new System.EventHandler(this.btn_example_5_Click);
            // 
            // btn_example_6
            // 
            this.btn_example_6.AccessibleDescription = "";
            this.btn_example_6.AccessibleName = "";
            this.btn_example_6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_example_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_example_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_example_6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_example_6.Location = new System.Drawing.Point(320, 647);
            this.btn_example_6.Name = "btn_example_6";
            this.btn_example_6.Size = new System.Drawing.Size(272, 34);
            this.btn_example_6.TabIndex = 68;
            this.btn_example_6.Tag = "";
            this.btn_example_6.Text = "Bu örneği size bırakıyoruz. :)";
            this.btn_example_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_example_6.UseVisualStyleBackColor = true;
            this.btn_example_6.Click += new System.EventHandler(this.btn_example_6_Click);
            // 
            // Codes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(619, 699);
            this.Controls.Add(this.btn_example_6);
            this.Controls.Add(this.btn_example_5);
            this.Controls.Add(this.btn_example_4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_source_content);
            this.Controls.Add(this.btn_example_3);
            this.Controls.Add(this.btn_example_2);
            this.Controls.Add(this.btn_example_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Codes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codes";
            this.Load += new System.EventHandler(this.Codes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txt_source;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_example_1;
        private System.Windows.Forms.Button btn_example_2;
        private System.Windows.Forms.Button btn_source_content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_example_4;
        private System.Windows.Forms.Button btn_example_5;
        private System.Windows.Forms.Button btn_example_3;
        private System.Windows.Forms.Button btn_example_6;
    }
}