
namespace SuperMarché_Project
{
    partial class Connexion
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
            this.ConnexionBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MdpTB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PseuVendeurTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnexionBtn
            // 
            this.ConnexionBtn.Location = new System.Drawing.Point(301, 294);
            this.ConnexionBtn.Name = "ConnexionBtn";
            this.ConnexionBtn.Size = new System.Drawing.Size(198, 23);
            this.ConnexionBtn.TabIndex = 9;
            this.ConnexionBtn.Text = "Se Connecter";
            this.ConnexionBtn.UseVisualStyleBackColor = true;
            this.ConnexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // MdpTB
            // 
            this.MdpTB.AutoSize = true;
            this.MdpTB.Location = new System.Drawing.Point(361, 214);
            this.MdpTB.Name = "MdpTB";
            this.MdpTB.Size = new System.Drawing.Size(72, 13);
            this.MdpTB.TabIndex = 7;
            this.MdpTB.Text = "Mot de Passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // PseuVendeurTB
            // 
            this.PseuVendeurTB.AutoSize = true;
            this.PseuVendeurTB.Location = new System.Drawing.Point(347, 134);
            this.PseuVendeurTB.Name = "PseuVendeurTB";
            this.PseuVendeurTB.Size = new System.Drawing.Size(101, 13);
            this.PseuVendeurTB.TabIndex = 5;
            this.PseuVendeurTB.Text = "Pseudo du Vendeur";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnexionBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MdpTB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PseuVendeurTB);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnexionBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label MdpTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PseuVendeurTB;
    }
}