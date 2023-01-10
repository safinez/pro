using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarché_Project
{
    public partial class Connexion : Form
    {
        Functions Con;
        public Connexion()
        {
            InitializeComponent();
            Con = new Functions();
        }

        public static int UserId;
        public static string UserName;


        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Entrer les informations Completes!!");
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                Vendeurs Obj = new Vendeurs();
                Obj.Show();
                this.Hide();
            }
            else
            {
                string Req = "select * from VendeurTBl where VendPseudo = '{0}' and VendPass = '{1}'";
                Req = string.Format(Req, textBox1.Text, textBox2.Text);
                DataTable dt = Con.recupereData(Req);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Vendeur Inexistant!!");

                }
                else
                {
                    Categories Obj = new Categories();
                    Obj.Show();
                    this.Hide();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MdpTB_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PseuVendeurTB_Click(object sender, EventArgs e)
        {

        }
    }
}
