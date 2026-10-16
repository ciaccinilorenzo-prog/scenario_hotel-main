namespace scenario_hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_parcheggio = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmb_stagione = new System.Windows.Forms.ComboBox();
            this.cmb_stanza = new System.Windows.Forms.ComboBox();
            this.lbl_stagione = new System.Windows.Forms.Label();
            this.lbl_stanza = new System.Windows.Forms.Label();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.lbl_giorni = new System.Windows.Forms.Label();
            this.txt_ngiorni = new System.Windows.Forms.TextBox();
            this.lbl_risultato = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(39, 22);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(485, 31);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "Calcola Il Prezzo Del Tuo Soggiorno";
            // 
            // lbl_parcheggio
            // 
            this.lbl_parcheggio.AutoSize = true;
            this.lbl_parcheggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parcheggio.Location = new System.Drawing.Point(112, 285);
            this.lbl_parcheggio.Name = "lbl_parcheggio";
            this.lbl_parcheggio.Size = new System.Drawing.Size(325, 16);
            this.lbl_parcheggio.TabIndex = 1;
            this.lbl_parcheggio.Text = "Si Desidera Il Servizio Di Parcheggio Privato?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(176, 327);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Si, desidero il parcheggio privato";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmb_stagione
            // 
            this.cmb_stagione.FormattingEnabled = true;
            this.cmb_stagione.Items.AddRange(new object[] {
            "Bassa Stagione",
            "Media Stagione",
            "Alta Stagione"});
            this.cmb_stagione.Location = new System.Drawing.Point(193, 110);
            this.cmb_stagione.Name = "cmb_stagione";
            this.cmb_stagione.Size = new System.Drawing.Size(162, 21);
            this.cmb_stagione.TabIndex = 3;
            this.cmb_stagione.Text = "Selezionare Qui La Stagione";
            // 
            // cmb_stanza
            // 
            this.cmb_stanza.FormattingEnabled = true;
            this.cmb_stanza.Items.AddRange(new object[] {
            "Bassa Stanza",
            "Media Stanza",
            "Alta Stanza"});
            this.cmb_stanza.Location = new System.Drawing.Point(193, 173);
            this.cmb_stanza.Name = "cmb_stanza";
            this.cmb_stanza.Size = new System.Drawing.Size(162, 21);
            this.cmb_stanza.TabIndex = 4;
            this.cmb_stanza.Text = "Selezionare Qui La Stanza";
            // 
            // lbl_stagione
            // 
            this.lbl_stagione.AutoSize = true;
            this.lbl_stagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stagione.Location = new System.Drawing.Point(88, 71);
            this.lbl_stagione.Name = "lbl_stagione";
            this.lbl_stagione.Size = new System.Drawing.Size(395, 16);
            this.lbl_stagione.TabIndex = 5;
            this.lbl_stagione.Text = "Seleziona la stagione nella quale si desidera alloggiare";
            // 
            // lbl_stanza
            // 
            this.lbl_stanza.AutoSize = true;
            this.lbl_stanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stanza.Location = new System.Drawing.Point(165, 143);
            this.lbl_stanza.Name = "lbl_stanza";
            this.lbl_stanza.Size = new System.Drawing.Size(208, 16);
            this.lbl_stanza.TabIndex = 6;
            this.lbl_stanza.Text = "Selezionare Il Tipo Di Stanza";
            // 
            // btn_calcola
            // 
            this.btn_calcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcola.Location = new System.Drawing.Point(193, 364);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(154, 43);
            this.btn_calcola.TabIndex = 7;
            this.btn_calcola.Text = "Calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // lbl_giorni
            // 
            this.lbl_giorni.AutoSize = true;
            this.lbl_giorni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giorni.Location = new System.Drawing.Point(141, 211);
            this.lbl_giorni.Name = "lbl_giorni";
            this.lbl_giorni.Size = new System.Drawing.Size(247, 16);
            this.lbl_giorni.TabIndex = 8;
            this.lbl_giorni.Text = "Quanti Giorni Desisera Alloggiare?";
            // 
            // txt_ngiorni
            // 
            this.txt_ngiorni.Location = new System.Drawing.Point(193, 241);
            this.txt_ngiorni.Name = "txt_ngiorni";
            this.txt_ngiorni.Size = new System.Drawing.Size(162, 20);
            this.txt_ngiorni.TabIndex = 9;
            this.txt_ngiorni.Text = "Scrivere Qui Il Numero Di Giorni";
            // 
            // lbl_risultato
            // 
            this.lbl_risultato.AutoSize = true;
            this.lbl_risultato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato.Location = new System.Drawing.Point(165, 442);
            this.lbl_risultato.Name = "lbl_risultato";
            this.lbl_risultato.Size = new System.Drawing.Size(2, 18);
            this.lbl_risultato.TabIndex = 10;
            // 
            // btn_info
            // 
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Location = new System.Drawing.Point(12, 24);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(36, 29);
            this.btn_info.TabIndex = 11;
            this.btn_info.Text = "?";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.label2);
            this.grb_info.Controls.Add(this.label1);
            this.grb_info.Location = new System.Drawing.Point(12, 60);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(533, 400);
            this.grb_info.TabIndex = 12;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "INFO";
            this.grb_info.Visible = false;
            this.grb_info.Enter += new System.EventHandler(this.grb_info_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 146);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "TABELLA PREZZI -->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(557, 484);
            this.Controls.Add(this.grb_info);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.lbl_risultato);
            this.Controls.Add(this.txt_ngiorni);
            this.Controls.Add(this.lbl_giorni);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.lbl_stanza);
            this.Controls.Add(this.lbl_stagione);
            this.Controls.Add(this.cmb_stanza);
            this.Controls.Add(this.cmb_stagione);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_parcheggio);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_parcheggio;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmb_stagione;
        private System.Windows.Forms.ComboBox cmb_stanza;
        private System.Windows.Forms.Label lbl_stagione;
        private System.Windows.Forms.Label lbl_stanza;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.Label lbl_giorni;
        private System.Windows.Forms.TextBox txt_ngiorni;
        private System.Windows.Forms.Label lbl_risultato;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

