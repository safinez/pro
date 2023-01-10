
namespace SuperMarché_Project
{
    partial class Vendeurs
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
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.VendeursListe = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.AdresseTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PeudoTb = new System.Windows.Forms.TextBox();
            this.MotDePasseTb = new System.Windows.Forms.TextBox();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.superMarcheBDDataSet = new SuperMarché_Project.SuperMarcheBDDataSet();
            this.vendeurTBlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendeurTBlTableAdapter = new SuperMarché_Project.SuperMarcheBDDataSetTableAdapters.VendeurTBlTableAdapter();
            this.vendCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendPseudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VendeursListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeurTBlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeconnexionBtn
            // 
            this.DeconnexionBtn.Location = new System.Drawing.Point(602, 24);
            this.DeconnexionBtn.Name = "DeconnexionBtn";
            this.DeconnexionBtn.Size = new System.Drawing.Size(174, 23);
            this.DeconnexionBtn.TabIndex = 31;
            this.DeconnexionBtn.Text = "Se déconnecter";
            this.DeconnexionBtn.UseVisualStyleBackColor = true;
            this.DeconnexionBtn.Click += new System.EventHandler(this.DeconnexionBtn_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(266, 236);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(100, 20);
            this.PhoneTb.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone :";
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.Location = new System.Drawing.Point(484, 306);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(75, 23);
            this.SupprimerBtn.TabIndex = 28;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = true;
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Location = new System.Drawing.Point(328, 306);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifierBtn.TabIndex = 27;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.Location = new System.Drawing.Point(185, 306);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(75, 23);
            this.EnregistrerBtn.TabIndex = 26;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = true;
            this.EnregistrerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // VendeursListe
            // 
            this.VendeursListe.AutoGenerateColumns = false;
            this.VendeursListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendeursListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendCodeDataGridViewTextBoxColumn,
            this.VendTB,
            this.vendPseudoDataGridViewTextBoxColumn,
            this.vendPassDataGridViewTextBoxColumn,
            this.vendPhoneDataGridViewTextBoxColumn,
            this.vendAddDataGridViewTextBoxColumn});
            this.VendeursListe.DataSource = this.vendeurTBlBindingSource;
            this.VendeursListe.Location = new System.Drawing.Point(389, 116);
            this.VendeursListe.Name = "VendeursListe";
            this.VendeursListe.Size = new System.Drawing.Size(533, 150);
            this.VendeursListe.TabIndex = 25;
            this.VendeursListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendeursListe_CellContentClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Liste des Vendeurs :";
            // 
            // AdresseTb
            // 
            this.AdresseTb.Location = new System.Drawing.Point(266, 202);
            this.AdresseTb.Name = "AdresseTb";
            this.AdresseTb.Size = new System.Drawing.Size(100, 20);
            this.AdresseTb.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mot de Passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pseudo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom du Vendeur :";
            // 
            // PeudoTb
            // 
            this.PeudoTb.Location = new System.Drawing.Point(266, 116);
            this.PeudoTb.Name = "PeudoTb";
            this.PeudoTb.Size = new System.Drawing.Size(100, 20);
            this.PeudoTb.TabIndex = 18;
            // 
            // MotDePasseTb
            // 
            this.MotDePasseTb.Location = new System.Drawing.Point(266, 159);
            this.MotDePasseTb.Name = "MotDePasseTb";
            this.MotDePasseTb.Size = new System.Drawing.Size(100, 20);
            this.MotDePasseTb.TabIndex = 17;
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(266, 69);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(100, 20);
            this.NomTb.TabIndex = 16;
            this.NomTb.TextChanged += new System.EventHandler(this.NomTb_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "Factures";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(12, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 36);
            this.button3.TabIndex = 39;
            this.button3.Text = "Vendeurs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(12, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 38;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(12, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 36);
            this.button5.TabIndex = 37;
            this.button5.Text = "Articles";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // superMarcheBDDataSet
            // 
            this.superMarcheBDDataSet.DataSetName = "SuperMarcheBDDataSet";
            this.superMarcheBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendeurTBlBindingSource
            // 
            this.vendeurTBlBindingSource.DataMember = "VendeurTBl";
            this.vendeurTBlBindingSource.DataSource = this.superMarcheBDDataSet;
            // 
            // vendeurTBlTableAdapter
            // 
            this.vendeurTBlTableAdapter.ClearBeforeFill = true;
            // 
            // vendCodeDataGridViewTextBoxColumn
            // 
            this.vendCodeDataGridViewTextBoxColumn.DataPropertyName = "VendCode";
            this.vendCodeDataGridViewTextBoxColumn.HeaderText = "VendCode";
            this.vendCodeDataGridViewTextBoxColumn.Name = "vendCodeDataGridViewTextBoxColumn";
            this.vendCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VendTB
            // 
            this.VendTB.DataPropertyName = "VendNom";
            this.VendTB.HeaderText = "VendNom";
            this.VendTB.Name = "VendTB";
            // 
            // vendPseudoDataGridViewTextBoxColumn
            // 
            this.vendPseudoDataGridViewTextBoxColumn.DataPropertyName = "VendPseudo";
            this.vendPseudoDataGridViewTextBoxColumn.HeaderText = "VendPseudo";
            this.vendPseudoDataGridViewTextBoxColumn.Name = "vendPseudoDataGridViewTextBoxColumn";
            // 
            // vendPassDataGridViewTextBoxColumn
            // 
            this.vendPassDataGridViewTextBoxColumn.DataPropertyName = "VendPass";
            this.vendPassDataGridViewTextBoxColumn.HeaderText = "VendPass";
            this.vendPassDataGridViewTextBoxColumn.Name = "vendPassDataGridViewTextBoxColumn";
            // 
            // vendPhoneDataGridViewTextBoxColumn
            // 
            this.vendPhoneDataGridViewTextBoxColumn.DataPropertyName = "VendPhone";
            this.vendPhoneDataGridViewTextBoxColumn.HeaderText = "VendPhone";
            this.vendPhoneDataGridViewTextBoxColumn.Name = "vendPhoneDataGridViewTextBoxColumn";
            // 
            // vendAddDataGridViewTextBoxColumn
            // 
            this.vendAddDataGridViewTextBoxColumn.DataPropertyName = "VendAdd";
            this.vendAddDataGridViewTextBoxColumn.HeaderText = "VendAdd";
            this.vendAddDataGridViewTextBoxColumn.Name = "vendAddDataGridViewTextBoxColumn";
            // 
            // Vendeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeconnexionBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.VendeursListe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdresseTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeudoTb);
            this.Controls.Add(this.MotDePasseTb);
            this.Controls.Add(this.NomTb);
            this.Name = "Vendeurs";
            this.Text = "Vendeurs";
            this.Load += new System.EventHandler(this.Vendeurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendeursListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeurTBlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeconnexionBtn;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.DataGridView VendeursListe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdresseTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PeudoTb;
        private System.Windows.Forms.TextBox MotDePasseTb;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private SuperMarcheBDDataSet superMarcheBDDataSet;
        private System.Windows.Forms.BindingSource vendeurTBlBindingSource;
        private SuperMarcheBDDataSetTableAdapters.VendeurTBlTableAdapter vendeurTBlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendPseudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendAddDataGridViewTextBoxColumn;
    }
}