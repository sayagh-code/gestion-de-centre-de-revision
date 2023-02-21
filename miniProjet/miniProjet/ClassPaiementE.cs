using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet
{
    internal class ClassPaiementE
    {
        static SqlDataAdapter daEtudiants;
        static SqlDataAdapter daPayes;
        static SqlDataAdapter verif;
        static DataSet ds;
        static bool test = true;

        public static SqlConnection Connexion()
        {
            var cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
            SqlConnection cn = new SqlConnection(cs);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            return cn;
        }

        public static DataSet ListeEtudiant()
        {
            ds = new DataSet();

            string sql1 = @"select * from etudiant";
            daEtudiants = new SqlDataAdapter(sql1, Connexion());
            daEtudiants.Fill(ds, "etudiant");

            ds.Tables["etudiant"].Constraints.Add("NoEtudiant_PK", ds.Tables["etudiant"].Columns[0], true);
            return ds;
        }

        public static DataSet ListePaiements(DataSet ds)
        {
            string sql2 = @"select * from paye_etudiant";
            daPayes = new SqlDataAdapter(sql2, Connexion());
            daPayes.Fill(ds, "paye_etudiant");
            if (test)
            {
                ds.Tables["paye_etudiant"].Constraints.Add("NoPayeE_PK", ds.Tables["paye_etudiant"].Columns[0], true);
                ds.Relations.Add("Relation1Ep", ds.Tables["etudiant"].Columns["idE"], ds.Tables["paye_etudiant"].Columns["id"]);
                test = false;
            }
            return ds;
        }

        public static DataTable EtudiantPaiement(int rowindex)
        {
            var parentRow = ds.Tables["etudiant"].Rows[rowindex];
            var childRows = parentRow.GetChildRows("Relation1Ep");
            DataTable childTable = ds.Tables["paye_etudiant"].Clone();

            foreach (var row in childRows)
            {
                childTable.ImportRow(row);
            }

            return childTable;
        }

        public static void AjouterPaiement(string mois, float paiement, float paye, int idE)
        {
            //verification
            int reduction = 0;
            DataTable dt = new DataTable();
            DataRow r = ds.Tables["etudiant"].Rows.Find(idE);
            string sql1 = "select count(*) as numero from etudiant where nom='"+ r["nom"] + "' and prenom='"+ r["prenom"] + "'";
            verif = new SqlDataAdapter(sql1, Connexion());
            verif.Fill(dt);

            if ((int)dt.Rows[0]["numero"] >= 2)
            {
                reduction = 20;
            }
            string sql2 = "select count(*) as numero from etudiant where nom='" + r["nom"] + "' and prenom!='" + r["prenom"] + "'";
            verif = new SqlDataAdapter(sql2, Connexion());
            verif.Fill(dt);
            if ((int)dt.Rows[1]["numero"] >= 1)
            {
                reduction += 20;
            }
            if(reduction > 0)
                MessageBox.Show("cette etudiant profite de " + reduction + "% de reduction");
            //ajout
            DataRow row;
            row = ds.Tables["paye_etudiant"].NewRow();
            row["idPe"] = 0;
            row["mois"] = mois;
            row["TotalAPayer"] = paiement;
            row["TotalPaye"] = paye;
            row["ResteAPaye"] = paiement*(100-reduction)/100 - paye;
            row["id"] = idE;
            ds.Tables["paye_etudiant"].Rows.Add(row);
            SqlCommandBuilder cmb = new SqlCommandBuilder(daPayes);
            daPayes.Update(ds.Tables["paye_etudiant"]);
        }

        public static void SupprimerPaiement(string idEp)
        {
            ds.Tables["paye_etudiant"].Rows.Find(idEp).Delete();
            SqlCommandBuilder cmb = new SqlCommandBuilder(daPayes);
            daPayes.Update(ds.Tables["paye_etudiant"]);
        }

        public static void ModifierPaiement(string idEp, string mois, float paiement, float paye, int idE)
        {
            DataRow row;
            row = ds.Tables["paye_etudiant"].Rows.Find(idEp);
            row.BeginEdit();
            row["mois"] = mois;
            row["TotalAPayer"] = paiement;
            row["TotalPaye"] = paye;
            row["ResteAPaye"] = paiement - paye;
            row["id"] = idE;
            row.EndEdit();
            SqlCommandBuilder cmb = new SqlCommandBuilder(daPayes);
            daPayes.Update(ds.Tables["paye_etudiant"]);
        }
    }
}
