namespace miniProjet
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridPaiement = new System.Windows.Forms.DataGridView();
            this.retour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.salaire = new System.Windows.Forms.TextBox();
            this.mois = new System.Windows.Forms.ComboBox();
            this.dataGridProf = new System.Windows.Forms.DataGridView();
            this.prof = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPaiement
            // 
            this.dataGridPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPaiement.Location = new System.Drawing.Point(22, 232);
            this.dataGridPaiement.Name = "dataGridPaiement";
            this.dataGridPaiement.Size = new System.Drawing.Size(288, 123);
            this.dataGridPaiement.TabIndex = 17;
            this.dataGridPaiement.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPaiement_RowHeaderMouseClick);
            // 
            // retour
            // 
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Image = ((System.Drawing.Image)(resources.GetObject("retour.Image")));
            this.retour.Location = new System.Drawing.Point(22, 19);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 41);
            this.retour.TabIndex = 28;
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Paiement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(323, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Salaire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(323, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mois :";
            // 
            // ajouter
            // 
            this.ajouter.FlatAppearance.BorderSize = 3;
            this.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.ajouter.Image = ((System.Drawing.Image)(resources.GetObject("ajouter.Image")));
            this.ajouter.Location = new System.Drawing.Point(326, 263);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(70, 61);
            this.ajouter.TabIndex = 38;
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.FlatAppearance.BorderSize = 3;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.modifier.Image = ((System.Drawing.Image)(resources.GetObject("modifier.Image")));
            this.modifier.Location = new System.Drawing.Point(418, 263);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(70, 61);
            this.modifier.TabIndex = 39;
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.FlatAppearance.BorderSize = 3;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.supprimer.Image = ((System.Drawing.Image)(resources.GetObject("supprimer.Image")));
            this.supprimer.Location = new System.Drawing.Point(509, 263);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(70, 61);
            this.supprimer.TabIndex = 40;
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(443, 166);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(136, 20);
            this.salaire.TabIndex = 41;
            // 
            // mois
            // 
            this.mois.FormattingEnabled = true;
            this.mois.Items.AddRange(new object[] {
            "Janvier",
            "Fevrier",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Decembre"});
            this.mois.Location = new System.Drawing.Point(443, 114);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(136, 21);
            this.mois.TabIndex = 42;
            // 
            // dataGridProf
            // 
            this.dataGridProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProf.Location = new System.Drawing.Point(22, 82);
            this.dataGridProf.Name = "dataGridProf";
            this.dataGridProf.Size = new System.Drawing.Size(288, 123);
            this.dataGridProf.TabIndex = 43;
            this.dataGridProf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProf_CellClick_1);
            // 
            // prof
            // 
            this.prof.FormattingEnabled = true;
            this.prof.Location = new System.Drawing.Point(443, 215);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(136, 21);
            this.prof.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(323, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Prof  :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(603, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.dataGridProf);
            this.Controls.Add(this.mois);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.dataGridPaiement);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPaiement;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.TextBox salaire;
        private System.Windows.Forms.ComboBox mois;
        private System.Windows.Forms.DataGridView dataGridProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox prof;
    }
}