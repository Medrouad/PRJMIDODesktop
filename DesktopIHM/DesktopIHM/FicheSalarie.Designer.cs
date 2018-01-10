namespace DesktopIHM
{
    partial class FicheSalarie
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.adresseMail = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.dateNaissance = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.maillabel = new System.Windows.Forms.Label();
            this.telephonelabel = new System.Windows.Forms.Label();
            this.adresselabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agenda = new System.Windows.Forms.DataGridView();
            this.Column1heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Controls.Add(this.adresseMail);
            this.groupBox2.Controls.Add(this.telephone);
            this.groupBox2.Controls.Add(this.adresse);
            this.groupBox2.Controls.Add(this.dateNaissance);
            this.groupBox2.Controls.Add(this.prenom);
            this.groupBox2.Controls.Add(this.maillabel);
            this.groupBox2.Controls.Add(this.telephonelabel);
            this.groupBox2.Controls.Add(this.adresselabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 303);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations personnelles";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prénom : ";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(150, 51);
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Size = new System.Drawing.Size(148, 20);
            this.nom.TabIndex = 10;
            // 
            // adresseMail
            // 
            this.adresseMail.Location = new System.Drawing.Point(150, 216);
            this.adresseMail.Name = "adresseMail";
            this.adresseMail.ReadOnly = true;
            this.adresseMail.Size = new System.Drawing.Size(148, 20);
            this.adresseMail.TabIndex = 9;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(150, 180);
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Size = new System.Drawing.Size(148, 20);
            this.telephone.TabIndex = 8;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(150, 150);
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            this.adresse.Size = new System.Drawing.Size(148, 20);
            this.adresse.TabIndex = 7;
            this.adresse.TextChanged += new System.EventHandler(this.adresse_TextChanged);
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(150, 115);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.ReadOnly = true;
            this.dateNaissance.Size = new System.Drawing.Size(148, 20);
            this.dateNaissance.TabIndex = 6;
            this.dateNaissance.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(150, 83);
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Size = new System.Drawing.Size(148, 20);
            this.prenom.TabIndex = 5;
            this.prenom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maillabel
            // 
            this.maillabel.AutoSize = true;
            this.maillabel.Location = new System.Drawing.Point(31, 219);
            this.maillabel.Name = "maillabel";
            this.maillabel.Size = new System.Drawing.Size(38, 13);
            this.maillabel.TabIndex = 4;
            this.maillabel.Text = "Email :";
            // 
            // telephonelabel
            // 
            this.telephonelabel.AutoSize = true;
            this.telephonelabel.Location = new System.Drawing.Point(31, 183);
            this.telephonelabel.Name = "telephonelabel";
            this.telephonelabel.Size = new System.Drawing.Size(64, 13);
            this.telephonelabel.TabIndex = 3;
            this.telephonelabel.Text = "Téléphone :";
            // 
            // adresselabel
            // 
            this.adresselabel.AutoSize = true;
            this.adresselabel.Location = new System.Drawing.Point(31, 150);
            this.adresselabel.Name = "adresselabel";
            this.adresselabel.Size = new System.Drawing.Size(51, 13);
            this.adresselabel.TabIndex = 2;
            this.adresselabel.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Naissance :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.agenda);
            this.groupBox1.Location = new System.Drawing.Point(362, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 313);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agenda";
            // 
            // agenda
            // 
            this.agenda.AllowUserToAddRows = false;
            this.agenda.AllowUserToDeleteRows = false;
            this.agenda.AllowUserToOrderColumns = true;
            this.agenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1heure,
            this.Column1Jour,
            this.Column1});
            this.agenda.Location = new System.Drawing.Point(13, 26);
            this.agenda.Name = "agenda";
            this.agenda.ReadOnly = true;
            this.agenda.Size = new System.Drawing.Size(342, 281);
            this.agenda.TabIndex = 0;
            // 
            // Column1heure
            // 
            this.Column1heure.HeaderText = "heure";
            this.Column1heure.Name = "Column1heure";
            this.Column1heure.ReadOnly = true;
            // 
            // Column1Jour
            // 
            this.Column1Jour.HeaderText = "jour";
            this.Column1Jour.Name = "Column1Jour";
            this.Column1Jour.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Disponibilité";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "Générer un rapport PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(0, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 24);
            this.button4.TabIndex = 28;
            this.button4.Text = "Acceuil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 29;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Précédent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(812, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FicheSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(909, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FicheSalarie";
            this.Text = "FicheSalarie";
            this.Load += new System.EventHandler(this.FicheSalarie_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label maillabel;
        private System.Windows.Forms.Label telephonelabel;
        private System.Windows.Forms.Label adresselabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox adresseMail;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox dateNaissance;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.DataGridView agenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Jour;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}