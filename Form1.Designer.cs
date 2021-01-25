namespace SlamFingers
{
    partial class FrmMain
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
            this.lbRules = new System.Windows.Forms.Label();
            this.lbMot = new System.Windows.Forms.Label();
            this.tBReponse = new System.Windows.Forms.TextBox();
            this.gBClassement = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbpoints = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.btCredits = new System.Windows.Forms.Button();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.gBClassement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRules
            // 
            this.lbRules.AutoSize = true;
            this.lbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRules.Location = new System.Drawing.Point(132, 37);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(234, 24);
            this.lbRules.TabIndex = 1;
            this.lbRules.Text = "Écrivez le mot ci-dessous :";
            // 
            // lbMot
            // 
            this.lbMot.AutoSize = true;
            this.lbMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMot.ForeColor = System.Drawing.Color.Red;
            this.lbMot.Location = new System.Drawing.Point(200, 83);
            this.lbMot.Name = "lbMot";
            this.lbMot.Size = new System.Drawing.Size(67, 35);
            this.lbMot.TabIndex = 2;
            this.lbMot.Text = "Mot";
            // 
            // tBReponse
            // 
            this.tBReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBReponse.Location = new System.Drawing.Point(136, 150);
            this.tBReponse.Name = "tBReponse";
            this.tBReponse.Size = new System.Drawing.Size(230, 35);
            this.tBReponse.TabIndex = 3;
            this.tBReponse.TextChanged += new System.EventHandler(this.playGame);
            // 
            // gBClassement
            // 
            this.gBClassement.BackColor = System.Drawing.Color.Transparent;
            this.gBClassement.Controls.Add(this.label10);
            this.gBClassement.Controls.Add(this.label9);
            this.gBClassement.Controls.Add(this.label8);
            this.gBClassement.Controls.Add(this.label7);
            this.gBClassement.Controls.Add(this.label6);
            this.gBClassement.Controls.Add(this.label5);
            this.gBClassement.Controls.Add(this.label4);
            this.gBClassement.Controls.Add(this.label3);
            this.gBClassement.Controls.Add(this.label2);
            this.gBClassement.Controls.Add(this.button1);
            this.gBClassement.Controls.Add(this.label1);
            this.gBClassement.Controls.Add(this.lbpoints);
            this.gBClassement.Controls.Add(this.lbNom);
            this.gBClassement.ForeColor = System.Drawing.Color.Red;
            this.gBClassement.Location = new System.Drawing.Point(439, 12);
            this.gBClassement.Name = "gBClassement";
            this.gBClassement.Size = new System.Drawing.Size(152, 346);
            this.gBClassement.TabIndex = 6;
            this.gBClassement.TabStop = false;
            this.gBClassement.Text = "Classement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(6, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "1. Non déterminé : 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(6, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "1. Non déterminé : 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "1. Non déterminé : 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "1. Non déterminé : 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "1. Non déterminé : 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "1. Non déterminé : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "1. Non déterminé : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "1. Non déterminé : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "1. Non déterminé : 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Saison 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Non déterminé : 0";
            // 
            // lbpoints
            // 
            this.lbpoints.AutoSize = true;
            this.lbpoints.BackColor = System.Drawing.SystemColors.Control;
            this.lbpoints.Location = new System.Drawing.Point(60, 25);
            this.lbpoints.Name = "lbpoints";
            this.lbpoints.Size = new System.Drawing.Size(13, 13);
            this.lbpoints.TabIndex = 1;
            this.lbpoints.Text = "0";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.SystemColors.Control;
            this.lbNom.Location = new System.Drawing.Point(6, 25);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(48, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Joueur : ";
            // 
            // btCredits
            // 
            this.btCredits.Location = new System.Drawing.Point(3, 345);
            this.btCredits.Name = "btCredits";
            this.btCredits.Size = new System.Drawing.Size(75, 23);
            this.btCredits.TabIndex = 7;
            this.btCredits.Text = "Crédits";
            this.btCredits.UseVisualStyleBackColor = true;
            this.btCredits.Click += new System.EventHandler(this.BtCredits_Click);
            // 
            // lbCountdown
            // 
            this.lbCountdown.AutoSize = true;
            this.lbCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.Location = new System.Drawing.Point(226, 254);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(0, 25);
            this.lbCountdown.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 370);
            this.Controls.Add(this.lbCountdown);
            this.Controls.Add(this.btCredits);
            this.Controls.Add(this.gBClassement);
            this.Controls.Add(this.tBReponse);
            this.Controls.Add(this.lbMot);
            this.Controls.Add(this.lbRules);
            this.Name = "FrmMain";
            this.Text = "SlamFingers";
            this.gBClassement.ResumeLayout(false);
            this.gBClassement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRules;
        private System.Windows.Forms.Label lbMot;
        private System.Windows.Forms.TextBox tBReponse;
        private System.Windows.Forms.GroupBox gBClassement;
        private System.Windows.Forms.Label lbpoints;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Button btCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountdown;
    }
}

