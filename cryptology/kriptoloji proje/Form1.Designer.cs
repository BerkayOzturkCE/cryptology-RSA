namespace kriptoloji_proje
{
    partial class form
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
            this.metin1 = new System.Windows.Forms.RichTextBox();
            this.metin2 = new System.Windows.Forms.RichTextBox();
            this.BtnSfrle = new System.Windows.Forms.Button();
            this.BtnCoz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metin1
            // 
            this.metin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metin1.Location = new System.Drawing.Point(12, 113);
            this.metin1.Name = "metin1";
            this.metin1.Size = new System.Drawing.Size(435, 390);
            this.metin1.TabIndex = 0;
            this.metin1.Text = "";
            // 
            // metin2
            // 
            this.metin2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metin2.Location = new System.Drawing.Point(599, 113);
            this.metin2.Name = "metin2";
            this.metin2.ReadOnly = true;
            this.metin2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.metin2.Size = new System.Drawing.Size(435, 390);
            this.metin2.TabIndex = 1;
            this.metin2.Text = "";
            // 
            // BtnSfrle
            // 
            this.BtnSfrle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSfrle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSfrle.Location = new System.Drawing.Point(466, 113);
            this.BtnSfrle.Name = "BtnSfrle";
            this.BtnSfrle.Size = new System.Drawing.Size(116, 50);
            this.BtnSfrle.TabIndex = 2;
            this.BtnSfrle.Text = "Encrypt";
            this.BtnSfrle.UseVisualStyleBackColor = true;
            this.BtnSfrle.Click += new System.EventHandler(this.BtnSfrle_Click);
            // 
            // BtnCoz
            // 
            this.BtnCoz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCoz.Location = new System.Drawing.Point(466, 203);
            this.BtnCoz.Name = "BtnCoz";
            this.BtnCoz.Size = new System.Drawing.Size(116, 50);
            this.BtnCoz.TabIndex = 3;
            this.BtnCoz.Text = "Decrypt";
            this.BtnCoz.UseVisualStyleBackColor = true;
            this.BtnCoz.Click += new System.EventHandler(this.BtnCoz_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(135, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(734, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1043, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCoz);
            this.Controls.Add(this.BtnSfrle);
            this.Controls.Add(this.metin2);
            this.Controls.Add(this.metin1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox metin1;
        private System.Windows.Forms.Button BtnSfrle;
        private System.Windows.Forms.Button BtnCoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox metin2;
    }
}

