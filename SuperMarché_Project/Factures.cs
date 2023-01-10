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
    public partial class Factures : Form
    {
        Functions Con;
        public Factures()
        {
            InitializeComponent();
            Con = new Functions();
            ListerArticles();
            NomTb.Text = Connexion.UserName;


        }
        private void ListerArticles()
        {
            try
            {
                string Req = "Select ArtNom as Article, ArtPrix as Prix, CatNom as Categories,ArtStock as Stock from ArticlesTBl join CategorieTBl on ArticlesTBl.ArtCat = CategorieTBl.CatCode";

                ArticlesListe.DataSource = Con.recupereData(Req);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArticleTb.Text = ArticlesListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ArticlesListe.SelectedRows[0].Cells[2].Value.ToString();
            //CatCb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();
            if (ArticleTb.Text == "")
            { key = 0; }
            else
            {
                key = Convert.ToInt32(ArticlesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Articles1 Obj = new Articles1();
            Obj.Show();
            this.Hide();


        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Factures Obj = new Factures();
            Obj.Show();
            this.Hide();
        }

        private void DeconnexionBtn_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();

        }

        private void Factures_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'superMarcheBDDataSet1.ArticlesTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.articlesTblTableAdapter.Fill(this.superMarcheBDDataSet1.ArticlesTbl);

        }

        private void RéniBtn_Click(object sender, EventArgs e)
        {
            ArticleTb.Text = "";
            QuanTb.Text = "";
            PrixTb.Text = "";
            StockTb.Text = "";
        }
        int n = 0;
        int GrdTotal = 0;
        private DataGridView FactureListe;

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            if(PrixTb.Text =="" || QuanTb.Text =="" || StockTb.Text ==""||ArticleTb.Text == "")
            {
                MessageBox.Show("Information Manquante!!");

            }
            {
                if(Convert.ToInt32(QuanTb.Text)> Convert.ToInt32(StockTb.Text))
                {
                    MessageBox.Show("Stock Non Disponible!!");

                }else
                {
                    if (Convert.ToInt32(QuanTb.Text) > Convert.ToInt32(StockTb.Text))
                    {
                        MessageBox.Show("Stock Non Disponible!!");
                    }
                    int Total = Convert.ToInt32(QuanTb.Text) * Convert.ToInt32(StockTb.Text);
                        DataGridViewRow Ligne = new DataGridViewRow();
                    Ligne.CreateCells(FactureListe);
                    Ligne.Cells[0].Value = n + 1;
                    Ligne.Cells[1].Value = ArticleTb.Text;
                    Ligne.Cells[2].Value = QuanTb.Text;
                    Ligne.Cells[3].Value = PrixTb.Text;
                    Ligne.Cells[4].Value = Total;
                    FactureListe.Rows.Add(Ligne);
                    GrdTotal = GrdTotal + Total;
                    PrixtTotalTbl.Text = GrdTotal + "$";
                    ArticleTb.Text = "";
                    QuanTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";


                }
            }
        }
    }
}
