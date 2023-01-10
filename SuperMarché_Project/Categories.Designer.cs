namespace SuperMarché_Project
{
    partial class Categories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoriesListe = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.RemTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomCatTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeconnexionBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.DeconnexionBtn);
            this.panel1.Location = new System.Drawing.Point(-11, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 575);
            this.panel1.TabIndex = 35;
            // 
            // CategoriesListe
            // 
            this.CategoriesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesListe.Location = new System.Drawing.Point(191, 279);
            this.CategoriesListe.Name = "CategoriesListe";
            this.CategoriesListe.Size = new System.Drawing.Size(809, 233);
            this.CategoriesListe.TabIndex = 34;
            this.CategoriesListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesListe_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(528, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 36);
            this.button4.TabIndex = 33;
            this.button4.Text = "Actualiser";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(375, 251);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 21);
            this.comboBox2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Liste des categories";
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupprimerBtn.Location = new System.Drawing.Point(548, 135);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(125, 36);
            this.SupprimerBtn.TabIndex = 30;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EnregistrerBtn.Location = new System.Drawing.Point(418, 135);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(124, 36);
            this.EnregistrerBtn.TabIndex = 29;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = false;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifierBtn.Location = new System.Drawing.Point(284, 135);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(128, 36);
            this.ModifierBtn.TabIndex = 28;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // RemTb
            // 
            this.RemTb.Location = new System.Drawing.Point(375, 101);
            this.RemTb.Name = "RemTb";
            this.RemTb.Size = new System.Drawing.Size(138, 20);
            this.RemTb.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Remarque";
            // 
            // NomCatTb
            // 
            this.NomCatTb.Location = new System.Drawing.Point(221, 101);
            this.NomCatTb.Name = "NomCatTb";
            this.NomCatTb.Size = new System.Drawing.Size(138, 20);
            this.NomCatTb.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom de categorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion des Categories";
            // 
            // DeconnexionBtn
            // 
            this.DeconnexionBtn.Location = new System.Drawing.Point(0, 414);
            this.DeconnexionBtn.Name = "DeconnexionBtn";
            this.DeconnexionBtn.Size = new System.Drawing.Size(174, 23);
            this.DeconnexionBtn.TabIndex = 32;
            this.DeconnexionBtn.Text = "Se déconnecter";
            this.DeconnexionBtn.UseVisualStyleBackColor = true;
            this.DeconnexionBtn.Click += new System.EventHandler(this.DeconnexionBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(23, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "Factures";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(23, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 36);
            this.button3.TabIndex = 39;
            this.button3.Text = "Vendeurs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(23, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 38;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(23, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 36);
            this.button5.TabIndex = 37;
            this.button5.Text = "Articles";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CategoriesListe);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.RemTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomCatTb);
            this.Controls.Add(this.label2);
            this.Name = "Categories";
            this.Text = "Categories";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CategoriesListe;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.TextBox RemTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomCatTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeconnexionBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}