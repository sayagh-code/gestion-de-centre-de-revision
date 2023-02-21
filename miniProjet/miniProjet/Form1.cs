using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miniProjet
{
    public partial class Form1 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameUser = this.usename.Text;
            if (ds.Tables["utilisateur"].Rows.Contains(nameUser))
            {
                DataRow row;
                row = ds.Tables["utilisateur"].Rows.Find(nameUser);
                if (String.Equals(row["mdp"], this.password.Text))
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Mot de passe incorrect");
            }
            else
                MessageBox.Show("Votre nom d'utilisateur est incorrect");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from utilisateur";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "utilisateur");
            ds.Tables["utilisateur"].Constraints.Add("userName_PK", ds.Tables["utilisateur"].Columns[0], true);
        }
    }
}
