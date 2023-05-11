namespace Uygulama2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.IPadd = new System.Windows.Forms.Button();
            this.IPremove = new System.Windows.Forms.Button();
            this.IPlistBox = new System.Windows.Forms.ListBox();
            this.IPClear = new System.Windows.Forms.Button();
            this.IPscan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtextBox1 = new System.Windows.Forms.TextBox();
            this.IpPingAt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(40, 322);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(216, 22);
            this.IPtextBox.TabIndex = 0;
            this.IPtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OneKeyDownHandler);
            // 
            // IPadd
            // 
            this.IPadd.Location = new System.Drawing.Point(40, 375);
            this.IPadd.Name = "IPadd";
            this.IPadd.Size = new System.Drawing.Size(75, 23);
            this.IPadd.TabIndex = 1;
            this.IPadd.Text = "Ekle";
            this.IPadd.UseVisualStyleBackColor = true;
            this.IPadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPremove
            // 
            this.IPremove.Location = new System.Drawing.Point(181, 375);
            this.IPremove.Name = "IPremove";
            this.IPremove.Size = new System.Drawing.Size(75, 23);
            this.IPremove.TabIndex = 2;
            this.IPremove.Text = "Sil";
            this.IPremove.UseVisualStyleBackColor = true;
            this.IPremove.Click += new System.EventHandler(this.button2_Click);
            // 
            // IPlistBox
            // 
            this.IPlistBox.FormattingEnabled = true;
            this.IPlistBox.ItemHeight = 16;
            this.IPlistBox.Location = new System.Drawing.Point(40, 12);
            this.IPlistBox.Name = "IPlistBox";
            this.IPlistBox.Size = new System.Drawing.Size(216, 276);
            this.IPlistBox.TabIndex = 3;
            // 
            // IPClear
            // 
            this.IPClear.Location = new System.Drawing.Point(40, 415);
            this.IPClear.Name = "IPClear";
            this.IPClear.Size = new System.Drawing.Size(75, 23);
            this.IPClear.TabIndex = 5;
            this.IPClear.Text = "Temizle";
            this.IPClear.UseVisualStyleBackColor = true;
            this.IPClear.Click += new System.EventHandler(this.IPClear_Click);
            // 
            // IPscan
            // 
            this.IPscan.Location = new System.Drawing.Point(181, 415);
            this.IPscan.Name = "IPscan";
            this.IPscan.Size = new System.Drawing.Size(75, 23);
            this.IPscan.TabIndex = 6;
            this.IPscan.Text = "Tara";
            this.IPscan.UseVisualStyleBackColor = true;
            this.IPscan.Click += new System.EventHandler(this.IPscan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP Adresi";
            // 
            // IPtextBox1
            // 
            this.IPtextBox1.Location = new System.Drawing.Point(338, 129);
            this.IPtextBox1.Name = "IPtextBox1";
            this.IPtextBox1.Size = new System.Drawing.Size(172, 22);
            this.IPtextBox1.TabIndex = 9;
            this.IPtextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OneKeyDownHandler1);
            // 
            // IpPingAt
            // 
            this.IpPingAt.Location = new System.Drawing.Point(341, 176);
            this.IpPingAt.Name = "IpPingAt";
            this.IpPingAt.Size = new System.Drawing.Size(169, 23);
            this.IpPingAt.TabIndex = 10;
            this.IpPingAt.Text = "Ping At";
            this.IpPingAt.UseVisualStyleBackColor = true;
            this.IpPingAt.Click += new System.EventHandler(this.IpPingAt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP Adresi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpPingAt);
            this.Controls.Add(this.IPtextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPscan);
            this.Controls.Add(this.IPClear);
            this.Controls.Add(this.IPlistBox);
            this.Controls.Add(this.IPremove);
            this.Controls.Add(this.IPadd);
            this.Controls.Add(this.IPtextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button IPadd;
        private System.Windows.Forms.Button IPremove;
        private System.Windows.Forms.ListBox IPlistBox;
        private System.Windows.Forms.Button IPClear;
        private System.Windows.Forms.Button IPscan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPtextBox1;
        private System.Windows.Forms.Button IpPingAt;
        private System.Windows.Forms.Label label2;
    }
}

