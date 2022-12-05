namespace DilKursuYonetim
{
    partial class kayitt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.ResimYukleBtn = new System.Windows.Forms.Button();
            this.OgrenciPb = new System.Windows.Forms.PictureBox();
            this.OgrenciCinsiyetCb = new System.Windows.Forms.ComboBox();
            this.OgrenciDogumTimeB = new System.Windows.Forms.DateTimePicker();
            this.OgrenciTelefonTb = new System.Windows.Forms.TextBox();
            this.OgrenciAdresTb = new System.Windows.Forms.TextBox();
            this.OgrenciAdTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OgrenciDgv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.OgrenciResimTb = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.GeriBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 48);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackColor = System.Drawing.Color.Red;
            this.GeriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.GeriBtn.Location = new System.Drawing.Point(0, 9);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(34, 32);
            this.GeriBtn.TabIndex = 10;
            this.GeriBtn.Text = "<";
            this.GeriBtn.UseVisualStyleBackColor = false;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(789, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(316, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğrenci Kayıt";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Coral;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResetBtn.Location = new System.Drawing.Point(529, 441);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(153, 31);
            this.ResetBtn.TabIndex = 20;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.Crimson;
            this.EkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EkleBtn.Location = new System.Drawing.Point(688, 442);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(153, 31);
            this.EkleBtn.TabIndex = 21;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // ResimYukleBtn
            // 
            this.ResimYukleBtn.BackColor = System.Drawing.Color.Lime;
            this.ResimYukleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResimYukleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResimYukleBtn.Location = new System.Drawing.Point(628, 333);
            this.ResimYukleBtn.Name = "ResimYukleBtn";
            this.ResimYukleBtn.Size = new System.Drawing.Size(54, 39);
            this.ResimYukleBtn.TabIndex = 22;
            this.ResimYukleBtn.Text = "...";
            this.ResimYukleBtn.UseVisualStyleBackColor = false;
            this.ResimYukleBtn.Click += new System.EventHandler(this.ResimYukleBtn_Click);
            // 
            // OgrenciPb
            // 
            this.OgrenciPb.Location = new System.Drawing.Point(688, 259);
            this.OgrenciPb.Name = "OgrenciPb";
            this.OgrenciPb.Size = new System.Drawing.Size(153, 140);
            this.OgrenciPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OgrenciPb.TabIndex = 19;
            this.OgrenciPb.TabStop = false;
            this.OgrenciPb.Click += new System.EventHandler(this.OgrenciPb_Click);
            // 
            // OgrenciCinsiyetCb
            // 
            this.OgrenciCinsiyetCb.FormattingEnabled = true;
            this.OgrenciCinsiyetCb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.OgrenciCinsiyetCb.Location = new System.Drawing.Point(463, 306);
            this.OgrenciCinsiyetCb.Name = "OgrenciCinsiyetCb";
            this.OgrenciCinsiyetCb.Size = new System.Drawing.Size(157, 21);
            this.OgrenciCinsiyetCb.TabIndex = 18;
            // 
            // OgrenciDogumTimeB
            // 
            this.OgrenciDogumTimeB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OgrenciDogumTimeB.Location = new System.Drawing.Point(166, 304);
            this.OgrenciDogumTimeB.Name = "OgrenciDogumTimeB";
            this.OgrenciDogumTimeB.Size = new System.Drawing.Size(157, 20);
            this.OgrenciDogumTimeB.TabIndex = 17;
            // 
            // OgrenciTelefonTb
            // 
            this.OgrenciTelefonTb.Location = new System.Drawing.Point(463, 259);
            this.OgrenciTelefonTb.Name = "OgrenciTelefonTb";
            this.OgrenciTelefonTb.Size = new System.Drawing.Size(157, 20);
            this.OgrenciTelefonTb.TabIndex = 14;
            // 
            // OgrenciAdresTb
            // 
            this.OgrenciAdresTb.Location = new System.Drawing.Point(166, 352);
            this.OgrenciAdresTb.Multiline = true;
            this.OgrenciAdresTb.Name = "OgrenciAdresTb";
            this.OgrenciAdresTb.Size = new System.Drawing.Size(157, 84);
            this.OgrenciAdresTb.TabIndex = 15;
            // 
            // OgrenciAdTb
            // 
            this.OgrenciAdTb.Location = new System.Drawing.Point(166, 259);
            this.OgrenciAdTb.Name = "OgrenciAdTb";
            this.OgrenciAdTb.Size = new System.Drawing.Size(157, 20);
            this.OgrenciAdTb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(393, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(103, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(393, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "AdSoyad:";
            // 
            // OgrenciDgv
            // 
            this.OgrenciDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OgrenciDgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OgrenciDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OgrenciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OgrenciDgv.Location = new System.Drawing.Point(1, 44);
            this.OgrenciDgv.Name = "OgrenciDgv";
            this.OgrenciDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.OgrenciDgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.OgrenciDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OgrenciDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OgrenciDgv.Size = new System.Drawing.Size(852, 186);
            this.OgrenciDgv.TabIndex = 8;
            this.OgrenciDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OgrenciDgv_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(399, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resim:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // OgrenciResimTb
            // 
            this.OgrenciResimTb.Location = new System.Drawing.Point(463, 349);
            this.OgrenciResimTb.Name = "OgrenciResimTb";
            this.OgrenciResimTb.Size = new System.Drawing.Size(157, 20);
            this.OgrenciResimTb.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kayitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.ResimYukleBtn);
            this.Controls.Add(this.OgrenciPb);
            this.Controls.Add(this.OgrenciCinsiyetCb);
            this.Controls.Add(this.OgrenciDogumTimeB);
            this.Controls.Add(this.OgrenciResimTb);
            this.Controls.Add(this.OgrenciTelefonTb);
            this.Controls.Add(this.OgrenciAdresTb);
            this.Controls.Add(this.OgrenciAdTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayitt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciYonetim";
            this.Load += new System.EventHandler(this.kayitt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button ResimYukleBtn;
        private System.Windows.Forms.PictureBox OgrenciPb;
        private System.Windows.Forms.ComboBox OgrenciCinsiyetCb;
        private System.Windows.Forms.DateTimePicker OgrenciDogumTimeB;
        private System.Windows.Forms.TextBox OgrenciTelefonTb;
        private System.Windows.Forms.TextBox OgrenciAdresTb;
        private System.Windows.Forms.TextBox OgrenciAdTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OgrenciDgv;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OgrenciResimTb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}