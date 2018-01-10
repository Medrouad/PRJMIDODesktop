namespace DesktopIHM
{
    partial class GestionSalarie
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
            this.groupBox_CreationSalarie = new System.Windows.Forms.GroupBox();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.button_EnregisterClient = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.buttonPacourirPhoto = new System.Windows.Forms.Button();
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
            this.label7 = new System.Windows.Forms.Label();
            this.resultatRecherche = new System.Windows.Forms.GroupBox();
            this.resultatRechercheMoniteur = new System.Windows.Forms.DataGridView();
            this.nomResultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomResultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneResultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseMailResultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilResultat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RechercherClient = new System.Windows.Forms.Button();
            this.prenomRecherche = new System.Windows.Forms.TextBox();
            this.nomRecherche = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_CreationSalarie.SuspendLayout();
            this.resultatRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultatRechercheMoniteur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_CreationSalarie
            // 
            this.groupBox_CreationSalarie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_CreationSalarie.Controls.Add(this.dateNaissance);
            this.groupBox_CreationSalarie.Controls.Add(this.button_EnregisterClient);
            this.groupBox_CreationSalarie.Controls.Add(this.nom);
            this.groupBox_CreationSalarie.Controls.Add(this.buttonPacourirPhoto);
            this.groupBox_CreationSalarie.Controls.Add(this.label1);
            this.groupBox_CreationSalarie.Controls.Add(this.adresseMail);
            this.groupBox_CreationSalarie.Controls.Add(this.label2);
            this.groupBox_CreationSalarie.Controls.Add(this.telephone);
            this.groupBox_CreationSalarie.Controls.Add(this.label3);
            this.groupBox_CreationSalarie.Controls.Add(this.adresse);
            this.groupBox_CreationSalarie.Controls.Add(this.label4);
            this.groupBox_CreationSalarie.Controls.Add(this.label5);
            this.groupBox_CreationSalarie.Controls.Add(this.prenom);
            this.groupBox_CreationSalarie.Controls.Add(this.label6);
            this.groupBox_CreationSalarie.Controls.Add(this.label7);
            this.groupBox_CreationSalarie.Location = new System.Drawing.Point(12, 58);
            this.groupBox_CreationSalarie.Name = "groupBox_CreationSalarie";
            this.groupBox_CreationSalarie.Size = new System.Drawing.Size(287, 393);
            this.groupBox_CreationSalarie.TabIndex = 22;
            this.groupBox_CreationSalarie.TabStop = false;
            this.groupBox_CreationSalarie.Text = "Création Salarié";
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(120, 107);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(161, 20);
            this.dateNaissance.TabIndex = 33;
            this.dateNaissance.ValueChanged += new System.EventHandler(this.dateDeNaissance_ValueChanged);
            // 
            // button_EnregisterClient
            // 
            this.button_EnregisterClient.Location = new System.Drawing.Point(187, 353);
            this.button_EnregisterClient.Name = "button_EnregisterClient";
            this.button_EnregisterClient.Size = new System.Drawing.Size(94, 22);
            this.button_EnregisterClient.TabIndex = 21;
            this.button_EnregisterClient.Text = "Enregistrer ";
            this.button_EnregisterClient.UseVisualStyleBackColor = true;
            this.button_EnregisterClient.Click += new System.EventHandler(this.button_EnregisterClient_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(120, 34);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(161, 20);
            this.nom.TabIndex = 14;
            // 
            // buttonPacourirPhoto
            // 
            this.buttonPacourirPhoto.Location = new System.Drawing.Point(148, 260);
            this.buttonPacourirPhoto.Name = "buttonPacourirPhoto";
            this.buttonPacourirPhoto.Size = new System.Drawing.Size(104, 22);
            this.buttonPacourirPhoto.TabIndex = 20;
            this.buttonPacourirPhoto.Text = "Parcourir";
            this.buttonPacourirPhoto.UseVisualStyleBackColor = true;
            this.buttonPacourirPhoto.Click += new System.EventHandler(this.buttonPacourirPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // adresseMail
            // 
            this.adresseMail.Location = new System.Drawing.Point(120, 224);
            this.adresseMail.Name = "adresseMail";
            this.adresseMail.Size = new System.Drawing.Size(161, 20);
            this.adresseMail.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(120, 182);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(161, 20);
            this.telephone.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de naissance";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(120, 148);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(161, 20);
            this.adresse.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Téléphone";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(120, 72);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(161, 20);
            this.prenom.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phto d\'identité";
            // 
            // resultatRecherche
            // 
            this.resultatRecherche.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultatRecherche.Controls.Add(this.resultatRechercheMoniteur);
            this.resultatRecherche.Controls.Add(this.RechercherClient);
            this.resultatRecherche.Controls.Add(this.prenomRecherche);
            this.resultatRecherche.Controls.Add(this.nomRecherche);
            this.resultatRecherche.Controls.Add(this.label9);
            this.resultatRecherche.Controls.Add(this.label8);
            this.resultatRecherche.Location = new System.Drawing.Point(316, 58);
            this.resultatRecherche.Name = "resultatRecherche";
            this.resultatRecherche.Size = new System.Drawing.Size(592, 393);
            this.resultatRecherche.TabIndex = 23;
            this.resultatRecherche.TabStop = false;
            this.resultatRecherche.Text = "Resultat Recherche";
            // 
            // resultatRechercheMoniteur
            // 
            this.resultatRechercheMoniteur.AllowUserToAddRows = false;
            this.resultatRechercheMoniteur.AllowUserToDeleteRows = false;
            this.resultatRechercheMoniteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultatRechercheMoniteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomResultat,
            this.prenomResultat,
            this.telephoneResultat,
            this.adresseMailResultat,
            this.profilResultat});
            this.resultatRechercheMoniteur.Location = new System.Drawing.Point(0, 72);
            this.resultatRechercheMoniteur.Name = "resultatRechercheMoniteur";
            this.resultatRechercheMoniteur.ReadOnly = true;
            this.resultatRechercheMoniteur.Size = new System.Drawing.Size(544, 315);
            this.resultatRechercheMoniteur.TabIndex = 24;
            this.resultatRechercheMoniteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultatRechercheMoniteur_CellContentClick);
            // 
            // nomResultat
            // 
            this.nomResultat.HeaderText = "Nom";
            this.nomResultat.Name = "nomResultat";
            this.nomResultat.ReadOnly = true;
            // 
            // prenomResultat
            // 
            this.prenomResultat.HeaderText = "Prenom";
            this.prenomResultat.Name = "prenomResultat";
            this.prenomResultat.ReadOnly = true;
            // 
            // telephoneResultat
            // 
            this.telephoneResultat.HeaderText = "Telephone";
            this.telephoneResultat.Name = "telephoneResultat";
            this.telephoneResultat.ReadOnly = true;
            // 
            // adresseMailResultat
            // 
            this.adresseMailResultat.HeaderText = "Email";
            this.adresseMailResultat.Name = "adresseMailResultat";
            this.adresseMailResultat.ReadOnly = true;
            // 
            // profilResultat
            // 
            this.profilResultat.HeaderText = "Profil";
            this.profilResultat.Name = "profilResultat";
            this.profilResultat.ReadOnly = true;
            this.profilResultat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.profilResultat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.profilResultat.Text = "Voir Profil";
            this.profilResultat.UseColumnTextForButtonValue = true;
            // 
            // RechercherClient
            // 
            this.RechercherClient.Location = new System.Drawing.Point(415, 30);
            this.RechercherClient.Name = "RechercherClient";
            this.RechercherClient.Size = new System.Drawing.Size(110, 22);
            this.RechercherClient.TabIndex = 23;
            this.RechercherClient.Text = "resultatRecherche ";
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
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 21);
            this.button4.TabIndex = 30;
            this.button4.Text = "Acceuil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(821, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 32;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 22);
            this.button2.TabIndex = 33;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1033, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.resultatRecherche);
            this.Controls.Add(this.groupBox_CreationSalarie);
            this.Name = "GestionSalarie";
            this.Text = "GestionSalarie";
            this.Load += new System.EventHandler(this.GestionSalarie_Load);
            this.groupBox_CreationSalarie.ResumeLayout(false);
            this.groupBox_CreationSalarie.PerformLayout();
            this.resultatRecherche.ResumeLayout(false);
            this.resultatRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultatRechercheMoniteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_CreationSalarie;
        private System.Windows.Forms.Button button_EnregisterClient;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button buttonPacourirPhoto;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox resultatRecherche;
        private System.Windows.Forms.DataGridView resultatRechercheMoniteur;
        private System.Windows.Forms.Button RechercherClient;
        private System.Windows.Forms.TextBox prenomRecherche;
        private System.Windows.Forms.TextBox nomRecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomResultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomResultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneResultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMailResultat;
        private System.Windows.Forms.DataGridViewButtonColumn profilResultat;
        private System.Windows.Forms.Button button2;
    }
}