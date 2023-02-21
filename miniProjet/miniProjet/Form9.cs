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
    public partial class Form9 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        static SqlDataAdapter daGrp;
        DataSet ds = new DataSet();
        bool clicked = false;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from etudiant";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "etudiant");
            ds.Tables["etudiant"].Constraints.Add("etudiantId_PK", ds.Tables["etudiant"].Columns[0], true);
            dataGridEtudiant.DataSource = ds.Tables["etudiant"];

            //groupe
            string sql2 = @"select * from groupe";
            daGrp = new SqlDataAdapter(sql2, cn);
            daGrp.Fill(ds, "groupe");
            ds.Tables["groupe"].Constraints.Add("NoGroupe_PK", ds.Tables["groupe"].Columns[0], true);

            grp.DataSource = ds.Tables["groupe"];
            grp.DisplayMember = "nom";
            grp.ValueMember = "idG";
        }

        private void refresh()
        {
            string sql = "select * from etudiant";
            da = new SqlDataAdapter(sql, cn);
            ds.Tables["etudiant"].Clear();
            da.Fill(ds, "etudiant");
            dataGridEtudiant.DataSource = ds.Tables["etudiant"];
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (this.firstName.Text != "" && this.lastName.Text != "" && this.tel.Text != "")
            {
                int tel;
                if (this.tel.Text.Length == 10 && int.TryParse(this.tel.Text, out tel))
                {
                    DataRow row;
                    row = ds.Tables["etudiant"].NewRow();
                    row["idE"] = 0;
                    row["nom"] = this.firstName.Text;
                    row["prenom"] = this.lastName.Text;
                    row["tel"] = tel;
                    row["groupe"] = int.Parse(this.grp.SelectedValue.ToString());
                    ds.Tables["etudiant"].Rows.Add(row);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds.Tables["etudiant"]);
                    this.firstName.Clear();
                    this.lastName.Clear();
                    this.tel.Clear();
                    refresh();
                }
                else
                    MessageBox.Show("le numero de telephone est invalide");
            }
            else
                MessageBox.Show("veuillez remplir tout les champs");
        }

        private void dataGridEtudiant_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.firstName.Text = (string)dataGridEtudiant.Rows[e.RowIndex].Cells[1].Value;
            this.lastName.Text = (string)dataGridEtudiant.Rows[e.RowIndex].Cells[2].Value;
            this.tel.Text = "0" + dataGridEtudiant.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.grp.SelectedValue = (int)dataGridEtudiant.Rows[e.RowIndex].Cells[4].Value;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idE = ds.Tables["etudiant"].Rows[dataGridEtudiant.CurrentRow.Index]["idE"].ToString();
                DataRow row;
                row = ds.Tables["etudiant"].Rows.Find(idE);
                row.BeginEdit();
                if (this.firstName.Text != "")
                    row["nom"] = this.firstName.Text;
                if (this.lastName.Text != "")
                    row["prenom"] = this.lastName.Text;
                if(this.tel.Text != "")
                    row["tel"] = int.Parse(this.tel.Text);
                row["groupe"] = int.Parse(this.grp.SelectedValue.ToString());
                row.EndEdit();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["etudiant"]);
            }
            else
                MessageBox.Show("veuiller selectionner la ligne a modifier");
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idE = ds.Tables["etudiant"].Rows[dataGridEtudiant.CurrentRow.Index]["idE"].ToString();
                ds.Tables["etudiant"].Rows.Find(idE).Delete();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["etudiant"]);
                this.firstName.Clear();
                this.lastName.Clear();
                this.tel.Clear();
            }
            else
                MessageBox.Show("veuiller selectionner l'utilisateur a supprimer");
        }

        private void paimentPage_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}