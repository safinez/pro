using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarché_Project
{
    public partial class Articles1 : Form
    {
        Functions Con;
        public Articles1()
        {
            InitializeComponent();
            Con = new Functions();
            ListerArticles();
            RemplirCategories();
        }


        private void Filtrage()
        {
            string Req = "select * from ArticlesTbl where CodeArt= {0}";
            int Cat = Convert.ToInt32(FiltrerCb.SelectedValue.ToString()); 
            Req=string.Format(Req, Cat);
            ArticlesListe.DataSource = Con.recupereData(Req);
        }
        private void RemplirCategories()
        {
            string Req = "select * from CategorieTbl";
            CatCb.DisplayMember = Con.recupereData(Req).Columns["NomCat"].ToString();
            CatCb.ValueMember = Con.recupereData(Req).Columns["CodeCat"].ToString();
            CatCb.DataSource = Con.recupereData(Req);

            FiltrerCb.DisplayMember = Con.recupereData(Req).Columns["NomCat"].ToString();
            FiltrerCb.ValueMember = Con.recupereData(Req).Columns["CodeCat"].ToString();
            FiltrerCb.DataSource = Con.recupereData(Req);
        }
        private void ListerArticles()
        {
            string Req = "Select * from ArticlesTbl";
            ArticlesListe.DataSource = Con.recupereData(Req);
        }
        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PrixTb.Text == "" || CatCb.SelectedIndex == -1 || StockTb.Text == ""
)
                { MessageBox.Show("Completer le formulaire svp !!"); }
                else
                {
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    int Stock = Convert.ToInt32(StockTb.Text);
                    string ExpDate = ExTb.Value.Date.ToString();

                    string Req = "insert into ArticlesTbl values('{0}',{1},{2},{3},'{4}')";
                    Req = string.Format(Req, Nom, Prix, Categorie, Stock, ExpDate);
                     Con.envoyerData(Req);
                     ListerArticles();
                     MessageBox.Show("Article ajoutée avec success");
                     NomTb.Text = "";
                     PrixTb.Text = "";
                     StockTb.Text = "";
                     CatCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        int key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = ArticlesListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ArticlesListe.SelectedRows[0].Cells[2].Value.ToString();
            CatCb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();
            if (NomTb.Text == "")
            { key = 0; }
            else
            {
                key = Convert.ToInt32(ArticlesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                { MessageBox.Show("select un article svp !!"); }
                else
                {
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    int Stock = Convert.ToInt32(StockTb.Text);
                    string ExpDate = ExTb.Value.Date.ToString();

                    string Req = "delete from ArticlesTbl where CodeArt = {0}";
                    Req = string.Format(Req,key);
                    Con.envoyerData(Req);
                    ListerArticles();
                    MessageBox.Show("Article supprimée");
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    CatCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PrixTb.Text == "" || CatCb.SelectedIndex == -1 || StockTb.Text == ""
)
                { MessageBox.Show("Completer le formulaire svp !!"); }
                else
                {
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());
                    int Stock = Convert.ToInt32(StockTb.Text);
                    string ExpDate = ExTb.Value.Date.ToString();

                    string Req = "update ArticlesTbl set NomArt = '{0}',PrixArt= {1},CategArt= {2},StockArt= {3},ExpDateArt='{4}' where CodeArt ={5}";
                    Req = string.Format(Req, Nom, Prix, Categorie, Stock, ExpDate, key);
                    Con.envoyerData(Req);
                    ListerArticles();
                    MessageBox.Show("Article Modifiée");
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    CatCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void FiltrerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrage();
        }

        private void ActualiserBtn_Click(object sender, EventArgs e)
        {
            ListerArticles();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

      
        private void DeconnexionBtn_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articles1 Obj = new Articles1();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Factures Obj = new Factures();
            Obj.Show();
            this.Hide();
        }
    }
}
