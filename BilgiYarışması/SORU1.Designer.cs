namespace BilgiYarışması
{
    partial class SORU1
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
            this.txt_soru1 = new System.Windows.Forms.TextBox();
            this.radio_çeviri = new System.Windows.Forms.RadioButton();
            this.radio_önsöz = new System.Windows.Forms.RadioButton();
            this.radio_kaynakça = new System.Windows.Forms.RadioButton();
            this.radio_dipnot = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_soru1
            // 
            this.txt_soru1.Enabled = false;
            this.txt_soru1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soru1.Location = new System.Drawing.Point(65, 39);
            this.txt_soru1.Multiline = true;
            this.txt_soru1.Name = "txt_soru1";
            this.txt_soru1.Size = new System.Drawing.Size(798, 121);
            this.txt_soru1.TabIndex = 0;
            this.txt_soru1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radio_çeviri
            // 
            this.radio_çeviri.AutoSize = true;
            this.radio_çeviri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_çeviri.Location = new System.Drawing.Point(176, 215);
            this.radio_çeviri.Name = "radio_çeviri";
            this.radio_çeviri.Size = new System.Drawing.Size(105, 35);
            this.radio_çeviri.TabIndex = 1;
            this.radio_çeviri.TabStop = true;
            this.radio_çeviri.Text = "Çeviri";
            this.radio_çeviri.UseVisualStyleBackColor = true;
            // 
            // radio_önsöz
            // 
            this.radio_önsöz.AutoSize = true;
            this.radio_önsöz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_önsöz.Location = new System.Drawing.Point(585, 215);
            this.radio_önsöz.Name = "radio_önsöz";
            this.radio_önsöz.Size = new System.Drawing.Size(125, 35);
            this.radio_önsöz.TabIndex = 2;
            this.radio_önsöz.TabStop = true;
            this.radio_önsöz.Text = "Ön Söz";
            this.radio_önsöz.UseVisualStyleBackColor = true;
            // 
            // radio_kaynakça
            // 
            this.radio_kaynakça.AutoSize = true;
            this.radio_kaynakça.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_kaynakça.Location = new System.Drawing.Point(176, 314);
            this.radio_kaynakça.Name = "radio_kaynakça";
            this.radio_kaynakça.Size = new System.Drawing.Size(155, 35);
            this.radio_kaynakça.TabIndex = 3;
            this.radio_kaynakça.TabStop = true;
            this.radio_kaynakça.Text = "Kaynakça";
            this.radio_kaynakça.UseVisualStyleBackColor = true;
            // 
            // radio_dipnot
            // 
            this.radio_dipnot.AutoSize = true;
            this.radio_dipnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_dipnot.Location = new System.Drawing.Point(585, 314);
            this.radio_dipnot.Name = "radio_dipnot";
            this.radio_dipnot.Size = new System.Drawing.Size(126, 35);
            this.radio_dipnot.TabIndex = 4;
            this.radio_dipnot.TabStop = true;
            this.radio_dipnot.Text = "Dip Not";
            this.radio_dipnot.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(357, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "CEVAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(446, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(357, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sonraki Soru";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SORU1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(931, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_dipnot);
            this.Controls.Add(this.radio_kaynakça);
            this.Controls.Add(this.radio_önsöz);
            this.Controls.Add(this.radio_çeviri);
            this.Controls.Add(this.txt_soru1);
            this.Name = "SORU1";
            this.Text = "SORU1";
            this.Load += new System.EventHandler(this.SORU1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_soru1;
        private System.Windows.Forms.RadioButton radio_çeviri;
        private System.Windows.Forms.RadioButton radio_önsöz;
        private System.Windows.Forms.RadioButton radio_kaynakça;
        private System.Windows.Forms.RadioButton radio_dipnot;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}