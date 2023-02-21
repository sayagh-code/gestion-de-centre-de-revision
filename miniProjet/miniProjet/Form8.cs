using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet
{
    public partial class Form8 : Form
    {
        string cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string nomC;
        string chemin;
        bool changed = false;

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string sql = "select * from centre";
            da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "centre");
            ds.Tables["centre"].Constraints.Add("centreID_PK", ds.Tables["centre"].Columns[0], true);
            DataRow row;
            row = ds.Tables["centre"].Rows[0];
            this.nom.Text = row["nom"].ToString();
            this.adresse.Text = row["adresse"].ToString();
            this.date.Text = row["annee"].ToString();
            this.site.Text = row["siteWeb"].ToString();
            this.rib.Text = row["RIB"].ToString();
            this.mail.Text = row["email"].ToString();
            this.tel.Text = "0" + row["tel"].ToString();

            byte[] epingle = (byte[])row["logo"];
            MemoryStream ms = new MemoryStream(epingle);
            this.logo.Image = Image.FromStream(ms);

            nomC = this.nom.Text;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            byte[] tabimg = null;
            if (chemin != null)
            {
                FileStream fs = new FileStream(chemin, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                tabimg = br.ReadBytes((int)fs.Length);
                fs.Close();
            }

            DataRow row;
            MessageBox.Show(nomC);
            row = ds.Tables["centre"].Rows.Find(nomC);
            row.BeginEdit();
            if (this.nom.Text != "")
                row["nom"] = this.nom.Text;
            if (this.adresse.Text != "")
                row["adresse"] = this.adresse.Text;
            if (this.date.Text != "")
                row["annee"] = this.date.Text;
            if (this.site.Text != "")
                row["siteWeb"] = this.site.Text;
            if (this.rib.Text != "")
                row["RIB"] = this.rib.Text;
            if (this.mail.Text != "")
                row["email"] = this.mail.Text;
            if (this.tel.Text != "")
                row["tel"] = this.tel.Text;
            if(changed && tabimg != null)
                row["logo"] = tabimg;
            row.EndEdit();
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds.Tables["centre"]);
            nomC = this.nom.Text;
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "selectionner le nouveau logo";
            if (of.ShowDialog() == DialogResult.OK)
            {
                logo.ImageLocation = of.FileName;
                chemin = of.FileName;
                changed= true;
            }
        }
    }
}
