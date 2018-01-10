namespace DesktopIHM
{
    partial class FicheVoiture
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
            this.carburant = new System.Windows.Forms.TextBox();
            this.couleur = new System.Windows.Forms.TextBox();
            this.modele = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.TextBox();
            this.immatriculation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pr = new System.Windows.Forms.DataGridView();
            this.Column1Moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Horaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.carburant);
            this.groupBox2.Controls.Add(this.couleur);
            this.groupBox2.Controls.Add(this.modele);
            this.groupBox2.Controls.Add(this.marque);
            this.groupBox2.Controls.Add(this.immatriculation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 260);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations voiture";
            // 
            // carburant
            // 
            this.carburant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carburant.Location = new System.Drawing.Point(183, 204);
            this.carburant.Name = "carburant";
            this.carburant.ReadOnly = true;
            this.carburant.Size = new System.Drawing.Size(124, 20);
            this.carburant.TabIndex = 28;
            // 
            // couleur
            // 
            this.couleur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.couleur.Location = new System.Drawing.Point(183, 160);
            this.couleur.Name = "couleur";
            this.couleur.ReadOnly = true;
            this.couleur.Size = new System.Drawing.Size(124, 20);
            this.couleur.TabIndex = 27;
            // 
            // modele
            // 
            this.modele.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modele.Location = new System.Drawing.Point(183, 124);
            this.modele.Name = "modele";
            this.modele.ReadOnly = true;
            this.modele.Size = new System.Drawing.Size(124, 20);
            this.modele.TabIndex = 26;
            // 
            // marque
            // 
            this.marque.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marque.Location = new System.Drawing.Point(183, 87);
            this.marque.Name = "marque";
            this.marque.ReadOnly = true;
            this.marque.Size = new System.Drawing.Size(124, 20);
            this.marque.TabIndex = 25;
            // 
            // immatriculation
            // 
            this.immatriculation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.immatriculation.Location = new System.Drawing.Point(183, 46);
            this.immatriculation.Name = "immatriculation";
            this.immatriculation.ReadOnly = true;
            this.immatriculation.Size = new System.Drawing.Size(124, 20);
            this.immatriculation.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carburant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Couleur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modèle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marque :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Immatriculation : ";
            // 
            // pr
            // 
            this.pr.AllowUserToAddRows = false;
            this.pr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Moniteur,
            this.Column1Client,
            this.Column1Horaire});
            this.pr.Location = new System.Drawing.Point(15, 19);
            this.pr.Name = "pr";
            this.pr.ReadOnly = true;
            this.pr.Size = new System.Drawing.Size(349, 251);
            this.pr.TabIndex = 24;
            // 
            // Column1Moniteur
            // 
            this.Column1Moniteur.HeaderText = "Moniteur";
            this.Column1Moniteur.Name = "Column1Moniteur";
            this.Column1Moniteur.ReadOnly = true;
            // 
            // Column1Client
            // 
            this.Column1Client.HeaderText = "Client";
            this.Column1Client.Name = "Column1Client";
            this.Column1Client.ReadOnly = true;
            // 
            // Column1Horaire
            // 
            this.Column1Horaire.HeaderText = "Horaire";
            this.Column1Horaire.Name = "Column1Horaire";
            this.Column1Horaire.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 24);
            this.button4.TabIndex = 27;
            this.button4.Text = "Acceuil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 30;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 21);
            this.button2.TabIndex = 31;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(215, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 122);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pr);
            this.groupBox1.Location = new System.Drawing.Point(377, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 274);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planning de réservation";
            // 
            // FicheVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Name = "FicheVoiture";
            this.Text = "FicheVoiture";
            this.Load += new System.EventHandler(this.FicheVoiture_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox carburant;
        private System.Windows.Forms.TextBox couleur;
        private System.Windows.Forms.TextBox modele;
        private System.Windows.Forms.TextBox marque;
        private System.Windows.Forms.TextBox immatriculation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Moniteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Horaire;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}