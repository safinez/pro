
namespace SuperMarché_Project
{
    partial class Factures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeconnexionBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.RéniBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.VendeursListe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuanTb = new System.Windows.Forms.TextBox();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.ArticleTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ArticlesListe = new System.Windows.Forms.DataGridView();
            this.codeArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDateArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articlesTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarcheBDDataSet1 = new SuperMarché_Project.SuperMarcheBDDataSet1();
            this.articlesTblTableAdapter = new SuperMarché_Project.SuperMarcheBDDataSet1TableAdapters.ArticlesTblTableAdapter();
            this.NomTb = new System.Windows.Forms.Label();
            this.PrixtTotalTbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VendeursListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeconnexionBtn
            // 
            this.DeconnexionBtn.Location = new System.Drawing.Point(614, 12);
            this.DeconnexionBtn.Name = "DeconnexionBtn";
            this.DeconnexionBtn.Size = new System.Drawing.Size(174, 23);
            this.DeconnexionBtn.TabIndex = 45;
            this.DeconnexionBtn.Text = "Se déconnecter";
            this.DeconnexionBtn.UseVisualStyleBackColor = true;
            this.DeconnexionBtn.Click += new System.EventHandler(this.DeconnexionBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.Location = new System.Drawing.Point(588, 582);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(75, 23);
            this.SupprimerBtn.TabIndex = 44;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = true;
            // 
            // RéniBtn
            // 
            this.RéniBtn.Location = new System.Drawing.Point(358, 115);
            this.RéniBtn.Name = "RéniBtn";
            this.RéniBtn.Size = new System.Drawing.Size(75, 23);
            this.RéniBtn.TabIndex = 43;
            this.RéniBtn.Text = "Rénisialiser";
            this.RéniBtn.UseVisualStyleBackColor = true;
            this.RéniBtn.Click += new System.EventHandler(this.RéniBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.Location = new System.Drawing.Point(209, 115);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(117, 23);
            this.EnregistrerBtn.TabIndex = 42;
            this.EnregistrerBtn.Text = "Ajouter à la Facture";
            this.EnregistrerBtn.UseVisualStyleBackColor = true;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // VendeursListe
            // 
            this.VendeursListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendeursListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.VendeursListe.Location = new System.Drawing.Point(345, 416);
            this.VendeursListe.Name = "VendeursListe";
            this.VendeursListe.Size = new System.Drawing.Size(520, 150);
            this.VendeursListe.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Article";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantité";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Totale";
            this.Column5.Name = "Column5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = " Facture du client ";
            // 
            // StockTb
            // 
            this.StockTb.Location = new System.Drawing.Point(491, 67);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(100, 20);
            this.StockTb.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Prix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Article :";
            // 
            // QuanTb
            // 
            this.QuanTb.Location = new System.Drawing.Point(270, 71);
            this.QuanTb.Name = "QuanTb";
            this.QuanTb.Size = new System.Drawing.Size(100, 20);
            this.QuanTb.TabIndex = 34;
            // 
            // PrixTb
            // 
            this.PrixTb.Enabled = false;
            this.PrixTb.Location = new System.Drawing.Point(491, 24);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(100, 20);
            this.PrixTb.TabIndex = 33;
            // 
            // ArticleTb
            // 
            this.ArticleTb.Location = new System.Drawing.Point(270, 24);
            this.ArticleTb.Name = "ArticleTb";
            this.ArticleTb.Size = new System.Drawing.Size(100, 20);
            this.ArticleTb.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(29, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "Factures";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(29, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 36);
            this.button3.TabIndex = 48;
            this.button3.Text = "Vendeurs";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(29, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 47;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(29, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 36);
            this.button5.TabIndex = 46;
            this.button5.Text = "Articles";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ArticlesListe
            // 
            this.ArticlesListe.AutoGenerateColumns = false;
            this.ArticlesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticlesListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeArtDataGridViewTextBoxColumn,
            this.nomArtDataGridViewTextBoxColumn,
            this.prixArtDataGridViewTextBoxColumn,
            this.categArtDataGridViewTextBoxColumn,
            this.stockArtDataGridViewTextBoxColumn,
            this.expDateArtDataGridViewTextBoxColumn});
            this.ArticlesListe.DataSource = this.articlesTblBindingSource;
            this.ArticlesListe.Location = new System.Drawing.Point(209, 220);
            this.ArticlesListe.Name = "ArticlesListe";
            this.ArticlesListe.Size = new System.Drawing.Size(637, 150);
            this.ArticlesListe.TabIndex = 50;
            // 
            // codeArtDataGridViewTextBoxColumn
            // 
            this.codeArtDataGridViewTextBoxColumn.DataPropertyName = "CodeArt";
            this.codeArtDataGridViewTextBoxColumn.HeaderText = "CodeArt";
            this.codeArtDataGridViewTextBoxColumn.Name = "codeArtDataGridViewTextBoxColumn";
            this.codeArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomArtDataGridViewTextBoxColumn
            // 
            this.nomArtDataGridViewTextBoxColumn.DataPropertyName = "NomArt";
            this.nomArtDataGridViewTextBoxColumn.HeaderText = "NomArt";
            this.nomArtDataGridViewTextBoxColumn.Name = "nomArtDataGridViewTextBoxColumn";
            // 
            // prixArtDataGridViewTextBoxColumn
            // 
            this.prixArtDataGridViewTextBoxColumn.DataPropertyName = "PrixArt";
            this.prixArtDataGridViewTextBoxColumn.HeaderText = "PrixArt";
            this.prixArtDataGridViewTextBoxColumn.Name = "prixArtDataGridViewTextBoxColumn";
            // 
            // categArtDataGridViewTextBoxColumn
            // 
            this.categArtDataGridViewTextBoxColumn.DataPropertyName = "CategArt";
            this.categArtDataGridViewTextBoxColumn.HeaderText = "CategArt";
            this.categArtDataGridViewTextBoxColumn.Name = "categArtDataGridViewTextBoxColumn";
            // 
            // stockArtDataGridViewTextBoxColumn
            // 
            this.stockArtDataGridViewTextBoxColumn.DataPropertyName = "StockArt";
            this.stockArtDataGridViewTextBoxColumn.HeaderText = "StockArt";
            this.stockArtDataGridViewTextBoxColumn.Name = "stockArtDataGridViewTextBoxColumn";
            // 
            // expDateArtDataGridViewTextBoxColumn
            // 
            this.expDateArtDataGridViewTextBoxColumn.DataPropertyName = "ExpDateArt";
            this.expDateArtDataGridViewTextBoxColumn.HeaderText = "ExpDateArt";
            this.expDateArtDataGridViewTextBoxColumn.Name = "expDateArtDataGridViewTextBoxColumn";
            // 
            // articlesTblBindingSource
            // 
            this.articlesTblBindingSource.DataMember = "ArticlesTbl";
            this.articlesTblBindingSource.DataSource = this.superMarcheBDDataSet1;
            // 
            // superMarcheBDDataSet1
            // 
            this.superMarcheBDDataSet1.DataSetName = "SuperMarcheBDDataSet1";
            this.superMarcheBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articlesTblTableAdapter
            // 
            this.articlesTblTableAdapter.ClearBeforeFill = true;
            // 
            // NomTb
            // 
            this.NomTb.AutoSize = true;
            this.NomTb.Location = new System.Drawing.Point(690, 74);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(29, 13);
            this.NomTb.TabIndex = 51;
            this.NomTb.Text = "Nom";
            // 
            // PrixtTotalTbl
            // 
            this.PrixtTotalTbl.AutoSize = true;
            this.PrixtTotalTbl.Location = new System.Drawing.Point(488, 592);
            this.PrixtTotalTbl.Name = "PrixtTotalTbl";
            this.PrixtTotalTbl.Size = new System.Drawing.Size(31, 13);
            this.PrixtTotalTbl.TabIndex = 52;
            this.PrixtTotalTbl.Text = "Total";
            // 
            // Factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 650);
            this.Controls.Add(this.PrixtTotalTbl);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.ArticlesListe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DeconnexionBtn);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.RéniBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.VendeursListe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuanTb);
            this.Controls.Add(this.PrixTb);
            this.Controls.Add(this.ArticleTb);
            this.Name = "Factures";
            this.Text = "Factures";
            this.Load += new System.EventHandler(this.Factures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendeursListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeconnexionBtn;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button RéniBtn;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.DataGridView VendeursListe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuanTb;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.TextBox ArticleTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView ArticlesListe;
        private SuperMarcheBDDataSet1 superMarcheBDDataSet1;
        private System.Windows.Forms.BindingSource articlesTblBindingSource;
        private SuperMarcheBDDataSet1TableAdapters.ArticlesTblTableAdapter articlesTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDateArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label NomTb;
        private System.Windows.Forms.Label PrixtTotalTbl;
    }
}