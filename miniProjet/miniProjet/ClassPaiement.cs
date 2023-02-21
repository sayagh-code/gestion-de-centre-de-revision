using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniProjet
{
    internal class ClassPaiement
    {
        static SqlDataAdapter daProfs;
        static SqlDataAdapter daPayes;
        static DataSet ds;
        static bool test = true;
        public ClassPaiement() { }

        public static SqlConnection Connexion()
        {
            var cs = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbProjet;Data Source=LAPTOP-N6C8QHBC";
            SqlConnection cn = new SqlConnection(cs);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            return cn;
        }

        public static DataSet ListeProfesseurs()
        {
            ds = new DataSet();

            string sql1 = @"select * from professeur";
            daProfs = new SqlDataAdapter(sql1, Connexion());
            daProfs.Fill(ds, "professeur");

            ds.Tables["professeur"].Constraints.Add("NoProfesseur_PK", ds.Tables["professeur"].Columns[0], true);
            return ds;
        }

        public static DataSet ListePaiements(DataSet ds)
        {
            string sql2 = @"select * from paye_prof";
            daPayes = new SqlDataAdapter(sql2, Connexion());
            daPayes.Fill(ds, "paye_prof");
            if (test)
            {
                ds.Tables["paye_prof"].Constraints.Add("NoPayeP_PK", ds.Tables["paye_prof"].Columns[0], true);
                ds.Relations.Add("Relation1Pp", ds.Tables["professeur"].Columns["idP"], ds.Tables["paye_prof"].Columns["prof"]);
                test = false;
            }
            return ds;
        }

        public static DataTable ProfPaiement(int rowindex)
        {
            var parentRow = ds.Tables["professeur"].Rows[rowindex];
            var childRows = parentRow.GetChildRows("Relation1Pp");
            DataTable childTable = ds.Tables["paye_prof"].Clone();

            foreach (var row in childRows)
            {
                childTable.ImportRow(row);
            }

            return childTable;
        }

        public static void AjouterPaiement(string mois, float salaire, int idP)
        {
            DataRow row;
            row = ds.Tables["paye_prof"].NewRow();
            row["idPp"] = 0;
            row["mois"] = mois;
            row["salaire"] = salaire;
            row["prof"] = idP;
            ds.Tables["paye_prof"].Rows.Add(row);
            SqlCommandBuilder cmb = new SqlCommandBuilder(daPayes);
            daPayes.Update(ds.Tables["paye_prof"]);
        }

        public static void SupprimerPaiement(string idPp)
        {
            ds.Tables["paye_prof"].Rows.Find(idPp).Delete();
            SqlCommandBuilder cmb = new SqlCommandBuilder(daPayes);
            daPayes.Update(ds.Tables["paye_prof"]);
        }

        public static void ModifierPaiement(string idPp, string mois, float salaire, int idP)
        {
            DataRow row;
            row = ds.Tables["paye_prof"].Rows.Find(idPp);
            row.BeginEdit();
            row["mois"] = mois;
            row["salaire"] = salaire;
            row["prof"] = idP;
            row.EndEdit();
            SqlCommandBuilder cmb = new SqlCommandBuilder(daPayes);
            daPayes.Update(ds.Tables["paye_prof"]);
        }
    }
}
