using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarché_Project
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string conString;

        //Connection à la base de données
        public Functions()
        {
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\SuperMarcheBD.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(conString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }


        //Récupérer les données
        public DataTable recupereData (string Req)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, conString);
            sda.Fill(dt);
            return dt;
        }

        //envoyer les données
        public int envoyerData (string Req)
        {
            int i = 0;  
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Req;
            i= Cmd.ExecuteNonQuery();
            return i;
        }
    }
}
