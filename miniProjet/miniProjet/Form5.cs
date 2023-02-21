using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet
{
    public partial class Form5 : Form
    {
        DataSet dsListeProfesseurs = ClassPaiement.ListeProfesseurs();
        bool clicked = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridProf.DataSource =
                dsListeProfesseurs.Tables["professeur"];
            //Charger le combobox
            prof.DataSource = dsListeProfesseurs.Tables["professeur"];
            prof.DisplayMember = "nom";
            prof.ValueMember = "idP";
            ClassPaiement.ListePaiements(dsListeProfesseurs);
        }

        private void refresh()
        {
            this.salaire.Clear();
            int rowIndex = dataGridProf.CurrentRow.Index;
            dataGridPaiement.DataSource = ClassPaiement.ProfPaiement(rowIndex);
        }

        private void dataGridProf_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridProf.CurrentRow.Index;
            DataTable dtPaiements = ClassPaiement.ProfPaiement(rowIndex);
            dataGridPaiement.DataSource = dtPaiements;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string m = this.mois.Text;
            float s = int.Parse(this.salaire.Text);
            int p = int.Parse(this.prof.SelectedValue.ToString());

            ClassPaiement.AjouterPaiement(m, s, p);
            ClassPaiement.ListePaiements(dsListeProfesseurs).Tables["paye_prof"].Clear();
            ClassPaiement.ListePaiements(dsListeProfesseurs);
            refresh();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idPp = dataGridPaiement.Rows[dataGridPaiement.CurrentRow.Index].Cells[0].Value.ToString();
                ClassPaiement.SupprimerPaiement(idPp);
                refresh();
            }
            else
                MessageBox.Show("veuiller selectionner le paiement a supprimer");
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idPp = dataGridPaiement.Rows[dataGridPaiement.CurrentRow.Index].Cells[0].Value.ToString();
                string m = this.mois.Text;
                float s = int.Parse(this.salaire.Text);
                int p = int.Parse(this.prof.SelectedValue.ToString());
                ClassPaiement.ModifierPaiement(idPp, m, s, p);
                refresh();
            }
            else
                MessageBox.Show("veuiller selectionner le paiement a modifier");
        }

        private void dataGridPaiement_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.mois.Text = (string)dataGridPaiement.Rows[e.RowIndex].Cells[1].Value;
            this.salaire.Text = dataGridPaiement.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.prof.SelectedValue = (int)dataGridPaiement.Rows[e.RowIndex].Cells[3].Value;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
