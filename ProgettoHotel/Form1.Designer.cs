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
            this.btn_calcolo = new System.Windows.Forms.Button();
            this.lbl_prezzo = new System.Windows.Forms.Label();
            this.btn_stanza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbox_stanza = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_stanza)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(12, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(324, 27);
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
            this.cmb_stagione.Location = new System.Drawing.Point(19, 84);
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
            this.cmb_stanza.Location = new System.Drawing.Point(19, 148);
            this.cmb_stanza.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_stanza.Name = "cmb_stanza";
            this.cmb_stanza.Size = new System.Drawing.Size(123, 21);
            this.cmb_stanza.TabIndex = 2;
            // 
            // txt_giorni
            // 
            this.txt_giorni.Location = new System.Drawing.Point(19, 212);
            this.txt_giorni.Margin = new System.Windows.Forms.Padding(2);
            this.txt_giorni.Name = "txt_giorni";
            this.txt_giorni.Size = new System.Drawing.Size(123, 20);
            this.txt_giorni.TabIndex = 3;
            this.txt_giorni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.BackColor = System.Drawing.Color.Gold;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_n2.Location = new System.Drawing.Point(15, 61);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(163, 20);
            this.lbl_n2.TabIndex = 4;
            this.lbl_n2.Text = "Inserire la stagione";
            this.lbl_n2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.BackColor = System.Drawing.Color.Gold;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(15, 117);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(196, 20);
            this.lbl_n3.TabIndex = 5;
            this.lbl_n3.Text = "Inserire il tipo di stanza";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.BackColor = System.Drawing.Color.Gold;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(15, 181);
            this.lbl_n4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(221, 20);
            this.lbl_n4.TabIndex = 6;
            this.lbl_n4.Text = "Inserire il numero di giorni:\r\n";
            // 
            // chk_parcheggio
            // 
            this.chk_parcheggio.AutoSize = true;
            this.chk_parcheggio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_parcheggio.Location = new System.Drawing.Point(19, 302);
            this.chk_parcheggio.Margin = new System.Windows.Forms.Padding(2);
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
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.Location = new System.Drawing.Point(16, 264);
            this.lbl_n5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(163, 36);
            this.lbl_n5.TabIndex = 8;
            this.lbl_n5.Text = "spuntare la casella \r\nse vuoi il parcheggio";
            // 
            // btn_calcolo
            // 
            this.btn_calcolo.BackColor = System.Drawing.Color.Wheat;
            this.btn_calcolo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_calcolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcolo.Location = new System.Drawing.Point(21, 349);
            this.btn_calcolo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_calcolo.Name = "btn_calcolo";
            this.btn_calcolo.Size = new System.Drawing.Size(92, 37);
            this.btn_calcolo.TabIndex = 10;
            this.btn_calcolo.Text = "PRENOTA";
            this.btn_calcolo.UseVisualStyleBackColor = false;
            this.btn_calcolo.Click += new System.EventHandler(this.btn_calcolo_Click);
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.AutoSize = true;
            this.lbl_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezzo.Location = new System.Drawing.Point(118, 358);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(60, 18);
            this.lbl_prezzo.TabIndex = 11;
            this.lbl_prezzo.Text = "Totale:";
            this.lbl_prezzo.Click += new System.EventHandler(this.lbl_prezzo_Click);
            // 
            // btn_stanza
            // 
            this.btn_stanza.BackColor = System.Drawing.Color.Linen;
            this.btn_stanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stanza.Location = new System.Drawing.Point(236, 264);
            this.btn_stanza.Name = "btn_stanza";
            this.btn_stanza.Size = new System.Drawing.Size(155, 23);
            this.btn_stanza.TabIndex = 12;
            this.btn_stanza.Text = "VISUALIZZA STANZA";
            this.btn_stanza.UseVisualStyleBackColor = false;
            this.btn_stanza.Click += new System.EventHandler(this.btn_stanza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ProgettoHotel.Properties.Resources.Gemini_Generated_Image_mzdct9mzdct9mzdc;
            this.pictureBox1.Location = new System.Drawing.Point(411, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pcbox_stanza
            // 
            this.pcbox_stanza.BackColor = System.Drawing.Color.Transparent;
            this.pcbox_stanza.Location = new System.Drawing.Point(411, 212);
            this.pcbox_stanza.Name = "pcbox_stanza";
            this.pcbox_stanza.Size = new System.Drawing.Size(275, 149);
            this.pcbox_stanza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbox_stanza.TabIndex = 13;
            this.pcbox_stanza.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Qua sotto prosegui con la registrazione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(734, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbox_stanza);
            this.Controls.Add(this.btn_stanza);
            this.Controls.Add(this.lbl_prezzo);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbox_stanza)).EndInit();
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
        private System.Windows.Forms.Label lbl_prezzo;
        private System.Windows.Forms.Button btn_stanza;
        private System.Windows.Forms.PictureBox pcbox_stanza;
        private System.Windows.Forms.Label label1;
    }
}

