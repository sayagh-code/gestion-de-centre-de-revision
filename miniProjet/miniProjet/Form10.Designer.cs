namespace miniProjet
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label4 = new System.Windows.Forms.Label();
            this.etudiant = new System.Windows.Forms.ComboBox();
            this.dataGridEtudiant = new System.Windows.Forms.DataGridView();
            this.mois = new System.Windows.Forms.ComboBox();
            this.paiement = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.dataGridPaiement = new System.Windows.Forms.DataGridView();
            this.paye = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaiement)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(324, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Etudiant  :";
            // 
            // etudiant
            // 
            this.etudiant.FormattingEnabled = true;
            this.etudiant.Location = new System.Drawing.Point(444, 214);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(136, 21);
            this.etudiant.TabIndex = 58;
            // 
            // dataGridEtudiant
            // 
            this.dataGridEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtudiant.Location = new System.Drawing.Point(23, 81);
            this.dataGridEtudiant.Name = "dataGridEtudiant";
            this.dataGridEtudiant.Size = new System.Drawing.Size(288, 123);
            this.dataGridEtudiant.TabIndex = 57;
            this.dataGridEtudiant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEtudiant_CellClick);
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
            this.mois.Location = new System.Drawing.Point(444, 113);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(136, 21);
            this.mois.TabIndex = 56;
            // 
            // paiement
            // 
            this.paiement.Location = new System.Drawing.Point(444, 150);
            this.paiement.Name = "paiement";
            this.paiement.Size = new System.Drawing.Size(136, 20);
            this.paiement.TabIndex = 55;
            // 
            // supprimer
            // 
            this.supprimer.FlatAppearance.BorderSize = 3;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.supprimer.Image = ((System.Drawing.Image)(resources.GetObject("supprimer.Image")));
            this.supprimer.Location = new System.Drawing.Point(510, 262);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(70, 61);
            this.supprimer.TabIndex = 54;
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.FlatAppearance.BorderSize = 3;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.modifier.Image = ((System.Drawing.Image)(resources.GetObject("modifier.Image")));
            this.modifier.Location = new System.Drawing.Point(419, 262);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(70, 61);
            this.modifier.TabIndex = 53;
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // ajouter
            // 
            this.ajouter.FlatAppearance.BorderSize = 3;
            this.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.ajouter.Image = ((System.Drawing.Image)(resources.GetObject("ajouter.Image")));
            this.ajouter.Location = new System.Drawing.Point(327, 262);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(70, 61);
            this.ajouter.TabIndex = 52;
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(324, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mois :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(324, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Paiement  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 49;
            this.label1.Text = "Paiement";
            // 
            // retour
            // 
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Image = ((System.Drawing.Image)(resources.GetObject("retour.Image")));
            this.retour.Location = new System.Drawing.Point(23, 18);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 41);
            this.retour.TabIndex = 48;
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // dataGridPaiement
            // 
            this.dataGridPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPaiement.Location = new System.Drawing.Point(23, 231);
            this.dataGridPaiement.Name = "dataGridPaiement";
            this.dataGridPaiement.Size = new System.Drawing.Size(288, 123);
            this.dataGridPaiement.TabIndex = 47;
            this.dataGridPaiement.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPaiement_RowHeaderMouseClick);
            // 
            // paye
            // 
            this.paye.Location = new System.Drawing.Point(444, 183);
            this.paye.Name = "paye";
            this.paye.Size = new System.Drawing.Size(136, 20);
            this.paye.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(324, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Payé :";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(603, 396);
            this.Controls.Add(this.paye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etudiant);
            this.Controls.Add(this.dataGridEtudiant);
            this.Controls.Add(this.mois);
            this.Controls.Add(this.paiement);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.dataGridPaiement);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtudiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaiement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox etudiant;
        private System.Windows.Forms.DataGridView dataGridEtudiant;
        private System.Windows.Forms.ComboBox mois;
        private System.Windows.Forms.TextBox paiement;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.DataGridView dataGridPaiement;
        private System.Windows.Forms.TextBox paye;
        private System.Windows.Forms.Label label3;
    }
}