namespace Pacchetti_vacanze
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
            this.pensione_checkbox = new System.Windows.Forms.CheckBox();
            this.volo_ritorno_checkbox = new System.Windows.Forms.CheckBox();
            this.destinazione_textbox = new System.Windows.Forms.TextBox();
            this.durata_textbox = new System.Windows.Forms.TextBox();
            this.prezzo_textbox = new System.Windows.Forms.TextBox();
            this.escursioni_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_base_button = new System.Windows.Forms.Button();
            this.add_volo_button1 = new System.Windows.Forms.Button();
            this.add_pastp_button = new System.Windows.Forms.Button();
            this.add_esc_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.max_min_button1 = new System.Windows.Forms.Button();
            this.media_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pensione_checkbox
            // 
            this.pensione_checkbox.AutoSize = true;
            this.pensione_checkbox.Location = new System.Drawing.Point(196, 166);
            this.pensione_checkbox.Name = "pensione_checkbox";
            this.pensione_checkbox.Size = new System.Drawing.Size(117, 17);
            this.pensione_checkbox.TabIndex = 0;
            this.pensione_checkbox.Text = "Pensione Completa";
            this.pensione_checkbox.UseVisualStyleBackColor = true;
            // 
            // volo_ritorno_checkbox
            // 
            this.volo_ritorno_checkbox.AutoSize = true;
            this.volo_ritorno_checkbox.Location = new System.Drawing.Point(345, 166);
            this.volo_ritorno_checkbox.Name = "volo_ritorno_checkbox";
            this.volo_ritorno_checkbox.Size = new System.Drawing.Size(84, 17);
            this.volo_ritorno_checkbox.TabIndex = 1;
            this.volo_ritorno_checkbox.Text = "Volo Ritorno";
            this.volo_ritorno_checkbox.UseVisualStyleBackColor = true;
            // 
            // destinazione_textbox
            // 
            this.destinazione_textbox.Location = new System.Drawing.Point(187, 75);
            this.destinazione_textbox.Name = "destinazione_textbox";
            this.destinazione_textbox.Size = new System.Drawing.Size(100, 20);
            this.destinazione_textbox.TabIndex = 2;
            // 
            // durata_textbox
            // 
            this.durata_textbox.Location = new System.Drawing.Point(315, 75);
            this.durata_textbox.Name = "durata_textbox";
            this.durata_textbox.Size = new System.Drawing.Size(100, 20);
            this.durata_textbox.TabIndex = 3;
            // 
            // prezzo_textbox
            // 
            this.prezzo_textbox.Location = new System.Drawing.Point(187, 129);
            this.prezzo_textbox.Name = "prezzo_textbox";
            this.prezzo_textbox.Size = new System.Drawing.Size(100, 20);
            this.prezzo_textbox.TabIndex = 4;
            // 
            // escursioni_textbox
            // 
            this.escursioni_textbox.Location = new System.Drawing.Point(315, 129);
            this.escursioni_textbox.Name = "escursioni_textbox";
            this.escursioni_textbox.Size = new System.Drawing.Size(100, 20);
            this.escursioni_textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destinazione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Durata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Escursioni";
            // 
            // add_base_button
            // 
            this.add_base_button.Location = new System.Drawing.Point(474, 50);
            this.add_base_button.Name = "add_base_button";
            this.add_base_button.Size = new System.Drawing.Size(88, 23);
            this.add_base_button.TabIndex = 10;
            this.add_base_button.Text = "add base";
            this.add_base_button.UseVisualStyleBackColor = true;
            this.add_base_button.Click += new System.EventHandler(this.add_base_button_Click);
            // 
            // add_volo_button1
            // 
            this.add_volo_button1.Location = new System.Drawing.Point(474, 87);
            this.add_volo_button1.Name = "add_volo_button1";
            this.add_volo_button1.Size = new System.Drawing.Size(88, 23);
            this.add_volo_button1.TabIndex = 11;
            this.add_volo_button1.Text = "add volo";
            this.add_volo_button1.UseVisualStyleBackColor = true;
            this.add_volo_button1.Click += new System.EventHandler(this.add_volo_button1_Click);
            // 
            // add_pastp_button
            // 
            this.add_pastp_button.Location = new System.Drawing.Point(474, 126);
            this.add_pastp_button.Name = "add_pastp_button";
            this.add_pastp_button.Size = new System.Drawing.Size(88, 23);
            this.add_pastp_button.TabIndex = 12;
            this.add_pastp_button.Text = "add pasto";
            this.add_pastp_button.UseVisualStyleBackColor = true;
            this.add_pastp_button.Click += new System.EventHandler(this.add_pastp_button_Click);
            // 
            // add_esc_button
            // 
            this.add_esc_button.Location = new System.Drawing.Point(474, 167);
            this.add_esc_button.Name = "add_esc_button";
            this.add_esc_button.Size = new System.Drawing.Size(88, 23);
            this.add_esc_button.TabIndex = 13;
            this.add_esc_button.Text = "add escursioni";
            this.add_esc_button.UseVisualStyleBackColor = true;
            this.add_esc_button.Click += new System.EventHandler(this.add_esc_button_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(77, 237);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 123);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Offerte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "MaxMin";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(73, 389);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(592, 49);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // max_min_button1
            // 
            this.max_min_button1.Location = new System.Drawing.Point(687, 402);
            this.max_min_button1.Name = "max_min_button1";
            this.max_min_button1.Size = new System.Drawing.Size(88, 23);
            this.max_min_button1.TabIndex = 18;
            this.max_min_button1.Text = "Max_min";
            this.max_min_button1.UseVisualStyleBackColor = true;
            this.max_min_button1.Click += new System.EventHandler(this.max_min_button1_Click);
            // 
            // media_button
            // 
            this.media_button.Location = new System.Drawing.Point(653, 108);
            this.media_button.Name = "media_button";
            this.media_button.Size = new System.Drawing.Size(88, 23);
            this.media_button.TabIndex = 19;
            this.media_button.Text = "Prezzo_medio";
            this.media_button.UseVisualStyleBackColor = true;
            this.media_button.Click += new System.EventHandler(this.media_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.media_button);
            this.Controls.Add(this.max_min_button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.add_esc_button);
            this.Controls.Add(this.add_pastp_button);
            this.Controls.Add(this.add_volo_button1);
            this.Controls.Add(this.add_base_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escursioni_textbox);
            this.Controls.Add(this.prezzo_textbox);
            this.Controls.Add(this.durata_textbox);
            this.Controls.Add(this.destinazione_textbox);
            this.Controls.Add(this.volo_ritorno_checkbox);
            this.Controls.Add(this.pensione_checkbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pensione_checkbox;
        private System.Windows.Forms.CheckBox volo_ritorno_checkbox;
        private System.Windows.Forms.TextBox destinazione_textbox;
        private System.Windows.Forms.TextBox durata_textbox;
        private System.Windows.Forms.TextBox prezzo_textbox;
        private System.Windows.Forms.TextBox escursioni_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_base_button;
        private System.Windows.Forms.Button add_volo_button1;
        private System.Windows.Forms.Button add_pastp_button;
        private System.Windows.Forms.Button add_esc_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button max_min_button1;
        private System.Windows.Forms.Button media_button;
    }
}

