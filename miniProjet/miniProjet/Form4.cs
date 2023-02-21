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
    public partial class Form4 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        bool clicked = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from professeur";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "professeur");
            ds.Tables["professeur"].Constraints.Add("profId_PK", ds.Tables["professeur"].Columns[0], true);
            dataGridProf.DataSource = ds.Tables["professeur"];
        }

        private void refresh()
        {
            string sql = "select * from professeur";
            da = new SqlDataAdapter(sql, cn);
            ds.Clear();
            da.Fill(ds, "professeur");
            dataGridProf.DataSource = ds.Tables["professeur"];
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (this.firstName.Text != "" && this.lastName.Text != "" && this.tel.Text != "")
            {
                int tel;
                if (this.tel.Text.Length==10 && int.TryParse(this.tel.Text,out tel)) 
                {
                    DataRow row;
                    row = ds.Tables["professeur"].NewRow();
                    row["idP"] = 0;
                    row["nom"] = this.firstName.Text;
                    row["prenom"] = this.lastName.Text;
                    row["tel"] = tel;
                    ds.Tables["professeur"].Rows.Add(row);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                    da.Update(ds.Tables["professeur"]);
                    this.firstName.Clear();
                    this.lastName.Clear();
                    this.tel.Clear();
                    refresh();
                }
                else
                    MessageBox.Show("le numero de telephone est invalide");
            }
            else
                MessageBox.Show("veuiller remplir toute les informations");
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idProf = ds.Tables["professeur"].Rows[dataGridProf.CurrentRow.Index]["idP"].ToString();
                DataRow row;
                row = ds.Tables["professeur"].Rows.Find(idProf);
                row.BeginEdit();
                if (this.firstName.Text != "")
                    row["nom"] = this.firstName.Text;
                if (this.lastName.Text != "")
                    row["prenom"] = this.lastName.Text;
                if (this.tel.Text != "")
                    row["tel"] = this.tel.Text;
                row.EndEdit();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["professeur"]);
            }
            else
                MessageBox.Show("veuiller selectionner la ligne a modifier");
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idProf = ds.Tables["professeur"].Rows[dataGridProf.CurrentRow.Index]["idP"].ToString();
                ds.Tables["professeur"].Rows.Find(idProf).Delete();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["professeur"]);
                this.firstName.Clear();
                this.lastName.Clear();
                this.tel.Clear();
            }
            else
                MessageBox.Show("veuiller selectionner l'utilisateur a supprimer");
        }

        private void dataGridProf_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.firstName.Text = (string)dataGridProf.Rows[e.RowIndex].Cells[1].Value;
            this.lastName.Text = (string)dataGridProf.Rows[e.RowIndex].Cells[2].Value;
            this.tel.Text = dataGridProf.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void paimentPage_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
