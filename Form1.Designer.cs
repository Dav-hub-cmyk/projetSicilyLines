
namespace projetSicilyLines
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.btnResa = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.tbSaisie = new System.Windows.Forms.TextBox();
            this.btnVal = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "SicilyLines";
            // 
            // btnAccueil
            // 
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.Location = new System.Drawing.Point(9, 135);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(168, 47);
            this.btnAccueil.TabIndex = 2;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // btnResa
            // 
            this.btnResa.BackColor = System.Drawing.Color.Transparent;
            this.btnResa.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResa.Location = new System.Drawing.Point(12, 232);
            this.btnResa.Name = "btnResa";
            this.btnResa.Size = new System.Drawing.Size(168, 52);
            this.btnResa.TabIndex = 3;
            this.btnResa.Text = "Reservation";
            this.btnResa.UseVisualStyleBackColor = false;
            this.btnResa.Click += new System.EventHandler(this.btnResa_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(231, 561);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(139, 36);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insertion";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(423, 561);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(131, 36);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "Modification";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(591, 560);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(139, 37);
            this.btnSup.TabIndex = 6;
            this.btnSup.Text = "Suppression";
            this.btnSup.UseVisualStyleBackColor = true;
            // 
            // tbSaisie
            // 
            this.tbSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaisie.Location = new System.Drawing.Point(752, 265);
            this.tbSaisie.Name = "tbSaisie";
            this.tbSaisie.Size = new System.Drawing.Size(271, 30);
            this.tbSaisie.TabIndex = 7;
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(907, 320);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(116, 33);
            this.btnVal.TabIndex = 8;
            this.btnVal.Text = "Valider";
            this.btnVal.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Azure;
            this.lbl.Location = new System.Drawing.Point(748, 232);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(111, 20);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Modification";
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(752, 502);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(129, 35);
            this.btnselect.TabIndex = 10;
            this.btnselect.Text = "Selectionner";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "|*txt";
            this.ofd.Title = "ouvrir un fichier";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(231, 81);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(488, 456);
            this.tb.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1221, 663);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.tbSaisie);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnResa);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnResa;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.TextBox tbSaisie;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox tb;
    }
}

