namespace DesktopIHM
{
    partial class FicheClient
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
            this.nomFC = new System.Windows.Forms.Label();
            this.dateDeNaissanceFC = new System.Windows.Forms.Label();
            this.adresseFC = new System.Windows.Forms.Label();
            this.telephoneFC = new System.Windows.Forms.Label();
            this.emailFC = new System.Windows.Forms.Label();
            this.typeFC = new System.Windows.Forms.Label();
            this.montantFC = new System.Windows.Forms.Label();
            this.typePaiment = new System.Windows.Forms.TextBox();
            this.montantPaiment = new System.Windows.Forms.TextBox();
            this.heure = new System.Windows.Forms.TextBox();
            this.heureFC = new System.Windows.Forms.Label();
            this.jourFC = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.planningReservation = new System.Windows.Forms.GroupBox();
            this.planning = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prenomFC = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.adresseMail = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.dateNaissance = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.heureEffective = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.jour = new System.Windows.Forms.DateTimePicker();
            this.effectuerReservation = new System.Windows.Forms.GroupBox();
            this.enregistrementPaiment = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.planningReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planning)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.effectuerReservation.SuspendLayout();
            this.enregistrementPaiment.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomFC
            // 
            this.nomFC.AutoSize = true;
            this.nomFC.Location = new System.Drawing.Point(48, 29);
            this.nomFC.Name = "nomFC";
            this.nomFC.Size = new System.Drawing.Size(41, 13);
            this.nomFC.TabIndex = 0;
            this.nomFC.Text = "Nom  : ";
            // 
            // dateDeNaissanceFC
            // 
            this.dateDeNaissanceFC.AutoSize = true;
            this.dateDeNaissanceFC.Location = new System.Drawing.Point(42, 96);
            this.dateDeNaissanceFC.Name = "dateDeNaissanceFC";
            this.dateDeNaissanceFC.Size = new System.Drawing.Size(102, 13);
            this.dateDeNaissanceFC.TabIndex = 1;
            this.dateDeNaissanceFC.Text = "Date de naissance :";
            // 
            // adresseFC
            // 
            this.adresseFC.AutoSize = true;
            this.adresseFC.Location = new System.Drawing.Point(42, 122);
            this.adresseFC.Name = "adresseFC";
            this.adresseFC.Size = new System.Drawing.Size(51, 13);
            this.adresseFC.TabIndex = 2;
            this.adresseFC.Text = "Adresse :";
            // 
            // telephoneFC
            // 
            this.telephoneFC.AutoSize = true;
            this.telephoneFC.Location = new System.Drawing.Point(42, 147);
            this.telephoneFC.Name = "telephoneFC";
            this.telephoneFC.Size = new System.Drawing.Size(64, 13);
            this.telephoneFC.TabIndex = 3;
            this.telephoneFC.Text = "Téléphone :";
            // 
            // emailFC
            // 
            this.emailFC.AutoSize = true;
            this.emailFC.Location = new System.Drawing.Point(48, 189);
            this.emailFC.Name = "emailFC";
            this.emailFC.Size = new System.Drawing.Size(38, 13);
            this.emailFC.TabIndex = 4;
            this.emailFC.Text = "Email :";
            // 
            // typeFC
            // 
            this.typeFC.AutoSize = true;
            this.typeFC.Location = new System.Drawing.Point(152, 22);
            this.typeFC.Name = "typeFC";
            this.typeFC.Size = new System.Drawing.Size(37, 13);
            this.typeFC.TabIndex = 8;
            this.typeFC.Text = "Type :";
            this.typeFC.Click += new System.EventHandler(this.typeFC_Click);
            // 
            // montantFC
            // 
            this.montantFC.AutoSize = true;
            this.montantFC.Location = new System.Drawing.Point(321, 22);
            this.montantFC.Name = "montantFC";
            this.montantFC.Size = new System.Drawing.Size(52, 13);
            this.montantFC.TabIndex = 9;
            this.montantFC.Text = "Montant :";
            // 
            // typePaiment
            // 
            this.typePaiment.Location = new System.Drawing.Point(204, 19);
            this.typePaiment.Name = "typePaiment";
            this.typePaiment.Size = new System.Drawing.Size(104, 20);
            this.typePaiment.TabIndex = 10;
            this.typePaiment.TextChanged += new System.EventHandler(this.typePaiment_TextChanged);
            // 
            // montantPaiment
            // 
            this.montantPaiment.Location = new System.Drawing.Point(389, 19);
            this.montantPaiment.Name = "montantPaiment";
            this.montantPaiment.Size = new System.Drawing.Size(113, 20);
            this.montantPaiment.TabIndex = 11;
            // 
            // heure
            // 
            this.heure.Location = new System.Drawing.Point(59, 40);
            this.heure.Name = "heure";
            this.heure.Size = new System.Drawing.Size(147, 20);
            this.heure.TabIndex = 14;
            // 
            // heureFC
            // 
            this.heureFC.AutoSize = true;
            this.heureFC.Location = new System.Drawing.Point(11, 40);
            this.heureFC.Name = "heureFC";
            this.heureFC.Size = new System.Drawing.Size(42, 13);
            this.heureFC.TabIndex = 16;
            this.heureFC.Text = "Heure :";
            // 
            // jourFC
            // 
            this.jourFC.AutoSize = true;
            this.jourFC.Location = new System.Drawing.Point(243, 43);
            this.jourFC.Name = "jourFC";
            this.jourFC.Size = new System.Drawing.Size(33, 13);
            this.jourFC.TabIndex = 17;
            this.jourFC.Text = "Jour :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Générer un rapport PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(542, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "valider";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // planningReservation
            // 
            this.planningReservation.Controls.Add(this.planning);
            this.planningReservation.Location = new System.Drawing.Point(361, 82);
            this.planningReservation.Name = "planningReservation";
            this.planningReservation.Size = new System.Drawing.Size(335, 192);
            this.planningReservation.TabIndex = 20;
            this.planningReservation.TabStop = false;
            this.planningReservation.Text = "Planning de réservation";
            // 
            // planning
            // 
            this.planning.AllowUserToAddRows = false;
            this.planning.AllowUserToDeleteRows = false;
            this.planning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.planning.Location = new System.Drawing.Point(6, 19);
            this.planning.Name = "planning";
            this.planning.ReadOnly = true;
            this.planning.Size = new System.Drawing.Size(322, 169);
            this.planning.TabIndex = 0;
            this.planning.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planning_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Moniteur";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vehicule";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Horaire";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.prenomFC);
            this.groupBox2.Controls.Add(this.adresse);
            this.groupBox2.Controls.Add(this.adresseMail);
            this.groupBox2.Controls.Add(this.telephone);
            this.groupBox2.Controls.Add(this.dateNaissance);
            this.groupBox2.Controls.Add(this.prenom);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Controls.Add(this.emailFC);
            this.groupBox2.Controls.Add(this.telephoneFC);
            this.groupBox2.Controls.Add(this.adresseFC);
            this.groupBox2.Controls.Add(this.dateDeNaissanceFC);
            this.groupBox2.Controls.Add(this.nomFC);
            this.groupBox2.Location = new System.Drawing.Point(3, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 236);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations personnelles";
            // 
            // prenomFC
            // 
            this.prenomFC.AutoSize = true;
            this.prenomFC.Location = new System.Drawing.Point(42, 63);
            this.prenomFC.Name = "prenomFC";
            this.prenomFC.Size = new System.Drawing.Size(55, 13);
            this.prenomFC.TabIndex = 30;
            this.prenomFC.Text = "Prenom  : ";
            // 
            // adresse
            // 
            this.adresse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresse.Location = new System.Drawing.Point(152, 119);
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            this.adresse.Size = new System.Drawing.Size(150, 20);
            this.adresse.TabIndex = 29;
            // 
            // adresseMail
            // 
            this.adresseMail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresseMail.Location = new System.Drawing.Point(152, 186);
            this.adresseMail.Name = "adresseMail";
            this.adresseMail.ReadOnly = true;
            this.adresseMail.Size = new System.Drawing.Size(150, 20);
            this.adresseMail.TabIndex = 28;
            // 
            // telephone
            // 
            this.telephone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telephone.Location = new System.Drawing.Point(152, 147);
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Size = new System.Drawing.Size(150, 20);
            this.telephone.TabIndex = 27;
            // 
            // dateNaissance
            // 
            this.dateNaissance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateNaissance.Location = new System.Drawing.Point(153, 93);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.ReadOnly = true;
            this.dateNaissance.Size = new System.Drawing.Size(149, 20);
            this.dateNaissance.TabIndex = 26;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prenom.Location = new System.Drawing.Point(153, 60);
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Size = new System.Drawing.Size(149, 20);
            this.prenom.TabIndex = 25;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nom.Location = new System.Drawing.Point(153, 26);
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Size = new System.Drawing.Size(149, 20);
            this.nom.TabIndex = 24;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre d\'heures effectives   :";
            // 
            // heureEffective
            // 
            this.heureEffective.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heureEffective.Location = new System.Drawing.Point(521, 38);
            this.heureEffective.Name = "heureEffective";
            this.heureEffective.ReadOnly = true;
            this.heureEffective.Size = new System.Drawing.Size(121, 20);
            this.heureEffective.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(800, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(-2, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 24);
            this.button4.TabIndex = 26;
            this.button4.Text = "Acceuil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(800, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Déconnexion";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // jour
            // 
            this.jour.CustomFormat = "";
            this.jour.Location = new System.Drawing.Point(282, 41);
            this.jour.Name = "jour";
            this.jour.Size = new System.Drawing.Size(200, 20);
            this.jour.TabIndex = 28;
            // 
            // effectuerReservation
            // 
            this.effectuerReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.effectuerReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.effectuerReservation.Controls.Add(this.jour);
            this.effectuerReservation.Controls.Add(this.jourFC);
            this.effectuerReservation.Controls.Add(this.heureFC);
            this.effectuerReservation.Controls.Add(this.button1);
            this.effectuerReservation.Controls.Add(this.heure);
            this.effectuerReservation.Location = new System.Drawing.Point(3, 280);
            this.effectuerReservation.Name = "effectuerReservation";
            this.effectuerReservation.Size = new System.Drawing.Size(677, 72);
            this.effectuerReservation.TabIndex = 29;
            this.effectuerReservation.TabStop = false;
            this.effectuerReservation.Text = "Effectuer Réservation";
            // 
            // enregistrementPaiment
            // 
            this.enregistrementPaiment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enregistrementPaiment.Controls.Add(this.button3);
            this.enregistrementPaiment.Controls.Add(this.montantPaiment);
            this.enregistrementPaiment.Controls.Add(this.typePaiment);
            this.enregistrementPaiment.Controls.Add(this.montantFC);
            this.enregistrementPaiment.Controls.Add(this.typeFC);
            this.enregistrementPaiment.Location = new System.Drawing.Point(3, 358);
            this.enregistrementPaiment.Name = "enregistrementPaiment";
            this.enregistrementPaiment.Size = new System.Drawing.Size(677, 67);
            this.enregistrementPaiment.TabIndex = 30;
            this.enregistrementPaiment.TabStop = false;
            this.enregistrementPaiment.Text = "Enregistrement Paiment";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 444);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Précédent";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FicheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1234, 784);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.enregistrementPaiment);
            this.Controls.Add(this.effectuerReservation);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.heureEffective);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.planningReservation);
            this.Controls.Add(this.button2);
            this.Name = "FicheClient";
            this.Text = "Fiche Client";
            this.Load += new System.EventHandler(this.FicheClient_Load);
            this.planningReservation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planning)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.effectuerReservation.ResumeLayout(false);
            this.effectuerReservation.PerformLayout();
            this.enregistrementPaiment.ResumeLayout(false);
            this.enregistrementPaiment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomFC;
        private System.Windows.Forms.Label dateDeNaissanceFC;
        private System.Windows.Forms.Label adresseFC;
        private System.Windows.Forms.Label telephoneFC;
        private System.Windows.Forms.Label emailFC;
        private System.Windows.Forms.Label typeFC;
        private System.Windows.Forms.Label montantFC;
        private System.Windows.Forms.TextBox typePaiment;
        private System.Windows.Forms.TextBox montantPaiment;
        private System.Windows.Forms.TextBox heure;
        private System.Windows.Forms.Label heureFC;
        private System.Windows.Forms.Label jourFC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox planningReservation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adresseMail;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox dateNaissance;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox heureEffective;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView planning;
        private System.Windows.Forms.Label prenomFC;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker jour;
        private System.Windows.Forms.GroupBox effectuerReservation;
        private System.Windows.Forms.GroupBox enregistrementPaiment;
        private System.Windows.Forms.Button button6;
    }
}