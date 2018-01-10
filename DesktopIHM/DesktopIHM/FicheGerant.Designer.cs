namespace DesktopIHM
{
    partial class FicheGerant
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
            this.CreationGerant = new System.Windows.Forms.GroupBox();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.password = new System.Windows.Forms.TextBox();
            this.motDePasse = new System.Windows.Forms.Label();
            this.button_EnregisterClient = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adresseMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreationGerant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreationGerant
            // 
            this.CreationGerant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreationGerant.Controls.Add(this.dateNaissance);
            this.CreationGerant.Controls.Add(this.password);
            this.CreationGerant.Controls.Add(this.motDePasse);
            this.CreationGerant.Controls.Add(this.button_EnregisterClient);
            this.CreationGerant.Controls.Add(this.nom);
            this.CreationGerant.Controls.Add(this.label1);
            this.CreationGerant.Controls.Add(this.adresseMail);
            this.CreationGerant.Controls.Add(this.label2);
            this.CreationGerant.Controls.Add(this.telephone);
            this.CreationGerant.Controls.Add(this.label3);
            this.CreationGerant.Controls.Add(this.adresse);
            this.CreationGerant.Controls.Add(this.label4);
            this.CreationGerant.Controls.Add(this.label5);
            this.CreationGerant.Controls.Add(this.prenom);
            this.CreationGerant.Controls.Add(this.label6);
            this.CreationGerant.Location = new System.Drawing.Point(255, 66);
            this.CreationGerant.Name = "CreationGerant";
            this.CreationGerant.Size = new System.Drawing.Size(372, 379);
            this.CreationGerant.TabIndex = 23;
            this.CreationGerant.TabStop = false;
            this.CreationGerant.Text = "Création Gérant";
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(136, 113);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dateNaissance.TabIndex = 24;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(136, 264);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 20);
            this.password.TabIndex = 23;
            // 
            // motDePasse
            // 
            this.motDePasse.AutoSize = true;
            this.motDePasse.Location = new System.Drawing.Point(26, 267);
            this.motDePasse.Name = "motDePasse";
            this.motDePasse.Size = new System.Drawing.Size(71, 13);
            this.motDePasse.TabIndex = 22;
            this.motDePasse.Text = "Mot de passe";
            // 
            // button_EnregisterClient
            // 
            this.button_EnregisterClient.Location = new System.Drawing.Point(162, 340);
            this.button_EnregisterClient.Name = "button_EnregisterClient";
            this.button_EnregisterClient.Size = new System.Drawing.Size(101, 22);
            this.button_EnregisterClient.TabIndex = 21;
            this.button_EnregisterClient.Text = "Enregistrer ";
            this.button_EnregisterClient.UseVisualStyleBackColor = true;
            this.button_EnregisterClient.Click += new System.EventHandler(this.button_EnregisterClient_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(136, 34);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(200, 20);
            this.nom.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // adresseMail
            // 
            this.adresseMail.Location = new System.Drawing.Point(136, 224);
            this.adresseMail.Name = "adresseMail";
            this.adresseMail.Size = new System.Drawing.Size(200, 20);
            this.adresseMail.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(136, 182);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(200, 20);
            this.telephone.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de naissance";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(136, 148);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(200, 20);
            this.adresse.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Téléphone";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(136, 72);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(200, 20);
            this.prenom.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 20);
            this.button4.TabIndex = 29;
            this.button4.Text = "Acceuil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(750, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FicheGerant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CreationGerant);
            this.Name = "FicheGerant";
            this.Text = "Fiche Gérant";
            this.CreationGerant.ResumeLayout(false);
            this.CreationGerant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreationGerant;
        private System.Windows.Forms.Button button_EnregisterClient;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresseMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label motDePasse;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}