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
    public partial class Form7 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        static SqlDataAdapter daProf;
        static SqlDataAdapter daGrp;
        static DataSet ds = new DataSet();
        bool clicked = false;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            //matiere
            string sql = "select * from matiere";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "matiere");
            ds.Tables["matiere"].Constraints.Add("matiere_PK", ds.Tables["matiere"].Columns[0], true);
            dataGridMatiere.DataSource = ds.Tables["matiere"];
            //prof
            string sql1 = @"select * from professeur";
            daProf = new SqlDataAdapter(sql1, cn);
            daProf.Fill(ds, "professeur");
            ds.Tables["professeur"].Constraints.Add("NoProfesseur_PK", ds.Tables["professeur"].Columns[0], true);

            prof.DataSource = ds.Tables["professeur"];
            prof.DisplayMember = "nom";
            prof.ValueMember = "idP";
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
            string sql = "select * from matiere";
            da = new SqlDataAdapter(sql, cn);
            ds.Tables["matiere"].Clear();
            da.Fill(ds, "matiere");
            dataGridMatiere.DataSource = ds.Tables["matiere"];
        }

        private void dataGridMatiere_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.name.Text = (string)dataGridMatiere.Rows[e.RowIndex].Cells[1].Value;
            this.prof.SelectedValue = (int)dataGridMatiere.Rows[e.RowIndex].Cells[2].Value;
            this.grp.SelectedValue = (int)dataGridMatiere.Rows[e.RowIndex].Cells[3].Value;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (this.name.Text != "")
            {
                DataRow row;
                row = ds.Tables["matiere"].NewRow();
                row["idM"] = 0;
                row["nom"] = this.name.Text;
                row["prof"] = int.Parse(this.prof.SelectedValue.ToString());
                row["groupe"] = int.Parse(this.grp.SelectedValue.ToString());
                ds.Tables["matiere"].Rows.Add(row);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds.Tables["matiere"]);
                this.name.Clear();
                refresh();
            }
            else
                MessageBox.Show("veuillez saisir le nom de la matiere");
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idM = ds.Tables["matiere"].Rows[dataGridMatiere.CurrentRow.Index]["idM"].ToString();
                DataRow row;
                row = ds.Tables["matiere"].Rows.Find(idM);
                row.BeginEdit();
                if (this.name.Text != "")
                    row["nom"] = this.name.Text;
                row["prof"] = int.Parse(this.prof.SelectedValue.ToString());
                row["groupe"] = int.Parse(this.grp.SelectedValue.ToString());
                row.EndEdit();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["matiere"]);
            }
            else
                MessageBox.Show("veuiller selectionner la ligne a modifier");
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idM = ds.Tables["matiere"].Rows[dataGridMatiere.CurrentRow.Index]["idM"].ToString();
                ds.Tables["matiere"].Rows.Find(idM).Delete();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["matiere"]);
                this.name.Clear();
            }
            else
                MessageBox.Show("veuiller selectionner l'utilisateur a supprimer");
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}