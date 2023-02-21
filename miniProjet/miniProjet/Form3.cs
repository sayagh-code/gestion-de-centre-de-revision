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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace miniProjet
{
    public partial class Form3 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        bool clicked = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from utilisateur";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "utilisateur");
            ds.Tables["utilisateur"].Constraints.Add("userName_PK", ds.Tables["utilisateur"].Columns[0], true);
            dataGridUser.DataSource = ds.Tables["utilisateur"];
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (this.login.Text!="" && this.mdp.Text!="" && this.statut.Text!="") {
                if (this.statut.Text=="admin" || this.statut.Text=="user") {
                    string nameUser = this.login.Text;
                    if (!ds.Tables["utilisateur"].Rows.Contains(nameUser)) {
                        DataRow row;
                        row = ds.Tables["utilisateur"].NewRow();
                        row["username"] = this.login.Text;
                        row["mdp"] = this.mdp.Text;
                        row["statut"] = this.statut.Text;
                        ds.Tables["utilisateur"].Rows.Add(row);
                        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                        da.Update(ds.Tables["utilisateur"]);
                        this.login.Clear();
                        this.mdp.Clear();
                        this.statut.Clear();
                    }
                    else
                        MessageBox.Show("Cet utilisateur existe deja");
                }
                else
                    MessageBox.Show("les seuls choix possible pour le statut sont 'admin' ou 'user'");
            }
            else
                MessageBox.Show("veuiller remplir toute les informations");
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                if (this.statut.Text == "admin" || this.statut.Text == "user")
                {
                    string nameUser = ds.Tables["utilisateur"].Rows[dataGridUser.CurrentRow.Index]["username"].ToString();
                    DataRow row;
                    row = ds.Tables["utilisateur"].Rows.Find(nameUser);
                    row.BeginEdit();
                    if (this.login.Text != "")
                        row["username"] = this.login.Text;
                    if (this.mdp.Text != "")
                        row["mdp"] = this.mdp.Text;
                    if (this.statut.Text != "")
                        row["statut"] = this.statut.Text;
                    row.EndEdit();
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds.Tables["utilisateur"]);
                }
                else
                    MessageBox.Show("les seuls choix possible pour le statut sont 'admin' ou 'user'");
            }
            else
                MessageBox.Show("veuiller selectionner la ligne a modifier");
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                string nameUser = ds.Tables["utilisateur"].Rows[dataGridUser.CurrentRow.Index]["username"].ToString();
                ds.Tables["utilisateur"].Rows.Find(nameUser).Delete();
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["utilisateur"]);
                this.login.Clear();
                this.mdp.Clear();
                this.statut.Clear();
            }
            else
                MessageBox.Show("veuiller selectionner l'utilisateur a supprimer");
        }

        private void dataGridUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked = true;
            this.login.Text = (string)dataGridUser.Rows[e.RowIndex].Cells[0].Value;
            this.mdp.Text = (string)dataGridUser.Rows[e.RowIndex].Cells[1].Value;
            this.statut.Text = (string)dataGridUser.Rows[e.RowIndex].Cells[2].Value;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
