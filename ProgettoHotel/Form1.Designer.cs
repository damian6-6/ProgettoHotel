namespace ProgettoHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.cmb_stagione = new System.Windows.Forms.ComboBox();
            this.cmb_stanza = new System.Windows.Forms.ComboBox();
            this.txt_giorni = new System.Windows.Forms.TextBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.chk_parcheggio = new System.Windows.Forms.CheckBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_calcolo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(237, 7);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(280, 27);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "BENVENUTO/A DA DAME\'S HOTEL";
            this.lbl_n1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_stagione
            // 
            this.cmb_stagione.FormattingEnabled = true;
            this.cmb_stagione.Items.AddRange(new object[] {
            "Bassa stagione",
            "Media stagione",
            "Alta stagione"});
            this.cmb_stagione.Location = new System.Drawing.Point(25, 84);
            this.cmb_stagione.Name = "cmb_stagione";
            this.cmb_stagione.Size = new System.Drawing.Size(123, 21);
            this.cmb_stagione.TabIndex = 1;
            this.cmb_stagione.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_stanza
            // 
            this.cmb_stanza.FormattingEnabled = true;
            this.cmb_stanza.Items.AddRange(new object[] {
            "Base",
            "Media",
            "Alta"});
            this.cmb_stanza.Location = new System.Drawing.Point(194, 84);
            this.cmb_stanza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_stanza.Name = "cmb_stanza";
            this.cmb_stanza.Size = new System.Drawing.Size(92, 21);
            this.cmb_stanza.TabIndex = 2;
            // 
            // txt_giorni
            // 
            this.txt_giorni.Location = new System.Drawing.Point(25, 148);
            this.txt_giorni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_giorni.Name = "txt_giorni";
            this.txt_giorni.Size = new System.Drawing.Size(87, 20);
            this.txt_giorni.TabIndex = 3;
            this.txt_giorni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.BackColor = System.Drawing.Color.Gold;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_n2.Location = new System.Drawing.Point(22, 65);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(131, 15);
            this.lbl_n2.TabIndex = 4;
            this.lbl_n2.Text = "Inserire la stagione";
            this.lbl_n2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.BackColor = System.Drawing.Color.Gold;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(191, 64);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(158, 15);
            this.lbl_n3.TabIndex = 5;
            this.lbl_n3.Text = "Inserire il tipo di stanza";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.BackColor = System.Drawing.Color.Gold;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(22, 130);
            this.lbl_n4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(178, 15);
            this.lbl_n4.TabIndex = 6;
            this.lbl_n4.Text = "Inserire il numero di giorni";
            // 
            // chk_parcheggio
            // 
            this.chk_parcheggio.AutoSize = true;
            this.chk_parcheggio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_parcheggio.Location = new System.Drawing.Point(25, 222);
            this.chk_parcheggio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_parcheggio.Name = "chk_parcheggio";
            this.chk_parcheggio.Size = new System.Drawing.Size(94, 21);
            this.chk_parcheggio.TabIndex = 7;
            this.chk_parcheggio.Text = "parcheggio";
            this.chk_parcheggio.UseVisualStyleBackColor = true;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.BackColor = System.Drawing.Color.Gold;
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.Location = new System.Drawing.Point(22, 190);
            this.lbl_n5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(140, 30);
            this.lbl_n5.TabIndex = 8;
            this.lbl_n5.Text = "spuntare la casella \r\nse vuoi il parcheggio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ProgettoHotel.Properties.Resources.Gemini_Generated_Image_mzdct9mzdct9mzdc;
            this.pictureBox1.Location = new System.Drawing.Point(316, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_calcolo
            // 
            this.btn_calcolo.BackColor = System.Drawing.Color.Wheat;
            this.btn_calcolo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_calcolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcolo.Location = new System.Drawing.Point(25, 262);
            this.btn_calcolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_calcolo.Name = "btn_calcolo";
            this.btn_calcolo.Size = new System.Drawing.Size(86, 32);
            this.btn_calcolo.TabIndex = 10;
            this.btn_calcolo.Text = "PRENOTA";
            this.btn_calcolo.UseVisualStyleBackColor = false;
            this.btn_calcolo.Click += new System.EventHandler(this.btn_calcolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(734, 397);
            this.Controls.Add(this.btn_calcolo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.chk_parcheggio);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.txt_giorni);
            this.Controls.Add(this.cmb_stanza);
            this.Controls.Add(this.cmb_stagione);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.ComboBox cmb_stagione;
        private System.Windows.Forms.ComboBox cmb_stanza;
        private System.Windows.Forms.TextBox txt_giorni;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.CheckBox chk_parcheggio;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_calcolo;
    }
}

