namespace DesktopIHM
{
    partial class RechercheVoiture
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
            this.immatriculation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modeleVoiture = new System.Windows.Forms.TextBox();
            this.modele = new System.Windows.Forms.Label();
            this.marqueVoiture = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultatVoiture = new System.Windows.Forms.DataGridView();
            this.Column1Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1PageVoiture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultatVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Immatriculation : ";
            // 
            // immatriculation
            // 
            this.immatriculation.Location = new System.Drawing.Point(182, 42);
            this.immatriculation.Name = "immatriculation";
            this.immatriculation.Size = new System.Drawing.Size(153, 20);
            this.immatriculation.TabIndex = 25;
            this.immatriculation.TextChanged += new System.EventHandler(this.immatriculation_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.modeleVoiture);
            this.groupBox1.Controls.Add(this.modele);
            this.groupBox1.Controls.Add(this.marqueVoiture);
            this.groupBox1.Controls.Add(this.marque);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.immatriculation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 239);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Voiture";
            // 
            // modeleVoiture
            // 
            this.modeleVoiture.Location = new System.Drawing.Point(182, 151);
            this.modeleVoiture.Name = "modeleVoiture";
            this.modeleVoiture.Size = new System.Drawing.Size(153, 20);
            this.modeleVoiture.TabIndex = 30;
            // 
            // modele
            // 
            this.modele.AutoSize = true;
            this.modele.Location = new System.Drawing.Point(37, 154);
            this.modele.Name = "modele";
            this.modele.Size = new System.Drawing.Size(48, 13);
            this.modele.TabIndex = 29;
            this.modele.Text = "Modèle :";
            // 
            // marqueVoiture
            // 
            this.marqueVoiture.Location = new System.Drawing.Point(182, 98);
            this.marqueVoiture.Name = "marqueVoiture";
            this.marqueVoiture.Size = new System.Drawing.Size(153, 20);
            this.marqueVoiture.TabIndex = 28;
            // 
            // marque
            // 
            this.marque.AutoSize = true;
            this.marque.Location = new System.Drawing.Point(37, 101);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(49, 13);
            this.marque.TabIndex = 27;
            this.marque.Text = "Marque :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultatVoiture
            // 
            this.resultatVoiture.AllowUserToAddRows = false;
            this.resultatVoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultatVoiture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Immatriculation,
            this.Column1Marque,
            this.Column1Modele,
            this.Column1PageVoiture});
            this.resultatVoiture.Location = new System.Drawing.Point(382, 55);
            this.resultatVoiture.Name = "resultatVoiture";
            this.resultatVoiture.ReadOnly = true;
            this.resultatVoiture.Size = new System.Drawing.Size(444, 209);
            this.resultatVoiture.TabIndex = 27;
            this.resultatVoiture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultatVoiture_CellContentClick);
            // 
            // Column1Immatriculation
            // 
            this.Column1Immatriculation.HeaderText = "Immatriculation";
            this.Column1Immatriculation.Name = "Column1Immatriculation";
            this.Column1Immatriculation.ReadOnly = true;
            // 
            // Column1Marque
            // 
            this.Column1Marque.HeaderText = "Marque";
            this.Column1Marque.Name = "Column1Marque";
            this.Column1Marque.ReadOnly = true;
            // 
            // Column1Modele
            // 
            this.Column1Modele.HeaderText = "Modele";
            this.Column1Modele.Name = "Column1Modele";
            this.Column1Modele.ReadOnly = true;
            // 
            // Column1PageVoiture
            // 
            this.Column1PageVoiture.HeaderText = "Page Voiture";
            this.Column1PageVoiture.Name = "Column1PageVoiture";
            this.Column1PageVoiture.ReadOnly = true;
            this.Column1PageVoiture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1PageVoiture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1PageVoiture.Text = "Voir";
            this.Column1PageVoiture.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Resultat de recherche :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "précédent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RechercheVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(832, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultatVoiture);
            this.Controls.Add(this.groupBox1);
            this.Name = "RechercheVoiture";
            this.Text = "RechercheVoiture :";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultatVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox immatriculation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox modeleVoiture;
        private System.Windows.Forms.Label modele;
        private System.Windows.Forms.TextBox marqueVoiture;
        private System.Windows.Forms.Label marque;
        private System.Windows.Forms.DataGridView resultatVoiture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Modele;
        private System.Windows.Forms.DataGridViewButtonColumn Column1PageVoiture;
        private System.Windows.Forms.Button button2;
    }
}