using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet
{
    public partial class Form10 : Form
    {
        DataSet dsListeEtudiants = ClassPaiementE.ListeEtudiant();
        bool clicked = false;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridEtudiant.DataSource =
                dsListeEtudiants.Tables["etudiant"];
            //Charger le combobox
            etudiant.DataSource = dsListeEtudiants.Tables["etudiant"];
            etudiant.DisplayMember = "nom";
            etudiant.ValueMember = "idE";
            ClassPaiementE.ListePaiements(dsListeEtudiants);
        }

        private void refresh()
        {
            this.paiement.Clear();
            this.paye.Clear();
            int rowIndex = dataGridEtudiant.CurrentRow.Index;
            dataGridPaiement.DataSource = ClassPaiementE.EtudiantPaiement(rowIndex);
        }

        private void dataGridEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridEtudiant.CurrentRow.Index;
            DataTable dtPaiements = ClassPaiementE.EtudiantPaiement(rowIndex);
            dataGridPaiement.DataSource = dtPaiements;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string m = this.mois.Text;
            float s1 = float.Parse(this.paiement.Text);
            float s2 = float.Parse(this.paye.Text);
            int p = int.Parse(this.etudiant.SelectedValue.ToString());

            ClassPaiementE.AjouterPaiement(m, s1, s2, p);
            ClassPaiementE.ListePaiements(dsListeEtudiants).Tables["paye_etudiant"].Clear();
            ClassPaiementE.ListePaiements(dsListeEtudiants);
            refresh();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idEp = dataGridPaiement.Rows[dataGridPaiement.CurrentRow.Index].Cells[0].Value.ToString();
                ClassPaiementE.SupprimerPaiement(idEp);
                refresh();
            }
            else
                MessageBox.Show("veuiller selectionner le paiement a supprimer");
        }

        private void dataGridPaiement_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.mois.Text = (string)dataGridPaiement.Rows[e.RowIndex].Cells[1].Value;
            this.paiement.Text = dataGridPaiement.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.paye.Text = dataGridPaiement.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.etudiant.SelectedValue = (int)dataGridPaiement.Rows[e.RowIndex].Cells[4].Value;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idEp = dataGridPaiement.Rows[dataGridPaiement.CurrentRow.Index].Cells[0].Value.ToString();
                string m = this.mois.Text;
                float s1 = float.Parse(this.paiement.Text);
                float s2 = float.Parse(this.paye.Text);
                int p = int.Parse(this.etudiant.SelectedValue.ToString());
                ClassPaiementE.ModifierPaiement(idEp, m, s1, s2, p);
                refresh();
            }
            else
                MessageBox.Show("veuiller selectionner le paiement a modifier");
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
    }
}
