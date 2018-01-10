namespace DesktopIHM
{
    partial class GestionClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.adresseMail = new System.Windows.Forms.TextBox();
            this.buttonPacourirPhoto = new System.Windows.Forms.Button();
            this.groupBox_CreationClient = new System.Windows.Forms.GroupBox();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.button_EnregisterClient = new System.Windows.Forms.Button();
            this.groupBoxRechercheClient = new System.Windows.Forms.GroupBox();
            this.resultatRecherche = new System.Windows.Forms.DataGridView();
            this.NomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Prnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RechercherClient = new System.Windows.Forms.Button();
            this.prenomRecherche = new System.Windows.Forms.TextBox();
            this.nomRecherche = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox_CreationClient.SuspendLayout();
            this.groupBoxRechercheClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultatRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Téléphone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Photo d\'identité :";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(136, 34);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(210, 20);
            this.nom.TabIndex = 14;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(136, 72);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(210, 20);
            this.prenom.TabIndex = 15;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(136, 148);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(210, 20);
            this.adresse.TabIndex = 17;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(136, 182);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(210, 20);
            this.telephone.TabIndex = 18;
            // 
            // adresseMail
            // 
            this.adresseMail.Location = new System.Drawing.Point(136, 224);
            this.adresseMail.Name = "adresseMail";
            this.adresseMail.Size = new System.Drawing.Size(210, 20);
            this.adresseMail.TabIndex = 19;
            this.adresseMail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // buttonPacourirPhoto
            // 
            this.buttonPacourirPhoto.Location = new System.Drawing.Point(168, 265);
            this.buttonPacourirPhoto.Name = "buttonPacourirPhoto";
            this.buttonPacourirPhoto.Size = new System.Drawing.Size(124, 22);
            this.buttonPacourirPhoto.TabIndex = 20;
            this.buttonPacourirPhoto.Text = "Parcourir";
            this.buttonPacourirPhoto.UseVisualStyleBackColor = true;
            this.buttonPacourirPhoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_CreationClient
            // 
            this.groupBox_CreationClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_CreationClient.Controls.Add(this.dateNaissance);
            this.groupBox_CreationClient.Controls.Add(this.button_EnregisterClient);
            this.groupBox_CreationClient.Controls.Add(this.nom);
            this.groupBox_CreationClient.Controls.Add(this.buttonPacourirPhoto);
            this.groupBox_CreationClient.Controls.Add(this.label1);
            this.groupBox_CreationClient.Controls.Add(this.adresseMail);
            this.groupBox_CreationClient.Controls.Add(this.label2);
            this.groupBox_CreationClient.Controls.Add(this.telephone);
            this.groupBox_CreationClient.Controls.Add(this.label3);
            this.groupBox_CreationClient.Controls.Add(this.adresse);
            this.groupBox_CreationClient.Controls.Add(this.label4);
            this.groupBox_CreationClient.Controls.Add(this.label5);
            this.groupBox_CreationClient.Controls.Add(this.prenom);
            this.groupBox_CreationClient.Controls.Add(this.label6);
            this.groupBox_CreationClient.Controls.Add(this.label7);
            this.groupBox_CreationClient.Location = new System.Drawing.Point(12, 73);
            this.groupBox_CreationClient.Name = "groupBox_CreationClient";
            this.groupBox_CreationClient.Size = new System.Drawing.Size(378, 372);
            this.groupBox_CreationClient.TabIndex = 21;
            this.groupBox_CreationClient.TabStop = false;
            this.groupBox_CreationClient.Text = "Création un client";
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(134, 113);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(212, 20);
            this.dateNaissance.TabIndex = 23;
            this.dateNaissance.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_EnregisterClient
            // 
            this.button_EnregisterClient.Location = new System.Drawing.Point(236, 331);
            this.button_EnregisterClient.Name = "button_EnregisterClient";
            this.button_EnregisterClient.Size = new System.Drawing.Size(110, 22);
            this.button_EnregisterClient.TabIndex = 21;
            this.button_EnregisterClient.Text = "Enregistrer ";
            this.button_EnregisterClient.UseVisualStyleBackColor = true;
            this.button_EnregisterClient.Click += new System.EventHandler(this.button_EnregisterClient_Click);
            // 
            // groupBoxRechercheClient
            // 
            this.groupBoxRechercheClient.Controls.Add(this.resultatRecherche);
            this.groupBoxRechercheClient.Controls.Add(this.RechercherClient);
            this.groupBoxRechercheClient.Controls.Add(this.prenomRecherche);
            this.groupBoxRechercheClient.Controls.Add(this.nomRecherche);
            this.groupBoxRechercheClient.Controls.Add(this.label9);
            this.groupBoxRechercheClient.Controls.Add(this.label8);
            this.groupBoxRechercheClient.Location = new System.Drawing.Point(396, 73);
            this.groupBoxRechercheClient.Name = "groupBoxRechercheClient";
            this.groupBoxRechercheClient.Size = new System.Drawing.Size(529, 372);
            this.groupBoxRechercheClient.TabIndex = 22;
            this.groupBoxRechercheClient.TabStop = false;
            this.groupBoxRechercheClient.Text = "Resultat Recherche";
            this.groupBoxRechercheClient.Enter += new System.EventHandler(this.groupBoxRechercheClient_Enter);
            // 
            // resultatRecherche
            // 
            this.resultatRecherche.AllowUserToAddRows = false;
            this.resultatRecherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCol,
            this.Column1Prnom,
            this.Column1Telephone,
            this.Column1Email,
            this.Profil});
            this.resultatRecherche.Location = new System.Drawing.Point(6, 58);
            this.resultatRecherche.Name = "resultatRecherche";
            this.resultatRecherche.ReadOnly = true;
            this.resultatRecherche.Size = new System.Drawing.Size(544, 319);
            this.resultatRecherche.TabIndex = 24;
            this.resultatRecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomCol
            // 
            this.NomCol.HeaderText = "Nom";
            this.NomCol.Name = "NomCol";
            this.NomCol.ReadOnly = true;
            // 
            // Column1Prnom
            // 
            this.Column1Prnom.HeaderText = "Prenom";
            this.Column1Prnom.Name = "Column1Prnom";
            this.Column1Prnom.ReadOnly = true;
            // 
            // Column1Telephone
            // 
            this.Column1Telephone.HeaderText = "Telephone";
            this.Column1Telephone.Name = "Column1Telephone";
            this.Column1Telephone.ReadOnly = true;
            // 
            // Column1Email
            // 
            this.Column1Email.HeaderText = "Email";
            this.Column1Email.Name = "Column1Email";
            this.Column1Email.ReadOnly = true;
            // 
            // Profil
            // 
            this.Profil.HeaderText = "Profil";
            this.Profil.Name = "Profil";
            this.Profil.ReadOnly = true;
            this.Profil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Profil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Profil.Text = "Voir Profil";
            this.Profil.UseColumnTextForButtonValue = true;
            // 
            // RechercherClient
            // 
            this.RechercherClient.Location = new System.Drawing.Point(415, 30);
            this.RechercherClient.Name = "RechercherClient";
            this.RechercherClient.Size = new System.Drawing.Size(85, 22);
            this.RechercherClient.TabIndex = 23;
            this.RechercherClient.Text = "Rechercher ";
            this.RechercherClient.UseVisualStyleBackColor = true;
            this.RechercherClient.Click += new System.EventHandler(this.RechercherClient_Click);
            // 
            // prenomRecherche
            // 
            this.prenomRecherche.Location = new System.Drawing.Point(282, 30);
            this.prenomRecherche.Name = "prenomRecherche";
            this.prenomRecherche.Size = new System.Drawing.Size(124, 20);
            this.prenomRecherche.TabIndex = 16;
            // 
            // nomRecherche
            // 
            this.nomRecherche.Location = new System.Drawing.Point(79, 30);
            this.nomRecherche.Name = "nomRecherche";
            this.nomRecherche.Size = new System.Drawing.Size(124, 20);
            this.nomRecherche.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Prénom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nom :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 21);
            this.button2.TabIndex = 24;
            this.button2.Text = "Acceuil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 31;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Précédent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(947, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxRechercheClient);
            this.Controls.Add(this.groupBox_CreationClient);
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            this.Load += new System.EventHandler(this.EnregistrerClient_Load);
            this.groupBox_CreationClient.ResumeLayout(false);
            this.groupBox_CreationClient.PerformLayout();
            this.groupBoxRechercheClient.ResumeLayout(false);
            this.groupBoxRechercheClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultatRecherche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox adresseMail;
        private System.Windows.Forms.Button buttonPacourirPhoto;
        private System.Windows.Forms.GroupBox groupBox_CreationClient;
        private System.Windows.Forms.Button button_EnregisterClient;
        private System.Windows.Forms.GroupBox groupBoxRechercheClient;
        private System.Windows.Forms.DataGridView resultatRecherche;
        private System.Windows.Forms.Button RechercherClient;
        private System.Windows.Forms.TextBox prenomRecherche;
        private System.Windows.Forms.TextBox nomRecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Prnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Email;
        private System.Windows.Forms.DataGridViewButtonColumn Profil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Button button3;
    }
}