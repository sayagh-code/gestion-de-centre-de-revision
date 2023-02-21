namespace miniProjet
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.quit = new System.Windows.Forms.Button();
            this.matiere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eleve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.centre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.prof = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.White;
            this.quit.Location = new System.Drawing.Point(363, 361);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(107, 40);
            this.quit.TabIndex = 0;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // matiere
            // 
            this.matiere.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.matiere.FlatAppearance.BorderSize = 0;
            this.matiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matiere.Image = ((System.Drawing.Image)(resources.GetObject("matiere.Image")));
            this.matiere.Location = new System.Drawing.Point(106, 46);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(135, 109);
            this.matiere.TabIndex = 1;
            this.matiere.UseVisualStyleBackColor = true;
            this.matiere.Click += new System.EventHandler(this.matiere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matières";
            // 
            // group
            // 
            this.group.FlatAppearance.BorderSize = 0;
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Image = ((System.Drawing.Image)(resources.GetObject("group.Image")));
            this.group.Location = new System.Drawing.Point(345, 46);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(135, 109);
            this.group.TabIndex = 3;
            this.group.UseVisualStyleBackColor = true;
            this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Groupes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eleve
            // 
            this.eleve.FlatAppearance.BorderSize = 0;
            this.eleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eleve.Image = ((System.Drawing.Image)(resources.GetObject("eleve.Image")));
            this.eleve.Location = new System.Drawing.Point(556, 47);
            this.eleve.Name = "eleve";
            this.eleve.Size = new System.Drawing.Size(135, 109);
            this.eleve.TabIndex = 5;
            this.eleve.UseVisualStyleBackColor = true;
            this.eleve.Click += new System.EventHandler(this.eleve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elèves";
            // 
            // user
            // 
            this.user.FlatAppearance.BorderSize = 0;
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(345, 202);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(135, 109);
            this.user.TabIndex = 7;
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Utilisateurs";
            // 
            // centre
            // 
            this.centre.FlatAppearance.BorderSize = 0;
            this.centre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centre.Image = ((System.Drawing.Image)(resources.GetObject("centre.Image")));
            this.centre.Location = new System.Drawing.Point(556, 202);
            this.centre.Name = "centre";
            this.centre.Size = new System.Drawing.Size(135, 109);
            this.centre.TabIndex = 9;
            this.centre.UseVisualStyleBackColor = true;
            this.centre.Click += new System.EventHandler(this.centre_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Infos du Centre";
            // 
            // prof
            // 
            this.prof.FlatAppearance.BorderSize = 0;
            this.prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prof.Image = ((System.Drawing.Image)(resources.GetObject("prof.Image")));
            this.prof.Location = new System.Drawing.Point(106, 202);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(135, 109);
            this.prof.TabIndex = 11;
            this.prof.UseVisualStyleBackColor = true;
            this.prof.Click += new System.EventHandler(this.prof_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Professeurs";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.centre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eleve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.quit);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button matiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eleve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button centre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button prof;
        private System.Windows.Forms.Label label6;
    }
}