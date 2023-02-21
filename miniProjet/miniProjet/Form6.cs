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
    public partial class Form6 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        bool clicked = false;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from groupe";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "groupe");
            ds.Tables["groupe"].Constraints.Add("group_PK", ds.Tables["groupe"].Columns[0], true);
            dataGridGrp.DataSource = ds.Tables["groupe"];
        }

        private void refresh()
        {
            string sql = "select * from groupe";
            da = new SqlDataAdapter(sql, cn);
            ds.Clear();
            da.Fill(ds, "groupe");
            dataGridGrp.DataSource = ds.Tables["groupe"];
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (this.name.Text != "" && this.num.Text != "" && this.cap.Text != "")
            {
                DataRow row;
                row = ds.Tables["groupe"].NewRow();
                row["idG"] = 0;
                row["nom"] = this.name.Text;
                row["numGrp"] = int.Parse(this.num.Text);
                row["capacite"] = int.Parse(this.cap.Text);
                ds.Tables["groupe"].Rows.Add(row);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds.Tables["groupe"]);
                this.name.Clear();
                this.num.Clear();
                this.cap.Clear();
                refresh();
            }
            else
                MessageBox.Show("veuiller remplir toute les informations");
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idGrp = ds.Tables["groupe"].Rows[dataGridGrp.CurrentRow.Index]["idG"].ToString();
                DataRow row;
                row = ds.Tables["groupe"].Rows.Find(idGrp);
                row.BeginEdit();
                if (this.name.Text != "")
                    row["nom"] = this.name.Text;
                if (this.num.Text != "")
                    row["numGrp"] = int.Parse(this.num.Text);
                if (this.cap.Text != "")
                    row["capacite"] = int.Parse(this.cap.Text);
                row.EndEdit();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["groupe"]);
            }
            else
                MessageBox.Show("veuiller selectionner la ligne a modifier");
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string idGrp = ds.Tables["groupe"].Rows[dataGridGrp.CurrentRow.Index]["idG"].ToString();
                ds.Tables["groupe"].Rows.Find(idGrp).Delete();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["groupe"]);
                this.name.Clear();
                this.num.Clear();
                this.cap.Clear();
            }
            else
                MessageBox.Show("veuiller selectionner l'utilisateur a supprimer");
        }

        private void dataGridGrp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.name.Text = (string)dataGridGrp.Rows[e.RowIndex].Cells[1].Value;
            this.num.Text = dataGridGrp.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.cap.Text = dataGridGrp.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
